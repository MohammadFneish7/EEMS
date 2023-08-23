using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEMS.Web.ATS.Objects
{
    public class QueryResult<T> where T : ExtendedTableEntity
    {
        public List<T> Entities { get; set; }
        public NextPage NextPage { get; set; }

        internal QueryResult(List<T> result, TableContinuationToken token)
        {
            Entities = result;
            if (token != null)
                NextPage = new NextPage(token);
        }

        public QueryResult() { }

    }
}
