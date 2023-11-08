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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using management.constant;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace management
{
    public partial class Insert_Student : Form
    {
        private string type = "NONE";
        private string extension = ".png";
        private Student student = new Student();
        public Insert_Student(Student student, String type)
        {
            InitializeComponent();
            position.SelectedIndex = 0;
            this.disableElement(student, type);
            this.student = student;
            this.type = type;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void disableElement(Student student, string type)
        {
            if (type == Student_Constants.VIEW_DETAIL)
            {
                firstname.Enabled = placeOfBirth.Enabled = lastname.Enabled = email.Enabled = male.Enabled = female.Enabled = profile.Enabled = dateOfBirth.Enabled = currentPlace.Enabled = phone.Enabled = position.Enabled = submit.Enabled = submit.Enabled = false;
                choose.Hide();
                submit.Hide();
                displayStudent(student);
            }

            if (type == Student_Constants.MODIFY_DETAIL)
            {
                displayStudent(student);
            }
        }

        public void displayStudent(Student student)
        {
            firstname.Text = student.Firstname;
            lastname.Text = student.Lastname;
            email.Text = student.Email;
            phone.Text = student.Phone;
            currentPlace.Text = student.CurrentPlace;
            dateOfBirth.Value = student.Dob;
            placeOfBirth.Text = student.PlaceOfBirth;
            position.Text = student.Position;
            male.Checked = student.Gender == "Male";
            female.Checked = student.Gender == "Female";
            profile.Image = Image.FromFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Images", student.Profile));
            profile.SizeMode = PictureBoxSizeMode.StretchImage;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isMatchCondition())
            {
                StringBuilder sb = new StringBuilder();
                if (type == "NONE")
                {
                    sb.Append("INSERT INTO students(Firstname, Lastname, Email, Phone, DOB, Current_Place, Place_Of_Birth, Gender, Position, Profile) VALUES(@Firstname, @Lastname, @Email, @Phone, @DOB, @Current_Place, @Place_Of_Birth, @Gender, @Position, @Profile)");
                }
                else if (type == Student_Constants.MODIFY_DETAIL)
                {
                    sb.Append("UPDATE students SET Firstname = @Firstname, Lastname = @Lastname, Email = @Email, DOB = @DOB, Place_Of_Birth = @Place_Of_Birth, Current_Place = @Current_Place, Phone = @Phone, Position = @Position, Profile = @Profile, Gender = @Gender WHERE Id = " + student.Id);
                }
                this.execute(sb.ToString());
            }
        }

        private void execute(string query)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=student;Integrated Security=True;";

            try
            {

                    string profileUUID = Guid.NewGuid().ToString() + extension;
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                            cmd.Parameters.AddWithValue("@Lastname", lastname.Text);
                            cmd.Parameters.AddWithValue("@Email", email.Text);
                            cmd.Parameters.AddWithValue("@Phone", phone.Text);
                            cmd.Parameters.AddWithValue("@DOB", dateOfBirth.Value.Date);
                            cmd.Parameters.AddWithValue("@Current_Place", currentPlace.Text);
                            cmd.Parameters.AddWithValue("@Place_Of_Birth", placeOfBirth.Text);
                            cmd.Parameters.AddWithValue("@Gender", female.Enabled ? "Female" : "Male");
                            cmd.Parameters.AddWithValue("@Position", position.Text);
                            cmd.Parameters.AddWithValue("@Profile", profileUUID);
                            sqlConnection.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("ដំណើរការទទួលបានជោគជ៍យ");
                        }
                    }

                        string pathToStore = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Images", profileUUID);

                     profile.Image.Save(pathToStore);

                     this.Close();

                     Form form = DisplayMe.ActiveForm;
                     form.Close();

                     DisplayMe displayMe = new DisplayMe();
                     displayMe.Show();

            }
            catch (Exception ex)
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
            female.Checked = !male.Checked;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            male.Checked = !female.Checked;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
