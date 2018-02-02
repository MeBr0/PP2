using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        private static void F1()
        {
            FileStream fs = new FileStream("complex.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            Complex x = new Complex(2, 3);
            bf.Serialize(fs, x);

            fs.Close();
        }
        private static void F2()
        {
            FileStream fs = new FileStream("complex.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            Complex x = bf.Deserialize(fs) as Complex;

            Console.WriteLine(x);

            fs.Close();
        }

        static void Main(string[] args)
        {
            F1();
            F2();
        }
    }
}
