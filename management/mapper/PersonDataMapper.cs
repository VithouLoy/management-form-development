using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.mapper
{
    internal class PersonDataMapper : IEntityMapper<Person>
    {
        public Person map(IDataRecord dataRecord)
        {
            DbDataReader reader = (DbDataReader)dataRecord;

            int firstNameOrdinal = reader.GetOrdinal("Firstname");
            int lastNameOrdinal = reader.GetOrdinal("Lastname");
            int phoneOrdinal = reader.GetOrdinal("Phone");
            int emailOrdinal = reader.GetOrdinal("Email");
            int genderOrdinal = reader.GetOrdinal("Gender");
            int idOrdinal = reader.GetOrdinal("ID");

            Person person = new Person();
            person.Id = reader.GetFieldValue<int>(idOrdinal);
            person.Firstname = reader.GetFieldValue<string>(firstNameOrdinal);
            person.Lastname = reader.GetFieldValue<string>(lastNameOrdinal);
            person.Email = reader.GetFieldValue<string>(emailOrdinal);
            person.Gender = reader.GetFieldValue<string>(genderOrdinal);

            person.Phone = reader.GetFieldValue<string>(phoneOrdinal);

            return person;
        }
    }
}
