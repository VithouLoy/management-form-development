using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class View_Detail : Form
    {
        public View_Detail(Student student)
        {
            InitializeComponent();
            this.displayStudent(student);
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayStudent(Student student)
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
    }
}
