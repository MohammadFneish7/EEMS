using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEMS.Web.ATS.Enums;

namespace EEMS.Web.ATS.Objects
{
    public class QueryGroup
    {
        public List<Query> Queries { get; set; } = new List<Query>();
        public QueryOperator Operator { get; set; } = QueryOperator.And;

        public string Build()
        {
            return string.Join($" {Operator.ToATSOperator()} ", Queries.Select(c => $"({c.Build()})").ToList());
        }
    }
}
