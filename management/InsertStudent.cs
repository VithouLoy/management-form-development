using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
using management.repository;
using management.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace management
{
    public partial class InsertStudent : Form
    {
        private string type = "NONE";
        private string extension = ".png";
        private Student student = new Student();
        public InsertStudent(Student student, String type)
        {
            InitializeComponent();
            position.SelectedIndex = 0;
            this.disableElement(student, type);
            this.student = student;
            this.type = type;
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
            dateOfBirth.Value = student.DateOfBirth;
            placeOfBirth.Text = student.PlaceOfBirth;
            position.Text = student.Position;
            male.Checked = student.Gender == "Male";
            female.Checked = student.Gender == "Female";
            profile.Image = ImageIOUtils.getImage(student.Profile);
            profile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void chooseImage_Click(object sender, EventArgs e)
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

        private void submit_Click(object sender, EventArgs e)
        {
                this.write(type);

        }

        private void write(string type)
        {
            if (this.isMatchCondition())
            {
                IWriterRepository<Student> studentRepository = new StudentWriterRepository();
                
                Student student = getStudent();



                if (type == Student_Constants.MODIFY_DETAIL)
                {
                    student.Id = this.student.Id;
                    studentRepository.Update(student);
                } else
                {
                    studentRepository.Add(student);
                }

                this.saveImage(student.Profile);

                MessageBox.Show("ដំណើរការទទួលបានជោគជ៍យ");

                this.refreshAndDisplay();
            }
        }

        private void refreshAndDisplay()
        {
            this.Close();

            Form form = DisplayMe.ActiveForm;

            form.Close();

            DisplayMe displayMe = new DisplayMe();
            displayMe.Show();
        }
        

        private void saveImage(string path)
        {
            string pathToStore = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Images", path);

            profile.Image.Save(pathToStore);
        }


        private Student getStudent()
        {
            Student student = new Student();

            string profileUUID = Guid.NewGuid().ToString() + extension;

            student.Firstname = firstname.Text;
            student.Lastname = lastname.Text;
            student.Email = email.Text;
            student.Phone = phone.Text;
            student.DateOfBirth = dateOfBirth.Value.Date;
            student.CurrentPlace = currentPlace.Text;
            student.PlaceOfBirth = placeOfBirth.Text;
            student.Gender = female.Checked ? "Female" : "Male";
            student.Position = position.Text;
            student.Profile = profileUUID;

            return student;
        }

        private bool isMatchCondition()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrEmpty(firstname.Text))
                stringBuilder.Append("First name required!\n");

            if (string.IsNullOrEmpty(lastname.Text)) stringBuilder.Append("last name required!\n");

            if (string.IsNullOrEmpty(male.Text) || string.IsNullOrEmpty(female.Text)) stringBuilder.Append("Marial status required!\n");

            if (string.IsNullOrEmpty(phone.Text) || !(phone.Text.Length >= 6)) stringBuilder.Append("Phone number invalid!\n");

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

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            female.Checked = !male.Checked;
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            male.Checked = !female.Checked;
        }

        private void InsertStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
