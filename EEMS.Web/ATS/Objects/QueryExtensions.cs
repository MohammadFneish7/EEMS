using EEMS.Web.ATS.Enums;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEMS.Web.ATS.Objects
{
    internal static class QueryExtensions
    {

        internal static string ToATSComparison(this QueryComparison queryComparison)
        {
            switch (queryComparison)
            {
                case QueryComparison.Equal:
                    return QueryComparisons.Equal;
                case QueryComparison.NotEqual:
                    return QueryComparisons.NotEqual;
                case QueryComparison.LessThanOrEqual:
                    return QueryComparisons.LessThanOrEqual;
                case QueryComparison.LessThan:
                    return QueryComparisons.LessThan;
                case QueryComparison.GreaterThanOrEqual:
                    return QueryComparisons.GreaterThanOrEqual;
                case QueryComparison.GreaterThan:
                    return QueryComparisons.GreaterThan;
                case QueryComparison.StartsWith:
                    return "sw";
                default:
                    return QueryComparisons.Equal;
            }
        }

        internal static string ToATSOperator(this QueryOperator queryOperator)
        {
            switch (queryOperator)
            {
                case QueryOperator.And:
                    return TableOperators.And;
                case QueryOperator.Or:
                    return TableOperators.Or;
                default:
                    return TableOperators.And;
            }
        }
    }
}
