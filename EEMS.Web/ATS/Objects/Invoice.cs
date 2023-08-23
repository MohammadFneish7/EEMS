using Microsoft.WindowsAzure.Storage.Table;

namespace EEMS.Web.ATS.Objects
{
    public class Invoice : ExtendedTableEntity
    {
        public Dictionary<string,string> Data { get; set; }

        public Invoice()
        {

        }

        public Invoice(string group, string clientId, int year, int month, Dictionary<string, string> data) : base(group, $"{clientId}-{year}-{month}".ToLower())
        {
            Data = data;
        }
    }
}
