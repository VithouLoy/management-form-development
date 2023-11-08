using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using management.constant;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace management
{
    public partial class DisplayMe : Form
    {

        public DisplayMe()
        {

            InitializeComponent();
            this.displayList("SELECT * FROM students WHERE Deleted = 0", true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private List<Person> displayList(string query, bool isDisplay)
        {
            List<Person> students = new List<Person>();

            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand(string.Format(query), sqlConnection))
                {
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int firstNameOrdinal = reader.GetOrdinal("Firstname");
                                int lastNameOrdinal = reader.GetOrdinal("Lastname");
                                int positionOrdinal = reader.GetOrdinal("Position");
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

                                //person.Position = reader.GetFieldValue<string>(positionOrdinal);
                                person.Phone = reader.GetFieldValue<string>(phoneOrdinal);

                                students.Add(person);
                            }
                        }
                    }
                }
            }


            if (isDisplay)
            {
                dataGridView1.DataSource = students;

                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.ReadOnly = true;
            }

            return students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Student insert_Student = new Insert_Student(new Student(), "NONE");
            insert_Student.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.doRefresh();
        }

        private void doRefresh()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Update();
            this.dataGridView1.Refresh();
            this.displayList("SELECT * FROM students", true);
        }


        private void view_detail_Click(object sender, EventArgs e)
        {
            this.view(Student_Constants.VIEW_DETAIL);
        }

        private void view(String type)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";
                string query = "SELECT * FROM students WHERE Id = " + id;

                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            Student student = this.setStudent(reader);
                            if (type == Student_Constants.VIEW_DETAIL)
                            {
                                this.view(student, Student_Constants.VIEW_DETAIL);
                            }
                            else if (type == Student_Constants.MODIFY_DETAIL)
                            {
                                this.view(student, Student_Constants.MODIFY_DETAIL);
                            } else if (type == Student_Constants.STUDENT_REMOVAL)
                            {
                                DeleteStudent deleteStudent = new DeleteStudent(student);
                                deleteStudent.Show();
                            } 
                        }
                    }
                }
            }
        }

        private void view(Student student, String type)
        {
            Insert_Student view_Detail = new Insert_Student(student, type);
            view_Detail.Show();
        }

        private void On_Cell_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Student setStudent(SqlDataReader reader)
        {
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
            student.Dob = reader.GetFieldValue<DateTime>(dobOrdinal);
            student.PlaceOfBirth = reader.GetFieldValue<string>(placeOfBirth);
            student.Profile = reader.GetFieldValue<string>(profileOrdinal);

            return student;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.view(Student_Constants.MODIFY_DETAIL);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.view(Student_Constants.STUDENT_REMOVAL);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(find.Text))
            {
                string query = string.Format("SELECT * FROM students WHERE (Firstname LIKE '%{0}%' OR Lastname LIKE '%{0}%' OR Email LIKE '%{0}%' OR Phone LIKE '%{0}%' OR Gender = '{0}') AND Deleted = 0", find.Text);
                this.displayList(query, true);
            } else
            {
                this.displayList("SELECT * FROM students WHERE Deleted = 0", true);
            }
        }

        private void achive_Click(object sender, EventArgs e)
        {
            List<Person> students = this.displayList("SELECT * FROM students WHERE Deleted = 1", false);

            if (students != null)
            {
                StudentAchive studentAchive = new StudentAchive(students);
                studentAchive.Show();
            }
        }
    }
}
