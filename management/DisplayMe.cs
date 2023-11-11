using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using ExcelDataReader;
using GemBox.Spreadsheet;
using management.constant;
using management.document;
using management.factory;
using management.mapper;
using management.repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace management
{
    public partial class DisplayMe : Form
    {

        public DisplayMe()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void initPerson(List<Student> people)
        {
            this.dataGridView1.DataSource =  people;
        }

        public void initUser(User user)
        {
        }

        private void insert_Click(object sender, EventArgs e)
        {

            this.displayInsertDetail(new Student(), "NONE");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.doRefresh();
        }

        private void doRefresh()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Update();
            this.dataGridView1.Refresh();
            this.displayAll();
        }


        private void view_detail_Click(object sender, EventArgs e)
        {
            Student student = this.getStudent();
            this.displayInsertDetail(student, Student_Constants.VIEW_DETAIL);
        }

        private void On_Cell_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modify_Click(object sender, EventArgs e)
        {
            Student student = this.getStudent();
            this.displayInsertDetail(student, Student_Constants.MODIFY_DETAIL);
        }


        private Student getStudent()
        {
            IReaderListRepository<Student> studentRepository = new StudentReaderRepository();

            Student student = studentRepository.ReadBy(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());

            return student;
        }

        private void displayInsertDetail(Student student, String type)
        {
            InsertStudent insertStudent = new InsertStudent(student, type);
            insertStudent.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Student student = this.getStudent();

            PopUp deleteStudent = new PopUp();
            deleteStudent.initStudent(student);

            deleteStudent.Show();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(find.Text))
            {
                IReaderListRepository<Person> personReaderRepository = new PersonReaderRepository();
                dataGridView1.DataSource =  personReaderRepository.ReadAllBy(find.Text);
            } else
            {
                this.displayAll();
            }
        }

        private void DisplayMe_Load(object sender, EventArgs e)
        {
            this.displayAll();   
        }

        private void displayAll()
        {
            IReaderListRepository<Person> personReader = new PersonReaderRepository();

            dataGridView1.DataSource = personReader.ReadAll();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            InsertStudent insertStudent = new InsertStudent(new Student(), Student_Constants.STUDENT_FILTERING);
            insertStudent.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            PopUp logout = new PopUp();
            logout.initLogout();
            logout.Show();
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportData exportData = new ExportData();
            exportData.Show();
        }

        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Document Files (*.xlsx;*.csv;.*.txt;*.json;)|*.xlsx;*.csv;.*.txt;*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IWriterRepository<Student> student = new StudentWriterRepository();

                IDataImporter<Student> dataImporter = StudentImporterFactory.create(Path.GetExtension(openFileDialog.FileName));
                
                student.AddAll(dataImporter.import(openFileDialog.FileName));

                MessageBox.Show("ដំណើរការជោគជ័យ");

                this.displayAll();
            }
        }
    }
}
