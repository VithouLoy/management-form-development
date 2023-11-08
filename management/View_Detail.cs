using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using management.constant;

namespace management
{
    public partial class View_Detail : Form
    {
        public View_Detail(Student student, String type)
        {
            InitializeComponent();
            this.displayStudent(student);
            this.disableElement(student, type);

        }


        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        public void displayStudent(Student student)
        {
            firstname.Text = student.Firstname;
            lastname.Text = student.Lastname;
            email.Text = student.Email;
            phone.Text = student.Phone;
            currentPlace.Text = student.CurrentPlace;
            placeOfBirth.Text = student.PlaceOfBirth;
            position.Text = student.Position;
            male.Checked = student.Gender == "Male";
            female.Checked = student.Gender == "Female";
            profile.Image = Image.FromFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Images", student.Profile));
            profile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void disableElement(Student student, string type)
        {
            if (type == Student_Constants.VIEW_DETAIL)
            {
                firstname.Enabled = placeOfBirth.Enabled =  lastname.Enabled = email.Enabled = male.Enabled = female.Enabled = profile.Enabled = dateOfBirth.Enabled = currentPlace.Enabled = phone.Enabled = position.Enabled = submit.Enabled = choose.Enabled =  false;
                choose.Hide();
                submit.Hide();
            }

            if (type == Student_Constants.MODIFY_DETAIL)
            {

            }
        }

        

        private void View_Detail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void currentPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

        }
    }
}
