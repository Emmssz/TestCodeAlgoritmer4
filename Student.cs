using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestCodeAlgoritmer4
{
    internal class Student
    {
        public string Name { get; set; }
        public string StudentID { get; set; }
        public string Age { get; set; }

        // Constructor
        public Student(string name, string age, string studentID)
        {
            Name = name;
            Age = age;
            StudentID = studentID;
        }

        
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Student ID: {StudentID}";
        }
    }
}

