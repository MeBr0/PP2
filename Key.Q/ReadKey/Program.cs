using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo a = Console.ReadKey();

            while(a.Key != ConsoleKey.Q)
            {
                switch(a.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("pressed Up arrow");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("pressed Down arrow");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("pressed Left arrow");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("pressed Right arrow");
                        break;
                }
                a = Console.ReadKey();
            }
        }
    }
}
