using Azure.Core;
using Azure.Identity;
using EEMS.Web.ATS.Interfaces;
using EEMS.Web.ATS.Objects;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;

namespace EEMS.Web.ATS.Repositories
{
    public class ATSRepository<T> : IATSRepository<T> where T : ExtendedTableEntity
    {
        internal CloudStorageAccount _CloudStorageAccount;
        internal CloudTableClient _CloudTableClient;
        internal string _TableName;
        internal CloudTable _Table;

        public event IATSRepository<T>.OnWriteEventHandler OnWriteEvent;

        public ATSRepository(ATSConfiguration aTSConfiguration)
        {
            if (aTSConfiguration == null)
                throw new ArgumentNullException("ATSConfiguration");

            Init(aTSConfiguration.AccountName, aTSConfiguration.AccountKey);
        }

        public ATSRepository(string azureStorageAccountName, string azureStorageAccountKey)
        {
            Init(azureStorageAccountName, azureStorageAccountKey);
        }

        private async void Init(string azureStorageAccountName, string azureStorageAccountKey)
        {
            if (string.IsNullOrEmpty(azureStorageAccountName))
                throw new ArgumentNullException("azureStorageAccountName");

            if (string.IsNullOrEmpty(azureStorageAccountKey))
                throw new ArgumentNullException("azureStorageAccountKey");

            _CloudStorageAccount = new CloudStorageAccount(
                new StorageCredentials(
                azureStorageAccountName, azureStorageAccountKey),
                true
            );

            _TableName = typeof(T).Name;

            _CloudTableClient = _CloudStorageAccount.CreateCloudTableClient();

            await EnsureTableExistsAsync();
        }

