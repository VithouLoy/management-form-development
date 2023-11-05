using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace management
{
    public partial class forgot : Form
    {
        public forgot()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isMatchCondition() && this.isUserExist())
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";
                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand(string.Format("UPDATE users SET Username = '{0}', Password = '{2}' WHERE Username = '{0}' AND Password = {1}", username.Text, oldPass.Text, newPass.Text), sqlConnection))
                    { 
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password successfully modified!");
                        this.Close();
                        Authentication authentication = new Authentication();
                        authentication.ShowDialog();
                    }
                }
            }
        }

        private bool isMatchCondition()
        {
            bool isNoneEmpty = !string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(oldPass.Text) && !string.IsNullOrEmpty(newPass.Text) && !string.IsNullOrEmpty(confirmPass.Text);
            bool isPasswordMatch = newPass.Text == confirmPass.Text;
            if(isNoneEmpty && isPasswordMatch)
            {
                return true;
            }

            MessageBox.Show("Password and confirm password not matches");
            return false;
        }

        private bool isUserExist()
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand(string.Format("SELECT Username, Password FROM users WHERE Username = '{0}' AND Password = '{1}'", username.Text, oldPass.Text), sqlConnection))
                {
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("This user is not exists");
                            return false;
                        }
                        return true;
                    };
                }
            }
        }

      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
