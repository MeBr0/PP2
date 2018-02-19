using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Wall: GameObject //cтенка, наследуется от GameObject
    {
        public Wall(Point first, ConsoleColor color, char c) : base(first, color, c) //наследуемый констуктор
        {

        }

        public int count; //счет

        public void LoadLevel(GameLvl lvl) //метод для загрузки стенок уровня
        {
            string path = "";
            count = 0;

            switch (lvl)
            {
                case GameLvl.first:
                    path = @"LVLs\lvl1.txt";
                    break;
                case GameLvl.second:
                    path = @"LVLs\lvl2.txt";
                    break;
                case GameLvl.third:
                    path = @"LVLs\lvl3.txt";
                    break;
                case GameLvl.fourth:
                    path = @"LVLs\lvl4.txt";
                    break;
                case GameLvl.fifth:
                    path = @"LVLs\lvl5.txt";
                    break;
            }

            body.Clear();

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
