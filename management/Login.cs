using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace management
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txt_username(object sender, EventArgs e)
        {
        }

        private void txt_password(object sender, EventArgs e)
        {
        }

        private void txt_login(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_btn(object sender, EventArgs e)
        {


            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand(string.Format("SELECT Username, Password FROM users WHERE Username = '{0}' AND Password = '{1}'", username.Text, password.Text), sqlConnection))
                {
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User userLogin = new User();

                            userLogin.Username = username.Text;
                            userLogin.Password = password.Text;
                            DisplayMe displayMe = new DisplayMe();
                            displayMe.initUser(userLogin);

                            this.Hide();
                            displayMe.Show();
                        }
                        else
                        {
                            MessageBox.Show("username and password provided is incorrect");
                        }
                    };
                }
            }

            username.Clear();
            password.Clear();
            //DisplayMe displayMe = new DisplayMe();
            //displayMe.ShowDialog();
        }

        private void signup_btn(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void forgotpassword_link(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot form3 = new forgot();
            form3.ShowDialog();
        }
    }
}
