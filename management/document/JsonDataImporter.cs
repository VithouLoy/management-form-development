using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using management.repository;
using management.utils;

namespace management.document
{
    internal class JsonDataImporter<T> : AbstractDataImporter<T>
    {
 

        protected override List<T> doImport(string path)
        {
            using (var reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                List<T> list = JsonSerializer.Deserialize<List<T>>(json, this.setUpJsonSetting());

                return list;
            }
        }

        protected virtual JsonSerializerOptions setUpJsonSetting()
        {
            JsonSerializerOptions jsonSerializer = new JsonSerializerOptions();
            jsonSerializer.PropertyNameCaseInsensitive = true;
            jsonSerializer.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            jsonSerializer.IgnoreReadOnlyProperties = true;
            jsonSerializer.Converters.Add(new DateTimeConverterUsingDateTimeParse());
            return jsonSerializer;
        }
    }
}
