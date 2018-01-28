using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Args
{
    class Program
    {
        static bool IsPrime(int a)
        {
            for(int i=2; i<=Math.Sqrt(a); ++i)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            foreach(string x in b) 
            {
                if (IsPrime(int.Parse(x)))
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
