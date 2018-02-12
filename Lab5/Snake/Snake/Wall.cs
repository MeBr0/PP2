using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall: GameObject
    {
        public Wall(Point first, ConsoleColor color, char c) : base(first, color, c)
        {

        }

        public void LoadLevel(GameLvl lvl)
        {
            string path = "";

            switch (lvl)
            {
                case GameLvl.first:
                    path = @"LVLs\lvl1.txt";
                    break;
                case GameLvl.second:
                    break;
            }

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;

            while((line = sr.ReadLine()) != null)
            {
                for(int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == c) body.Add(new Point { X = x, Y = y });
                }
                y++;
            }

            sr.Close();
            fs.Close();
        }
    }
}
