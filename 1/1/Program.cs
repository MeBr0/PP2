using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace args
{
    class Program
    {
        static bool IsPrime(string x)
        {
            int a = int.Parse(x);
            for (int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            foreach (string i in args)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
