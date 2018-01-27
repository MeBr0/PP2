using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Complex a = new Complex(1, 4);
            Complex b = new Complex(1, 2);
            Complex c = a - b;
            Console.WriteLine(c);
        }
    }
}
