using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Circle
    {
        double r;
        double d;
        double Area;
        double Circum;

        public Circle(double r)
        {
            this.r = r;
            findArea();
            findDiam();
            findCricum();
        }

        void findDiam()
        {
            d = 2 * r;
        }

        void findArea()
        {
            Area = Math.PI * r * r;
        }

        void findCricum()
        {
            Circum = 2 * Math.PI * r;
        }

        public override string ToString()
        {
            return "Area : " + Area + "; Circumference : " + Circum;
        }
    }
}
