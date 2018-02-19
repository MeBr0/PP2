using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    public class Food: GameObject
    {
        public Food(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }

        public Food()
        {

        }

        public void Save()
        {
            StreamWriter sw = new StreamWriter(@"XML\food.xml", false);

            XmlSerializer xs = new XmlSerializer(typeof(List<Point>));

            xs.Serialize(sw, this.body);

            sw.Close();
        }

        public List<Point> Load()
        {
            FileStream fs = new FileStream(@"XML\food.xml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(List<Point>));

            List<Point> body = xs.Deserialize(fs) as List<Point>;

            fs.Close();

            return body;
        }

    }
}
