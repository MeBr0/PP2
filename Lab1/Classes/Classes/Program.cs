using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            double q = double.Parse(Console.ReadLine());
            Circle c = new Circle(q);
            Console.WriteLine(c);

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Rectangle d = new Rectangle(a, b);
            Console.WriteLine(d);
        }
    }
}
