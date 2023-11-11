using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using management.mapper;

namespace management.repository
{
    internal class PersonReaderRepository : AbstractSqlListReader<Person>
    {
        public PersonReaderRepository() : base(new PersonDataMapper())
        {
        }

        protected override string getReadAllQuery()
        {
            return "SELECT * FROM students WHERE Deleted = 0 ORDER BY Id ASC";
        }

        protected override string getReadAllByQuery<D>(params D[] data)
        {
            base.clear();
            base.addParameter("@Filter", "%" + data[0] + "%");
            base.addParameter("@Gender", data[0]);
            return "SELECT * FROM students WHERE (Firstname LIKE @Filter OR Lastname LIKE @Filter OR Email LIKE @Filter OR Phone LIKE @Filter OR Gender = @Gender) AND Deleted = 0";
        }
    }
}
