using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Student
    {
        //Fields
        private int studentID;
        private string name;
        private string surname;
        private int age;
        private string course;

        //Properties
        public int StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
        

        //Paramaterless constructor
        public Student(){}

        //Paramatarized constructor
        public Student(int studentID, string name,string surname, int age, string course)
        {
            this.studentID = studentID;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.course = course;
        }

        public override string ToString()
        {
            return String.Format("StudentID: {0} | Name: {1} | Surname: {2} Age: {3} | Course: {4}",StudentID,Name,Surname,Age,Course);
        }
    }
}
