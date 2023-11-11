using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.repository
{
    internal interface IWriterRepository<T>
    {
        bool Add(T data);

        void Update(T data);

        void Delete(T data);

        void AddAll(List<T> list);
    }
}
