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
            for(int i=0; i<=Math.Sqrt(a); ++i)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            foreach(string x in args)
            {
                if (IsPrime(int.Parse(x)))
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
