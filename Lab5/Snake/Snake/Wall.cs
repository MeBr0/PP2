using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Wall : GameObject
    {
        public Wall(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }

        public void LoadLevel(GameLevel level)
        {
            string fname = "";

            switch (level)
            {
                case GameLevel.First:
                    fname = @"LVLs\Lvl1.txt";
                    break;
                case GameLevel.Second:
                    break;
                default:
                    break;
            }

            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point { X = x, Y = y });
                    }
                }
                y++;
            }

            sr.Close();
            fs.Close();
        }
    }
}