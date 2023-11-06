using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class Insert_Student : Form
    {
        private string extension = ".png";
        public Insert_Student()
        {
            InitializeComponent();
            position.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profile.Image = Image.FromFile(openFileDialog.FileName);
                extension = Path.GetExtension(openFileDialog.FileName);
                profile.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            profile.Show();


            SqlConnection conn = new SqlConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";

            try
            {
                if (isMatchCondition())
                {
                    string profileUUID = Guid.NewGuid().ToString() + extension;
                    string query = string.Format("INSERT INTO students (Firstname, Lastname, Email, Phone, DOB, Current_Place, Place_Of_Birth, Gender, Position, Profile) VALUES (@Firstname, @Lastname, @Email, @Phone, @DOB, @Current_Place, @Place_Of_Birth, @Gender, @Position, @Profile)");
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                            cmd.Parameters.AddWithValue("@Lastname", lastname.Text);
                            cmd.Parameters.AddWithValue("@Email", email.Text);
                            cmd.Parameters.AddWithValue("@Phone", phone.Text);
                            cmd.Parameters.AddWithValue("@DOB", SqlDbType.Date).Value = dateOfBirth.Value.Date;
                            cmd.Parameters.AddWithValue("@Current_Place", currentPlace.Text);
                            cmd.Parameters.AddWithValue("@Place_Of_Birth", placeOfBirth.Text);
                            cmd.Parameters.AddWithValue("@Gender", female.Enabled ? female.Text : male.Text);
                            cmd.Parameters.AddWithValue("@Position", position.Text);
                            cmd.Parameters.AddWithValue("@Profile", profileUUID);
                            sqlConnection.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Students sucessfully inserted!");
                        }
                    }

                    string pathToStore = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Images", profileUUID);

                    profile.Image.Save(pathToStore);


                    this.Close();
                }



            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private bool isMatchCondition()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrEmpty(firstname.Text))
                stringBuilder.Append("First name required!\n");

            if (string.IsNullOrEmpty(lastname.Text)) stringBuilder.Append("last name required!\n");

            if (string.IsNullOrEmpty(male.Text) || string.IsNullOrEmpty(female.Text)) stringBuilder.Append("Marial status required!\n");

            if (string.IsNullOrEmpty(phone.Text) || !int.TryParse(phone.Text, out _) || !(phone.Text.Length >= 8)) stringBuilder.Append("Phone number invalid!\n");

            if (string.IsNullOrEmpty(email.Text)) stringBuilder.Append("Email required!\n");

            if (string.IsNullOrEmpty(dateOfBirth.Text)) stringBuilder.Append("Date of birth required!\n");

            if (string.IsNullOrEmpty(placeOfBirth.Text)) stringBuilder.Append("Place of birth required!\n");

            if (string.IsNullOrEmpty(currentPlace.Text)) stringBuilder.Append("Current place required!\n");

            if (string.IsNullOrEmpty(position.Text)) stringBuilder.Append("Position required!\n");

            if (profile == null) stringBuilder.Append("Profile required!\n");

            if (string.IsNullOrEmpty(stringBuilder.ToString()))
            {
                return true;
            }

            MessageBox.Show(stringBuilder.ToString());

            return false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            female.Enabled = !male.Checked;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            male.Enabled = !female.Checked;
        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Student_Load(object sender, EventArgs e)
        {

        }
    }
}
