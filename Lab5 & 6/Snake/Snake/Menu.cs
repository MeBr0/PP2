using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Menu: GameObject
    {
        public string[] List = { "NEW GAME", "LOAD GAME", "OPTIONS", "HIGHSCORES", "EXIT" };
        public int ind = 0;

        public Menu(Point first, ConsoleColor color, char c) : base(first, color, c)
        {

        }

        public void DrawAll()
        {
            DrawRamp();
            DrawMenu();
        }

        public void Process(ConsoleKeyInfo btn)
        {
            switch (btn.Key)
            {
                case ConsoleKey.UpArrow:
                    Shift(-1);
                    break;
                case ConsoleKey.DownArrow:
                    Shift(1);
                    break;
            }
        }

        void Shift(int a)
        {
            Console.SetCursorPosition(12, 15 + ind);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("->" + List[ind]);

            Check(a);

            Console.SetCursorPosition(12, 15 + ind);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("->" + List[ind]);
        }

        void Check(int a)
        {
            ind += a;
            if (ind > List.Length - 1) ind = 0;
            else if (ind < 0) ind = List.Length - 1;
        }

        public void LoadRamp()
        {
            FileStream fs = new FileStream(@"Menu\Menu.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == c) body.Add(new Point { X = x, Y = y });
                }
                y++;
            }

            sr.Close();
            fs.Close();

        }

        void DrawRamp()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < body.Count; ++i)
            {
                Console.SetCursorPosition(body[i].X, body[i].Y);
                Console.Write(c);
            }
        }

        void DrawMenu()
        {
            for(int i = 0; i < List.Length; ++i)
            {
                Console.SetCursorPosition(12, 15 + i);
                if (i == ind)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write("->" + List[i]);
            }
        }

    }
}
