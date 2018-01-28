using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_and_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string a = sr.ReadLine();
            string[] b = a.Split(' ');

            sr.Close();
            fs.Close();

            int max = int.Parse(b[0]);
            int min = int.Parse(b[0]);

            for(int i = 1; i < b.Length; ++i)
            {
                if (int.Parse(b[i]) > max) max = int.Parse(b[i]);
                if (int.Parse(b[i]) < min) min = int.Parse(b[i]);
            }

            Console.Write(max + " " + min);
            Console.WriteLine();
        }
    }
}
