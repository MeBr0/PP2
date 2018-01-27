using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Circle a = new Circle(x);
            a.Area();
            a.Circum();
            Console.WriteLine(a);
        }
    }
}
