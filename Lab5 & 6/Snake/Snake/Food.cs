using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    public class Food: GameObject //еда, наследуется от GameObject
    {
        public Food(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {                                                              //наследуемый конструктор

        }

        public Food() //пустой конструктор для сериализации
        {

        }
    }
}
