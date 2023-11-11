using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.TypeConversion;

namespace management.document
{
    internal class CsvSettingUtils
    {
        public static void configure(object csvConfig)
        {
            var options = new TypeConverterOptions { Formats = new[] { "dd/MM/yyyy" } };
            if (csvConfig is CsvReader reader) { 
                reader.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
                reader.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(options);
            }

            if (csvConfig is CsvWriter writer)
            {
                writer.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
                writer.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(options);
            }
        }
    }
}
