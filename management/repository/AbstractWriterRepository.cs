using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.repository
{
    internal abstract class AbstractWriterRepository<T> : IWriterRepository<T>
    {
        public bool Add(T data)
        {
            this.validate(data);
            this.shouldWrite(data, QueryWriter.INSERT);
            return true;
        }

        public void AddAll(List<T> list)
        {
            list.ForEach(item => this.shouldWrite(item, QueryWriter.INSERT));
        }

        public void Delete(T data)
        {
            this.shouldWrite(data, QueryWriter.DELETE);
        }

        public void Update(T data)
        {
            this.validate(data);
            this.shouldWrite(data, QueryWriter.UPDATE);
        }




        protected abstract void shouldWrite(T data, QueryWriter writer);


        private void validate(T data)
        {
            if (data == null)
            {
                throw new NullReferenceException("Data must be non null");
            }
        }
    }
}
