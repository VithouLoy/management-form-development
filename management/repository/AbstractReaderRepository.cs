using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using management.mapper;
using Microsoft.EntityFrameworkCore;

namespace management.repository
{
    internal abstract class AbstractReaderRepository<T> : IReaderListRepository<T>
    {
        public List<T> ReadAllBy<D>(params D[] data)
        {

            return this.shouldRead(QueryReader.READ_ALL_BY, data);
        }

        public List<T> ReadAll()
        {     
            return this.shouldRead(QueryReader.READ_ALL, string.Empty);
        }


        public T ReadBy<D>(params D[] data)
        {
            return shouldRead(QueryReader.READ_BY, data).First();
        }


        protected abstract List<T> shouldRead<D>(QueryReader qr, params D[] data);
    }
}
