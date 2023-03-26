using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_Object
{
    public class Student
    {
        public string name { get; set; }
        public double gpa { get; set; }
        public int birthYear { get; set; }

        public Student(string name, int bYear, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
            this.birthYear = 2566 - bYear;
        }
    }
}
