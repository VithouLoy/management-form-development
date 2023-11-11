using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

namespace management.document
{
    internal abstract class AbstractDataExporter<T> : IDataExporter<T> where T : class
    {
        public void export(string path, List<T> data)
        {
           this.validate(path, data);
           this.doExport(path, data);
        }

        protected abstract void doExport(string path, List<T> data);

        protected virtual void validate(string path, List<T> data)
        {
            if (data == null && data.Count == 0 && File.Exists(path)) throw new ArgumentNullException();
        }
    }
}
