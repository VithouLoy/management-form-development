using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using management.constant;
using management.mapper;

namespace management.repository
{
    internal class StudentReaderRepository : AbstractSqlListReader<Student>
    {
        public StudentReaderRepository() : base(new StudentDataMapper())
        {
        }

        protected override string getConnectionString()
        {
            return DataSource.CONNECTION_STRING;
        }

        protected override string getReadByQuery<D>(params D[] data)
        {
            base.addParameter("@Id", data[0]);
            return "SELECT * FROM students WHERE Id = @Id";
        }

        protected override string getReadAllByQuery<D>(params D[] data)
        {
            Student student = (Student) (object) data[0];
            base.addParameter("@Firstname", student.Firstname);
            base.addParameter("@Lastname", student.Lastname);
            base.addParameter("@Email", student.Email);
            base.addParameter("@Phone", student.Phone);
            base.addParameter("@Position", student.Position);
            base.addParameter("@DOB", student.DateOfBirth);
            base.addParameter("@Current_Place", student.CurrentPlace);
            base.addParameter("@Place_Of_Birth", student.PlaceOfBirth);
            base.addParameter("@Gender", student.Gender);

            string query = "SELECT * FROM students WHERE " +
                Query.buildLikeQuery("@Firstname") + " AND " + Query.buildLikeQuery("@Lastname") + " AND " + Query.buildLikeQuery("@Email") +
                " AND " + Query.buildLikeQuery("@Phone") + " AND " + Query.buildLikeQuery("@Position") + " AND " +
                Query.buildLikeQuery("@DOB") + " AND " + Query.buildLikeQuery("@Current_Place") + " AND " + Query.buildLikeQuery("@Place_Of_Birth") +
                " AND " + Query.buildLikeQuery("@GENDER");


            return query;
        }
    }
}
