using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomm
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b = a.Split();
            int x = int.Parse(b[0]);
            int y = int.Parse(b[1]);

            Random r = new Random();
            Random w = new Random();
            int z = r.Next(x, y);
            int e = w.Next(1, 2);
            Console.WriteLine(z);
            Console.WriteLine(e);
            Console.WriteLine(e + z);
            Console.WriteLine(e + z);
            Console.WriteLine(e + z);
            Console.WriteLine(e + z);

        }
    }
}
