using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmStudentRecords : Form
    {
        BindingSource bindingSource = new BindingSource();
        DataHandler dataHandler = new DataHandler();
        FileHandler fileHandler = new FileHandler();
        static List<Student> studentlist = new List<Student>();
        static int IDholder = 1;

        public frmStudentRecords()
        {
            InitializeComponent();
        }

        private void frmStudentRecords_Load(object sender, EventArgs e)//Executes right after the form has been loaded
        {
            //Here we will read the data in the tf using the FileHandler, and add it to our list
            studentlist = fileHandler.PopulateList(studentlist);
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            updateStudentCounter();
            findAverageAge();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //To add a student, we supply an ID, to ensure there are no duplicate ID's. To do this, we found the ID that was last assigned, and +1
            int id = 0;
            foreach (var student in studentlist)
            {
                id = student.StudentID;//Thus, we will loop through the entire list, and assign the value of the ID of the last student in the list
            }

            studentlist = dataHandler.AddStudent(studentlist, (id + 1), txtName.Text, "PlaceHolderText", int.Parse(txtAge.Text), txtCourse.Text);
            MessageBox.Show("The student has been successfully added!", "Student Captured");
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            updateStudentCounter();
            findAverageAge();
        }

        private void btnPrevRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
            IDholder--;
        }

        private void btnNextRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
            IDholder++;
        }

        private void btnFirstRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
            IDholder = 1;
        }

        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
            IDholder = studentlist.Count;
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            updateStudentCounter();
            findAverageAge();
        }

        private void btnUpdateSInfo_Click(object sender, EventArgs e)
        {
            this.dgvStudents.CurrentCell = this.dgvStudents[0, dgvStudents.CurrentCell.RowIndex];
            string test = $"{dgvStudents.CurrentCell.Value}";
            IDholder = int.Parse(test);

            dataHandler.EditStudent(studentlist, IDholder, IDholder, txtName.Text, int.Parse(txtAge.Text), txtCourse.Text);
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            this.dgvStudents.CurrentCell = this.dgvStudents[0, dgvStudents.CurrentCell.RowIndex];
            string test = $"{dgvStudents.CurrentCell.Value}";
            IDholder = int.Parse(test);

            studentlist = dataHandler.DeleteStudent(studentlist, IDholder);
            bindingSource.DataSource = "";
            bindingSource.DataSource = studentlist;
            dgvStudents.DataSource = bindingSource;
            IDholder = 1;
            updateStudentCounter();
            findAverageAge();
        }






        //////////////////////////Tracking functions
        private void updateStudentCounter()
        {
            lblOutStudents.Text = studentlist.Count.ToString();
        }

        private void findAverageAge()
        {
            float total = 0;
            foreach (Student student in studentlist)
            {
                total += student.Age;
            }
            float avarage = (total / studentlist.Count);
            lblOutAAge.Text = String.Format("{0}",avarage);
        }

        private void btnUpdateDGV_Click(object sender, EventArgs e)
        {
            //Update met wat u mean, refresh??
            dgvStudents.Refresh();
            dgvStudents.Update();
            MessageBox.Show("Data is sucessfully updated!");
        }
    }
}