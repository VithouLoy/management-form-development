using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using management.mapper;
using management.repository;

namespace management.document
{
    internal class ExcelImporter<T> : AbstractDataImporter<T>
    {
        private IEntityMapper<T> mapper;
        public ExcelImporter(IEntityMapper<T> mapper)
        {
            this.mapper = mapper;
        }


        protected override List<T> doImport(string path)
        {
            List<T> list = new List<T>();
            using (var file = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(file))
                {
                    while (reader.Read())
                    {
                        list.Add(mapper.map(reader));
                    }
                }
            }

            return list.Skip(1).ToList();
        }
    }
}
