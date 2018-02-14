using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Engine
    {
        GameLvl lvl;
        Mode mode;
        Menu menu;
        Game game;

        public bool Switch;

        public Engine()
        {
            Switch = true;
            mode = Mode.menu;
            lvl = GameLvl.first;
            menu = new Menu(null, ConsoleColor.Blue, '#');
            menu.LoadRamp();
            game = new Game(lvl);

            menu.Draw();
        }

        public void Draw()
        {

        }

        public void Process(ConsoleKeyInfo btn)
        {
            if (mode == Mode.menu)
            {
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                        menu.Process(btn);
                        break;
                    case ConsoleKey.Enter:
                        switch (menu.ind)
                        {
                            case 0:
                                mode = Mode.play;
                                game.CreateNewLvl(lvl);
                                game.Draw();
                                game.StartLevel();
                                break;
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                Switch = false;
                                Console.SetCursorPosition(0, 0);
                                Console.Clear();
                                break;

                        }
                        break;
                }
            }
            else
            {
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.S:
                        game.Process(btn);
                        break;
                }
            }

        }

    }
}
