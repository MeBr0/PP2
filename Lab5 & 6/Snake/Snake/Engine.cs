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
        public static int boardW = 35; //ширина консоли
        public static int boardH = 35; //высота консоли

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

            menu.DrawAll();
        }

        public void Process()
        {
            while (Switch)
            {
                ConsoleKeyInfo btn = Console.ReadKey();

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
                                    mode = Mode.play;
                                    game = game.Load();
                                    lvl = game.lvl;
                                    game.CreateNewLvl(lvl);
                                    game = game.Load();
                                    game.Draw();
                                    game.StopSnake();
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
                Thread.Sleep(speed);
            }
        }

        void CheckAlive()
        {
            if (!game.Alive)
            {
                Console.Clear();
                mode = Mode.menu;
                menu.DrawAll();
            }
        }

        public void StartProcess()
        {
            ThreadStart ts = new ThreadStart(Action);
            Thread t = new Thread(ts);
            ThreadStart t1 = new ThreadStart(Process);
            Thread t2 = new Thread(t1);

            t.Start();
            t2.Start();
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
            Console.SetWindowSize(Engine.boardW, Engine.boardH);
            Console.SetBufferSize(Engine.boardW, Engine.boardH);
            Console.CursorVisible = false;
        }
    }
}
