using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            foreach(string i in b)
            {
                if (IsPrime(i))
                {
                    Console.Write(i+" ");                    
                }
            }
        }
        static bool IsPrime(string x)
        {
            int a = int.Parse(x);
            for(int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
