using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using management.document;
using management.mapper;
using management.repository;

namespace management.factory
{
    internal class StudentImporterFactory
    {
        public static IDataImporter<Student> create(string type)
        {
            switch (type)
            {
                case ".xlsx":
                    return new ExcelImporter<Student>(new StudentExcelMapper());
                case ".json":
                    return new JsonDataImporter<Student>();
                case ".csv":
                    return new CsvImporter<Student>(new StudentCsvMapper());
                default: throw new ArgumentException("There is no such type");
            }
        }
    }
}
