using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEMS.Web.ATS.Enums;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json.Linq;

namespace EEMS.Web.ATS.Objects
{
    public class Query
    {
        public List<QueryCondition> Conditions { get; set; } = new List<QueryCondition>();
        public QueryOperator Operator { get; set; } = QueryOperator.And;

        public Query(List<QueryCondition> conditions, QueryOperator _operator)
        {
            Conditions = conditions;
            Operator = _operator;
        }

        public Query(QueryOperator _operator)
        {
            Operator = _operator;
        }

        public void AddCondition(QueryCondition queryCondition)
        {
            Conditions.Add(queryCondition);
        }

        public string Build()
        {
            return string.Join($" {Operator.ToATSOperator()} ", Conditions.Select(c => $"({c.Build()})").ToList());
        }
    }
}
