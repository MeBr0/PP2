using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    class Program
    {
        private static void F1()
        {
            Complex x = new Complex(4, 5);

            FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            xs.Serialize(fs, x);

            fs.Close();
        }
        private static void F2()
        {
            FileStream fs = new FileStream("complex.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            Complex y = xs.Deserialize(fs) as Complex;

            Console.WriteLine(y);

            fs.Close();
        }
        static void Main(string[] args)
        {
            F1();
            F2();
        }
    }
}
