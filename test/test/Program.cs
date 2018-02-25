using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("level1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            for (int i = 0; i < 11; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '#')
                    {
                        Console.SetCursorPosition(j, i);
                        Console.WriteLine('#');
                    }
            }
        }
    }
}
