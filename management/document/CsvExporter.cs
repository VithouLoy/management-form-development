using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace management.document
{
    internal class CsvExporter<T> : AbstractDataExporter<T> where T : class
    {
        private ClassMap<T> map;

        public CsvExporter(ClassMap<T> map)
        {
            this.map = map;
        }

        protected override void doExport(string path, List<T> data)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

                CsvSettingUtils.configure(csvWriter);
                csvWriter.Context.RegisterClassMap(map);

                csvWriter.WriteHeader<Student>();
                csvWriter.WriteRecord(data);
            }
        }
    }
}
