using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EEMS.Web.ATS.Objects
{
    public class ExtendedTableEntity : TableEntity
    {
        public ExtendedTableEntity()
        {

        }
        public ExtendedTableEntity(string PartitionKey, string RowKey) : base(PartitionKey, RowKey)
        {

        }

        public override void ReadEntity(IDictionary<string, EntityProperty> properties, OperationContext operationContext)
        {
            base.ReadEntity(properties, operationContext);
            foreach (KeyValuePair<string, EntityProperty> prop in properties)
            {
                var property = GetType().GetProperty(prop.Key);
                if (property != null)
                {
                    if (prop.Value.PropertyAsObject != null && !property.PropertyType.IsPrimitive && !property.PropertyType.IsEnum && property.PropertyType != typeof(Guid) && property.PropertyType != typeof(string) && property.PropertyType != typeof(DateTime) && property.PropertyType != typeof(byte[]))
                    {
                        property.SetValue(this, JsonConvert.DeserializeObject($"{prop.Value.StringValue}", property.PropertyType));
                    }
                }
            }
        }

        public override IDictionary<string, EntityProperty> WriteEntity(OperationContext operationContext)
        {
            var x = base.WriteEntity(operationContext);
            foreach (var prop in GetType().GetProperties())
            {
                var property = GetType().GetProperty(prop.Name);
                if (property != null)
                {
                    if (prop.GetValue(this) != null && !property.PropertyType.IsPrimitive && !property.PropertyType.IsEnum && property.PropertyType != typeof(Guid) && property.PropertyType != typeof(string) && property.PropertyType != typeof(DateTime) && property.PropertyType != typeof(byte[]))
                    {
                        x[prop.Name] = new EntityProperty(JsonConvert.SerializeObject(prop.GetValue(this)));
                    }
                }
            }
            return x;
        }
    }
}
