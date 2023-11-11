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
    public partial class StudentAchive : Form
    {
        private List<Student> students = new List<Student>();
        private readonly string msg = "ដំណើរការទទួលបានជោគជ័យ";
        public StudentAchive(List<Person> students)
        {
            InitializeComponent();
            dataGridView1.DataSource = students;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void redo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                string query = "UPDATE students SET Deleted = 0 WHERE Id = " + id;
                using (SqlConnection sqlConnection = new SqlConnection(DataSource.CONNECTION_STRING))
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show(msg);


            this.dataGridView1.DataSource = null;
        }

        private void StudentAchive_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void StudentAchive_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplayMe display = new DisplayMe();
            display.Show();

        }

        private void StudentAchive_Load(object sender, EventArgs e)
        {
            DisplayMe dm = new DisplayMe();
        }
    }
}
