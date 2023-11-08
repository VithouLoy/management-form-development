using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class DeleteStudent : Form
    {
        private Student student = new Student();
        public DeleteStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
            this.message.Text = "លុបទិន្នន័យ ​​​​​​​" + student.Firstname + " " + student.Lastname + "?";

        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void doDelete(Student student)
        {
            string query = "UPDATE students SET Deleted = 1 WHERE id = " + student.Id;
            using (SqlConnection sqlConnection = new SqlConnection(DataSource.CONNECTION_STRING))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ទិន្នន័យត្រូវបានលុប!");
                }
            }

            this.Close();

            Form form = DisplayMe.ActiveForm;

            form.Close();

            DisplayMe displayMe = new DisplayMe();
            displayMe.Show();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            doDelete(student);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
