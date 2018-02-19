using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    class Engine
    {
        GameLvl lvl;
        Mode mode;
        Menu menu;
        Game game;
        public int speed = 200;

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
                                game.CreateNewLvl(lvl);
                                game.Draw();
                                mode = Mode.play;
                                break;
                            case 1:
                                game.CreateNewLvl(GameLvl.first);
                                game.Load();
                                lvl = game.lvl;
                                game.Draw();
                                game.StopSnake();
                                game.Alive = true;
                                mode = Mode.play;
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
                        game.Process(btn);
                        break;
                    case ConsoleKey.Tab:
                        game.Save();
                        break;
                }
            }
        }

        void CheckAlive()
        {
            if (!game.Alive)
            {
                Console.Clear();
                mode = Mode.menu;
                menu.Draw();
            }
        }

        public void StartProcess()
        {
            ThreadStart ts = new ThreadStart(Action);
            Thread t = new Thread(ts);
            t.Start();
        }

        void Action()
        {
            while (true)
            {
                if (mode == Mode.play)
                {
                    game.SnakeAction();
                    CheckAlive();
                }
                else
                {

                }
                Thread.Sleep(speed);
            }
        }

        public static void SetUpWindow()
        {
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;
        }
    }
}
