using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Rectangle
    {
        double a;
        double b;
        double Area;
        double Per;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
            findArea();
            findPer();
        }

        void findArea()
        {
            Area = a * b;
        }

        void findPer()
        {
            Per = 2 * (a + b);
        }

        public override string ToString()
        {
            return "Area : " + Area + "; Perimeter : " + Per; 
        }
    }
}
