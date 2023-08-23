using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEMS.Web.ATS.Enums;
using Microsoft.WindowsAzure.Storage.Table;

namespace EEMS.Web.ATS.Objects
{
    public class QueryCondition
    {
        public string Field { get; set; }
        public QueryComparison Condition { get; set; } = QueryComparison.Equal;
        public object Value { get; set; }

        public QueryCondition(string field, QueryComparison condition, object value)
        {
            Field = field;
            Condition = condition;
            Value = value;
        }

        public string Build()
        {
            if (Value == null)
                return TableQuery.GenerateFilterCondition(Field, Condition.ToATSComparison(), null);

            var type = Value.GetType();
            if (type == typeof(string))
            {
                if (Condition == QueryComparison.StartsWith)
                    return GeenerateStartsWithFilter(Field, (string)Value);
                else
                    return TableQuery.GenerateFilterCondition(Field, Condition.ToATSComparison(), (string)Value);
            }
            else if (type == typeof(bool))
            {
                return TableQuery.GenerateFilterConditionForBool(Field, Condition.ToATSComparison(), (bool)Value);
            }
            else if (type == typeof(int) || type.IsEnum)
            {
                return TableQuery.GenerateFilterConditionForInt(Field, Condition.ToATSComparison(), (int)Value);
            }
            else if (type == typeof(long))
            {
                return TableQuery.GenerateFilterConditionForLong(Field, Condition.ToATSComparison(), (long)Value);
            }
            else if (type == typeof(double))
            {
                return TableQuery.GenerateFilterConditionForDouble(Field, Condition.ToATSComparison(), (double)Value);
            }
            else if (type == typeof(byte[]))
            {
                return TableQuery.GenerateFilterConditionForBinary(Field, Condition.ToATSComparison(), (byte[])Value);
            }
            else if (type == typeof(Guid))
            {
                return TableQuery.GenerateFilterConditionForGuid(Field, Condition.ToATSComparison(), (Guid)Value);
            }
            else if (type == typeof(DateTime))
            {
                return TableQuery.GenerateFilterConditionForDate(Field, Condition.ToATSComparison(), (DateTime)Value);
            }
            else
            {
                throw new ArgumentException($"Not supported query value type '{type}'");
            }
        }

        public string GeenerateStartsWithFilter(string columnName, string startsWith)
        {
            var length = startsWith.Length - 1;
            var nextChar = startsWith[length] + 1;

            var startWithEnd = startsWith.Substring(0, length) + (char)nextChar;
            var filter = TableQuery.CombineFilters(
                TableQuery.GenerateFilterCondition(columnName, QueryComparisons.GreaterThanOrEqual, startsWith),
                TableOperators.And,
                TableQuery.GenerateFilterCondition(columnName, QueryComparisons.LessThan, startWithEnd));

            return filter;
        }
    }
}