        internal async Task<NewTokenAndFrequency> TokenRenewerAsync(object state, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                // Note: you can also specify the root URI for your storage account.
                const string STORAGE_RESOURCE = "https://storage.azure.com/";
                var authResult = new DefaultAzureCredential().GetToken(new TokenRequestContext(
                new[] { STORAGE_RESOURCE }));
                // Renew the token 5 minutes before it expires.
                var next = authResult.ExpiresOn - DateTimeOffset.UtcNow - TimeSpan.FromMinutes(5);
                if (next.Ticks < 0)
                {
                    next = default;
                    Console.WriteLine("Renewing token...");
                }
                // Return the new token and the next refresh time.
                return new NewTokenAndFrequency(authResult.Token + "+", next);
            });
        }

        public async Task<T> FirstOrDefaultAsync()
        {
            TableQuery tableQuery = new TableQuery().Take(1);

            TableContinuationToken token = default;

            TableQuerySegment result = await _Table.ExecuteQuerySegmentedAsync(tableQuery, token);

            return GetT(result.Results.FirstOrDefault());
        }

        public async Task<T> SingleAsync(T entity)
        {
            TableResult tableResult = await ExecuteAsync(
                TableOperation.Retrieve<T>(entity.PartitionKey, entity.RowKey, null)
            );

            if (tableResult.Result == null) return null;

            return (T)tableResult.Result;
        }

        public async Task<T> SingleAsync(string partitionKey, string rowKey)
        {
            TableResult tableResult = await ExecuteAsync(
                TableOperation.Retrieve<T>(partitionKey, rowKey, null)
            );

            if (tableResult.Result == null) return null;

            return (T)tableResult.Result;
        }

        public async Task<T> SingleByRowKeyAsync(string rowKey)
        {
            TableQuery tableQuery = new TableQuery();

            tableQuery.Where(TableQuery.GenerateFilterCondition("RowKey", QueryComparisons.Equal, rowKey)).Take(1);

            TableContinuationToken token = default;

            TableQuerySegment result = await _Table.ExecuteQuerySegmentedAsync(tableQuery, token);

            return GetT(result.Results.FirstOrDefault());
        }

        public async Task<T> SingleAsync(string filter)
        {
            var query = new TableQuery().Where(filter).Take(1);

            TableContinuationToken token = default;

            TableQuerySegment result = await _Table.ExecuteQuerySegmentedAsync(query, token);

            return GetT(result.Results.FirstOrDefault());
        }

        public async Task<QueryResult<T>> AllAsync()
        {
            return await ManyAsync(null, -1, null);
        }

        public async Task<QueryResult<T>> ManyAsync(int limit = -1, NextPage nextPage = null)
        {
            return await ManyAsync(null, limit, nextPage);
        }

        public async Task<QueryResult<T>> ManyByPartitionAsync(string partitionKey, int limit = -1, NextPage nextPage = null)
        {
            return await ManyAsync(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey), limit, nextPage);
        }

        public async Task<QueryResult<T>> ManyAsync(string filter, int limit = -1, NextPage nextPage = null)
        {
            List<T> results = new List<T>();
            int counter = 0;
            TableContinuationToken token = nextPage != null ? nextPage.GetToken() : default;
            do
            {
                TableQuery tableQuery = new TableQuery();

                if (filter != null)
                    tableQuery = tableQuery.Where(filter);

                if (limit > -1)
                    tableQuery.Take(limit - counter);

                TableQuerySegment result = await _Table.ExecuteQuerySegmentedAsync(tableQuery, token);

                token = result.ContinuationToken;

                foreach (DynamicTableEntity dynamicTableEntity in result.Results)
                {
                    if (limit < 0 || counter++ < limit)
                        results.Add(
                            GetT(dynamicTableEntity)
                        );
                    else
                        break;
                }
            } while (token != null && (limit < 0 || counter < limit));

            return new QueryResult<T>(results, token);
        }

        public async Task<TableResult> InsertAsync(T entity)
        {
            TableResult tableResult = await ExecuteAsync(
                TableOperation.Insert(entity)
            );
            OnWriteEvent?.Invoke(entity);
            return tableResult;
        }

        public async Task<IList<TableResult>> InsertManyAsync(List<T> entity)
        {
            var batchOperationObj = new TableBatchOperation();

            foreach (T entityItem in entity)
            {
                batchOperationObj.Insert(entityItem);
                OnWriteEvent?.Invoke(entityItem);
            }
            var tableResult = await ExecuteBatchAsync(batchOperationObj);

            return tableResult;
        }

        public async Task<TableResult> UpsertAsync(T entity)
        {
            TableResult tableResult = await ExecuteAsync(
                TableOperation.InsertOrMerge(entity)
            );

            OnWriteEvent?.Invoke(entity);
            return tableResult;
        }

        public async Task<IList<TableResult>> UpsertManyAsync(List<T> entity)
        {
            var batchOperationObj = new TableBatchOperation();

            foreach (T entityItem in entity)
            {
                batchOperationObj.InsertOrMerge(entityItem);
                OnWriteEvent?.Invoke(entityItem);
            }
            var tableResult = await ExecuteBatchAsync(batchOperationObj);

            return tableResult;
        }

        public async Task<TableResult> UpdateAsync(T entity)
        {
            entity.ETag = "*";

            var result = await ExecuteAsync(
                TableOperation.Merge(entity)
            );
            OnWriteEvent?.Invoke(entity);

            return result;
        }

        public async Task<IList<TableResult>> UpdateManyAsync(List<T> entity)
        {
            var batchOperationObj = new TableBatchOperation();

            foreach (T entityItem in entity)
            {
                batchOperationObj.Merge(entityItem);
                OnWriteEvent?.Invoke(entityItem);
            }
            var tableResult = await ExecuteBatchAsync(batchOperationObj);

            return tableResult;
        }

        public async Task<TableResult> DeleteAsync(string partitionKey, string rowKey)
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            entity.PartitionKey = partitionKey;
            entity.RowKey = rowKey;

            entity.ETag = "*";

            var result = await ExecuteAsync(
                TableOperation.Delete(entity)
            );
            OnWriteEvent?.Invoke(entity);

            return result;
        }

        public async Task<TableResult> DeleteAsync(T entity)
        {
            entity.ETag = "*";

            var result = await ExecuteAsync(
                TableOperation.Delete(entity)
            );
            OnWriteEvent?.Invoke(entity);

            return result;
        }

        public async Task<IList<TableResult>> DeleteManyAsync(List<T> entity)
        {
            var batchOperationObj = new TableBatchOperation();

            foreach (T entityItem in entity)
            {
                entityItem.ETag = "*";
                batchOperationObj.Delete(entityItem);
                OnWriteEvent?.Invoke(entityItem);
            }
            var tableResult = await ExecuteBatchAsync(batchOperationObj);

            return tableResult;
        }

        public async Task<ulong> CountAsync(string filter = null)
        {
            TableQuery<DynamicTableEntity> projectionQuery = new TableQuery<DynamicTableEntity>().Select(
                new string[] { "PartitionKey" });

            if (!string.IsNullOrEmpty(filter))
                projectionQuery = projectionQuery.Where(filter);

            EntityResolver<CountEntity> resolver = (pk, rk, ts, props, etag) => new CountEntity();

            ulong counter = 0;
            TableContinuationToken token = default;
            do
            {
                TableQuerySegment<CountEntity> result = await _Table.ExecuteQuerySegmentedAsync(projectionQuery, resolver, token);
                token = result.ContinuationToken;
                counter += Convert.ToUInt64(result.Results.Count);
            } while (token != null);

            return counter;
        }

        internal async Task EnsureTableExistsAsync()
        {
            _Table = _CloudTableClient.GetTableReference(_TableName);
            var success = await _Table.CreateIfNotExistsAsync();
            Console.WriteLine(success);
        }

        internal async Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation tableOperation)
        {
            var tableResult = await _Table.ExecuteBatchAsync(tableOperation);

            if (tableResult == null) throw new Exception($"Unable batch table operation failed to execute.");

            return tableResult;
        }

        internal async Task<IList<TableResult>> ExecuteBatchAsync(TableBatchOperation tableOperation, string newTable)
        {
            CloudTable _newTable = await CreateTableIfNotExistsAsync(newTable);

            var tableResult = await _newTable.ExecuteBatchAsync(tableOperation);

            if (tableResult == null) throw new Exception($"Unable batch table operation failed to execute.");

            return tableResult;
        }

        internal async Task<TableResult> ExecuteAsync(TableOperation tableOperation)
        {
            TableResult tableResult = await _Table.ExecuteAsync(tableOperation);

            if (tableResult == null) throw new Exception($"Unable to retrieve entity from table. {tableResult.HttpStatusCode}");

            return tableResult;
        }

        internal async Task<TableResult> ExecuteAsync(TableOperation tableOperation, string newTable)
        {
            CloudTable _newTable = await CreateTableIfNotExistsAsync(newTable);

            TableResult tableResult = await _newTable.ExecuteAsync(tableOperation);

            if (tableResult == null) throw new Exception($"Unable to retrieve entity from table. {tableResult.HttpStatusCode}");

            return tableResult;
        }

        private async Task<CloudTable> CreateTableIfNotExistsAsync(string newTable)
        {
            CloudTable _newTable = _CloudTableClient.GetTableReference(newTable);

            if (!await _newTable.ExistsAsync())
            {
                await _newTable.CreateAsync();
            }

            return _newTable;
        }

        internal T GetT(DynamicTableEntity dynamicTableEntity)
        {
            if (dynamicTableEntity == null)
                return null;

            Type type = typeof(T);

            T t = (T)Activator.CreateInstance(type);

            foreach (KeyValuePair<string, EntityProperty> prop in dynamicTableEntity.Properties)
            {
                var property = type.GetProperty(prop.Key);
                if (property != null)
                {
                    if (prop.Value.PropertyAsObject == null || property.PropertyType == typeof(string) || property.PropertyType.IsPrimitive || property.PropertyType.IsEnum || property.PropertyType == typeof(Guid) || property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(byte[]))
                    {
                        if (property.PropertyType.IsEnum)
                            property.SetValue(t, Enum.ToObject(property.PropertyType, prop.Value.PropertyAsObject));
                        else
                            property.SetValue(t, prop.Value.PropertyAsObject);
                    }
                    else
                    {
                        property.SetValue(t, JsonConvert.DeserializeObject($"{prop.Value.PropertyAsObject}", property.PropertyType));
                    }
                }

            }

            return t;
        }

    }
}
