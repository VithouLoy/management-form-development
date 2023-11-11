using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace management.mapper
{
    internal class StudentCsvMapper : ClassMap<Student>
    {
        public StudentCsvMapper() {
            Map(m => m.Firstname).Index(0).Name("firstname");
            Map(m => m.Lastname).Index(1).Name("lastname");
            Map(m => m.Email).Index(2).Name("email");
            Map(m => m.Gender).Index(3).Name("gender");
            Map(m => m.PlaceOfBirth).Index(4).Name("placeOfBirth");
            Map(m => m.CurrentPlace).Index(5).Name("currentPlace");
            Map(m => m.DateOfBirth).Index(6).Name("dateOfBirth");
            Map(m => m.Phone).Index(7).Name("phone");
            Map(m => m.Position).Index(8).Name("position");
        }
    }
}
