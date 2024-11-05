using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Project
{
    internal class FileHandler
    {
        private int StudentAge;
        private string StudentName;
        private string StudentSurname;
        private string StudentCourse;
        private string Filepath = @"students.txt";

        public int StudentAge1 { get => StudentAge; set => StudentAge = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public string StudentSurname1 { get => StudentSurname; set => StudentSurname = value; }
        public string StudentCourse1 { get => StudentCourse; set => StudentCourse = value; }

        public FileHandler()
        {

        }

        public FileHandler(int studentAge, string studentName, string studentSurname, string studentCourse)
        {
            StudentAge = studentAge;
            StudentName = studentName;
            StudentSurname = studentSurname;
            StudentCourse = studentCourse;
        }


        //Methods
        List<string> students = new List<string>();

        public void FileExists() // checks if file exists. if not creates it
        {
            if (File.Exists(Filepath))
            {
                // exists already can do stuff if needed  
            }
            else
            {
                MessageBox.Show("The file does not exist, It will automatically be created", "file does not exist");  // prompt to make file because it doenst exist 

                FileStream streamcreate = new FileStream(Filepath, FileMode.Create);
                streamcreate.Close();

                MessageBox.Show("File Created", "File Created");
            }
        }

        public List<Student> PopulateList(List<Student> studentlist)
        {
            FileStream fileStream = new FileStream(Filepath, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(fileStream);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] splitarray = line.Split(':');

                Student student = new Student(int.Parse(splitarray[0]), splitarray[1], splitarray[2], int.Parse(splitarray[3]), splitarray[4]);
                studentlist.Add(student);
            }
            reader.Close();
            return studentlist;
        }



    }
}
