using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s5 = Console.ReadLine();
            string s2 = Console.ReadLine();

            string[] s3 = s1.Split('/');
            string[] s4 = s2.Split('/');

            Complex q = new Complex(int.Parse(s3[0]), int.Parse(s3[1]));
            Complex w = new Complex(int.Parse(s4[0]), int.Parse(s4[1]));
            Complex e = new Complex();

            switch (s5)
            {
                case "+":
                    e = q + w;
                    Console.WriteLine(e);
                    break;
                case "-":
                    e = q - w;
                    Console.WriteLine(e);
                    break;
                case "*":
                    e = q * w;
                    Console.WriteLine(e);
                    break;
                case "/":
                    e = q / w;
                    Console.WriteLine(e);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
