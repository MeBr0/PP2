using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    public class Snake: GameObject
    {
        public int DX = 0, DY = 0;

        public Snake(Point first, ConsoleColor color, char c) : base(first, color, c)
        {

        }

        public Snake()
        {

        }

        public void Save()
        {
            StreamWriter sw = new StreamWriter(@"XML\snake.xml", false);

            XmlSerializer xs = new XmlSerializer(typeof(List<Point>));

            xs.Serialize(sw, this.body);

            sw.Close();
        }

        public List<Point> Load()
        {
            FileStream fs = new FileStream(@"XML\snake.xml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(List<Point>));

            List<Point> body = xs.Deserialize(fs) as List<Point>;

            fs.Close();

            return body;
        }
        
        public void Move()
        {           
            if(DX != 0 || DY != 0)
            {
                Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
                Console.WriteLine(" ");

                for (int i = body.Count - 1; i > 0; --i)
                {
                    body[i].X = body[i - 1].X;
                    body[i].Y = body[i - 1].Y;
                }

                body[0].X += DX;
                body[0].Y += DY;

                Check();


                Console.SetCursorPosition(body[0].X, body[0].Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(c);

                if (body.Count != 1)
                {
                    Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
                    Console.ForegroundColor = color;
                    Console.WriteLine(c);
                }
                try
                {
                    Console.SetCursorPosition(body[1].X, body[1].Y);
                    Console.ForegroundColor = color;
                    Console.WriteLine(c);
                }
                catch
                {

                }
            }
            
        }

        void Check()
        {
            if (body[0].X > Game.boardW - 1) body[0].X = 0;
            else if (body[0].X < 0) body[0].X = Game.boardW - 1;
            if (body[0].Y > Game.boardH - 3) body[0].Y = 0;
            else if (body[0].Y < 0) body[0].Y = Game.boardH - 3;

        }

        public void Draw()
        {
            int q = 0;
            for (int i = 0; i < body.Count; ++i){
                Console.SetCursorPosition(body[i].X, body[i].Y);
                if (q == 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = color;
                Console.WriteLine(c);
                q++;
            }
        }

        public void Stop()
        {
            DX = 0;
            DY = 0;
        }
    }
}
