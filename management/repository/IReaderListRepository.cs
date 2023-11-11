using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.repository
{
    internal interface IReaderListRepository<T>
    {
        List<T> ReadAll();


        List<T> ReadAllBy<D>(params D[] data);


        T ReadBy<D>(params D[] data);
    }
}
