using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using management.repository;

namespace management.document
{
    internal class CsvImporter<T> : AbstractDataImporter<T>
    {
        private ClassMap<T> classMap;

        public CsvImporter(ClassMap<T> classMap)
        {
            this.classMap = classMap;
        }

        protected override List<T> doImport(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
                CsvSettingUtils.configure(csvReader);
                csvReader.Context.RegisterClassMap(classMap);
                return csvReader.GetRecords<T>().ToList();
            }
        }
    }
}
    