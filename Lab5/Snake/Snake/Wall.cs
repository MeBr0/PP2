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
        char c;
        ConsoleColor color;

        public void ReadLevel(int a)
        {
            FileStream fs = new FileStream("level" + a + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    string s = sr.ReadLine();
                    for (int j = 0; j < s.Length; j++)
                        if (s[j] == c) body.Add(new Point(j, i));
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
            c = '#';
            ReadLevel(level);
        }

        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.ForegroundColor = color;
                Console.Write(c);
            }
        }
    }
}