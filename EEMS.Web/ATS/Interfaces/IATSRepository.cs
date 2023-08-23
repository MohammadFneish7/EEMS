using EEMS.Web.ATS.Objects;
using Microsoft.WindowsAzure.Storage.Table;

namespace EEMS.Web.ATS.Interfaces
{
    public interface IATSRepository<T> where T : ExtendedTableEntity
    {
        delegate void OnWriteEventHandler(T entity);
        event OnWriteEventHandler OnWriteEvent;
        Task<QueryResult<T>> AllAsync();
        Task<ulong> CountAsync(string filter = null);
        Task<TableResult> DeleteAsync(string partitionKey, string rowKey);
        Task<TableResult> DeleteAsync(T entity);
        Task<IList<TableResult>> DeleteManyAsync(List<T> entity);
        Task<T> FirstOrDefaultAsync();
        Task<TableResult> InsertAsync(T entity);
        Task<IList<TableResult>> InsertManyAsync(List<T> entity);
        Task<QueryResult<T>> ManyAsync(int limit = -1, NextPage nextPage = null);
        Task<QueryResult<T>> ManyAsync(string filter, int limit = -1, NextPage nextPage = null);
        Task<QueryResult<T>> ManyByPartitionAsync(string partitionKey, int limit = -1, NextPage nextPage = null);
        Task<T> SingleAsync(string filter);
        Task<T> SingleAsync(string partitionKey, string rowKey);
        Task<T> SingleAsync(T entity);
        Task<T> SingleByRowKeyAsync(string rowKey);
        Task<TableResult> UpdateAsync(T entity);
        Task<IList<TableResult>> UpdateManyAsync(List<T> entity);
        Task<TableResult> UpsertAsync(T entity);
        Task<IList<TableResult>> UpsertManyAsync(List<T> entity);
    }
}