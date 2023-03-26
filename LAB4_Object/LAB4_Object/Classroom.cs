using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_Object
{
    public class Classroom
    {
        private string name;
        private List<Student> students = new List<Student>();
        private List<double> GPAs = new List<double>();
        private List<string> names = new List<string>();

        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPersonToClass(Student student)
        {
            this.students.Add(student);
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (var student in this.students)
            {
                result += student.name + "\t" + student.gpa + "\r\n" ;
            }
            return result;
        }
        public void addGPAToClass()
        {
            foreach (var student in students)
            {
                GPAs.Add(student.gpa);
                names.Add(student.name);
            }
        }
        public int showTotalAgeinClass()
        {
            int Result = 0;
            foreach (var student in this.students)
            {
                Result = student.birthYear;
            }
            return Result;
        }

        public double showGPXMax()
        {
            double max = GPAs.Max();
            return max;
        }

        public double showGPXMin()
        {
            double min = GPAs.Min();
            return min;
        }

        public double showGPXAvg()
        {
            double avg = GPAs.Average();
            return avg;
        }

        public string showNameMax()
        {
            return names[GPAs.IndexOf(GPAs.Max())];
        }

        public string showNameMin()
        {
            return names[GPAs.IndexOf(GPAs.Min())];
        }
    }
}
