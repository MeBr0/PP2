using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Args
{
    class Program
    {
        /// <summary>
        /// Function for check whether number prime or not
        /// </summary>
        /// <param name="a">input number</param>
        /// <returns>True if prime, False if not prime</returns>
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
            string a = Console.ReadLine(); //input string
            string[] b = a.Split(' ');     //split primary string into array of strings
            foreach(string x in b)         //go through array b
            {
                if (IsPrime(int.Parse(x))) //if number is prime, then print it
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
