using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Shapes;
using ExcelDataReader;

namespace management.repository
{
    internal abstract class AbstractDataImporter<T> : IDataImporter<T>
    {
        public List<T> import(string path)
        {
            this.validate(path);
            return this.doImport(path);
        }

        protected abstract List<T> doImport(string path);

        protected virtual void validate(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                throw new NotSupportedException();
            }
        }
    }
}
