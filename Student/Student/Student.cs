using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        string Name;
        string SName;
        double gpa;

        public Student(string a, string b, double c)
        {
            Name = a;
            SName = b;
            gpa = c;
        }

        public override string ToString()
        {
            return Name + " " + SName + " " + gpa;
        }
    }
}
