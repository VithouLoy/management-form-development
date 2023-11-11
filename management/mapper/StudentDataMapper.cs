using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.mapper
{
    internal class StudentDataMapper : IEntityMapper<Student>
    {
        public Student map(IDataRecord dataRecord)
        {
            DbDataReader reader = (DbDataReader)dataRecord;

            int firstNameOrdinal = reader.GetOrdinal("Firstname");
            int lastNameOrdinal = reader.GetOrdinal("Lastname");
            int positionOrdinal = reader.GetOrdinal("Position");
            int phoneOrdinal = reader.GetOrdinal("Phone");
            int emailOrdinal = reader.GetOrdinal("Email");
            int genderOrdinal = reader.GetOrdinal("Gender");
            int idOrdinal = reader.GetOrdinal("ID");
            int currentPlace = reader.GetOrdinal("Current_Place");
            int dobOrdinal = reader.GetOrdinal("DOB");
            int placeOfBirth = reader.GetOrdinal("Place_Of_Birth");
            int profileOrdinal = reader.GetOrdinal("Profile");

            Student student = new Student();
            student.Id = reader.GetFieldValue<int>(idOrdinal);
            student.Firstname = reader.GetFieldValue<string>(firstNameOrdinal);
            student.Lastname = reader.GetFieldValue<string>(lastNameOrdinal);
            student.Email = reader.GetFieldValue<string>(emailOrdinal);
            student.Gender = reader.GetFieldValue<string>(genderOrdinal);
            student.Position = reader.GetFieldValue<string>(positionOrdinal);
            student.CurrentPlace = reader.GetFieldValue<string>(currentPlace);
            student.Phone = reader.GetFieldValue<string>(phoneOrdinal);
            student.DateOfBirth = reader.GetFieldValue<DateTime>(dobOrdinal);
            student.PlaceOfBirth = reader.GetFieldValue<string>(placeOfBirth);
            student.Profile = reader.GetFieldValue<string>(profileOrdinal);

            return student;
        }
    }
}
