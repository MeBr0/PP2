using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate int MyDelegate();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            string s = Console.ReadLine();
            string[] q = s.Split(' ');

            int a = int.Parse(q[0]);
            int b = int.Parse(q[1]);

            Numbers numbers = new Numbers(a, b);

            MyDelegate MD = numbers.Sum;

            Thread.Sleep(1000);

            for(int i = 0; i < 9; ++i)
            {
                Console.SetCursorPosition(0, 1);
                Console.Write(i + 1);
                Thread.Sleep(1000);
            }

            Console.SetCursorPosition(0, 1);
            Console.WriteLine(MD.Invoke());
        }
    }
}
