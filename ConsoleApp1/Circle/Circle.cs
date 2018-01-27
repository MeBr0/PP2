using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        double radius;
        double area;
        double cir;
        public Circle(double a)
        {
            radius = a;
        }
        public void Circum()
        {
            cir = Math.PI * 2 * this.radius;
        }
        public void Area()
        {
            area = Math.PI * this.radius * this.radius;
        }
        public override string ToString()
        {
            return "Area = " + area + "; Circumference = " + cir;
        }
    }
}
