using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Rectangle
    {
        double height;
        double width;
        double perimeter;
        double area;
        public Rectangle(double a, double b)
        {
            height = a;
            width = b;
        }
        public void Per()
        {   
            perimeter =  2 * (height + width);
        }
        public void Area()
        {
            area = height * width;
        }
        public override string ToString()
        {
            return "Area = " + area + "; Perimeter = " + perimeter;
        }
    }
}
