using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Least_Prime
{
    class Program
    {
        static bool IsPrime(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); ++i){
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string a = sr.ReadLine();
            string[] b = a.Split(' ');
            int min = -1;
            bool founded = false;

            foreach(string x in b)
            {
                if(IsPrime(int.Parse(x)) && !founded)
                {
                    min = int.Parse(x);
                    founded = true;
                }
                if(IsPrime(int.Parse(x)) && founded && int.Parse(x) < min)
                {
                    min = int.Parse(x);
                }
            }
            sr.Close();
            fs.Close();

            fs = new FileStream("output.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(min);
            sw.Close();
            fs.Close();
        }
    }
}
