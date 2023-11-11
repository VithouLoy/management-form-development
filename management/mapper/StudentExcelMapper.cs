using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;

namespace management.mapper
{
    internal class StudentExcelMapper :  IEntityMapper<Student>
    {
        public Student map(IDataRecord dataRecord)
        {
            IExcelDataReader reader = (IExcelDataReader)dataRecord;
            Student student = new Student();
            student.Firstname = reader.GetString(0);
            student.Lastname = reader.GetString(1);
            student.Email = reader.GetString(2);
            student.Phone = reader.GetString(7);
            student.PlaceOfBirth = reader.GetString(5);
            student.CurrentPlace = reader.GetString(4);
            student.Position = reader.GetString(8);
            student.Gender = reader.GetString(3);
            DateTime dateTime;
            if (DateTime.TryParseExact(reader.GetString(6), "dd/MM/yyyy", null, DateTimeStyles.None, out dateTime))
            {
                student.DateOfBirth = dateTime;
            }
            return student;
        }
    }
}
