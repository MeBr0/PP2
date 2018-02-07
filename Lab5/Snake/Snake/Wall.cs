using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Wall
    {
        List<Point> body;
        string sign;
        ConsoleColor color;

        public void ReadLevel(int level)
        {
            FileStream fs = new FileStream("level1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    string s = sr.ReadLine();
                    for (int j = 0; j < s.Length; j++)
                        if (s[j] == '#') body.Add(new Point(j, i));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

        }

        public Wall(int level)
        {
            body = new List<Point>();
            color = ConsoleColor.White;
            sign = "#";
            ReadLevel(level);
        }

        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.ForegroundColor = color;
                Console.Write(sign);
            }
        }
    }
}