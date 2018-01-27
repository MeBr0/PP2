using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] y = x.Split();
            double x1 = double.Parse(y[0]);
            double x2 = double.Parse(y[1]);
            Rectangle a = new Rectangle(x1, x2);
            a.Area();
            a.Per();
            Console.WriteLine(a);
        }
    }
}
