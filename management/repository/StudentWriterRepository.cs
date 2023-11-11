using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace management.repository
{
    internal class StudentWriterRepository : AbstractSqlWriter<Student>
    {
        protected void write(Student data)
        {
            base.add("@Firstname", data.Firstname);
            base.add("@Lastname", data.Lastname);
            base.add("@Email", data.Email);
            base.add("@Phone", data.Phone);
            base.add("@DOB", data.DateOfBirth);
            base.add("@Current_Place", data.CurrentPlace);
            base.add("@Place_Of_Birth", data.PlaceOfBirth);
            base.add("@Gender", data.Gender);
            base.add("@Position", data.Position);
            base.add("@Profile", data.Profile ?? "default-profile.png");
            base.add("@Id", data.Id);
        }

        public override string getConnectionString()
        {
            return DataSource.CONNECTION_STRING;
        }

        protected override string getUpdateQuery(Student data)
        {
            this.write(data);
            return "UPDATE students SET Firstname = @Firstname, Lastname = @Lastname, Email = @Email, DOB = @DOB, Place_Of_Birth = @Place_Of_Birth, Current_Place = @Current_Place, Phone = @Phone, Position = @Position, Profile = @Profile, Gender = @Gender WHERE Id = @Id";
        }

        protected override string getWriteQuery(Student data)
        {
            this.write(data);
            return "INSERT INTO students(Firstname, Lastname, Email, Phone, DOB, Current_Place, Place_Of_Birth, Gender, Position, Profile) VALUES(@Firstname, @Lastname, @Email, @Phone, @DOB, @Current_Place, @Place_Of_Birth, @Gender, @Position, @Profile)";
        }

        protected override string getDeleteQuery(Student data)
        {
            base.add("Id", data.Id);
            return "DELETE FROM students WHERE ID = @Id";
        }
    }
}
