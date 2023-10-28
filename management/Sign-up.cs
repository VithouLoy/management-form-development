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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validator.isValueProvidedNotEmpty(username.Text) && Validator.isValueProvidedNotEmpty(password.Text) && Validator.isValueProvidedNotEmpty(confirmPass.Text))
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";
                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO users (Username, Password) VALUES ('{0}', '{1}')", username.Text, password.Text), sqlConnection))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Created successfully!");
                        this.Close();
                        Authentication authentication = new Authentication();
                        authentication.ShowDialog();
                    }
                }
            }
        }
    }
}
