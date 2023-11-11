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
using management.repository;

namespace management
{
    public partial class PopUp : Form
    {
        private Student student = new Student();
        private string type;
        public PopUp()
        {
            InitializeComponent();
        }

        public void initStudent(Student student)
        {
            this.student = student;
            this.message.Text = "លុបទិន្នន័យ ​​​​​​​" + student.Firstname + " " + student.Lastname + "?";
            type = "Deleted";
        }

        public void initLogout()
        {
            this.message.Text = string.Empty;
            type = "Authentication";
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void doDelete(Student student)
        {
            IWriterRepository<Student> studentRepository = new StudentWriterRepository();

            studentRepository.Delete(student);

            MessageBox.Show("ទិន្នន័យត្រូវបានលុប!");

            this.Close();

            Form form = DisplayMe.ActiveForm;

            form.Close();

            DisplayMe displayMe = new DisplayMe();
            displayMe.Show();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (type == "Deleted")
            {
                doDelete(student);
            }

            if (type == "Authentication")
            {
                this.doOnLogout();
            }
        }

        private void doOnLogout()
        {
            this.Close();

            DisplayMe.ActiveForm.Close();


            Authentication auth = new Authentication();
            auth.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
