using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace EEMS.Web.ATS.Objects
{
    public class NextPage
    {
        public string NextPartitionKey { get; set; }
        public string NextRowKey { get; set; }
        public string NextTableName { get; set; }
        public StorageLocation? TargetLocation { get; set; }

        public NextPage() { }

        internal NextPage(TableContinuationToken tableContinuation)
        {
            NextPartitionKey = tableContinuation.NextPartitionKey;
            NextRowKey = tableContinuation.NextRowKey;
            NextTableName = tableContinuation.NextTableName;
            TargetLocation = tableContinuation.TargetLocation;
        }

        internal TableContinuationToken GetToken()
        {
            return new TableContinuationToken()
            {
                NextPartitionKey = NextPartitionKey,
                NextRowKey = NextRowKey,
                NextTableName = NextTableName,
                TargetLocation = TargetLocation
            };
        }
    }
}
