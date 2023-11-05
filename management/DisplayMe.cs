using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using management.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace management
{
    public partial class DisplayMe : Form
    {
        public DisplayMe()
        {

            InitializeComponent();
            this.displayList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void displayList()
        {
            List<Student> students = new List<Student>();
            string query = "SELECT * FROM students";

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


                                Student student = new Student();
                                student.Firstname = reader.GetFieldValue<string>(firstNameOrdinal);
                                student.Lastname = reader.GetFieldValue<string>(lastNameOrdinal);
                                student.Email = reader.GetFieldValue<string>(emailOrdinal);
                                student.Position = reader.GetFieldValue<string>(positionOrdinal);
                                student.Gender = reader.GetFieldValue<string>(genderOrdinal);
                                
                                //student.Position = reader.GetFieldValue<string>(positionOrdinal);
                                student.Phone = reader.GetFieldValue<string>(phoneOrdinal);

                                students.Add(student);
                            }
                        }
                    }
                }
            }



            dataGridView1.DataSource = students;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CurrentPlace"].Visible = false;
            dataGridView1.Columns["PlaceOfBirth"].Visible = false;
            dataGridView1.Columns["Dob"].Visible = false;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Student insert_Student = new Insert_Student();
            insert_Student.ShowDialog();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Update();
            this.dataGridView1.Refresh();
            this.displayList();
        }
    }
}
