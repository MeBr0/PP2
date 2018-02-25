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
    enum Obj
    {
        snake,
        wall,
        food
    }

    class Engine
    {
        public static int boardW = 35; //ширина консоли
        public static int boardH = 35; //высота консоли

        Thread t;
        Thread t2;

        ConsoleColor snakecolor = ConsoleColor.Blue;
        ConsoleColor wallcolor = ConsoleColor.Gray;
        ConsoleColor foodcolor = ConsoleColor.Red;

        GameLvl lvl;
        Mode mode;
        MenuMode menumode;
        Obj obj;

        Menu menu;
        Game game;

        public int speed = 200;
        public bool Switch;

        ConsoleColor color;

        public Engine()
        {
            Switch = true;
            mode = Mode.menu;
            menumode = MenuMode.main;
            lvl = GameLvl.first;
            obj = Obj.snake;

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
                            switch (menumode)
                            {
                                case MenuMode.main:
                                    MenuAction();
                                    break;
                                case MenuMode.options:
                                    OptionsAction();
                                    break;
                                case MenuMode.colors:
                                    ColorsAction();
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

        void MenuAction()
        {
            switch (menu.ind)
            {
                case 0:
                    mode = Mode.play;
                    lvl = GameLvl.first;
                    game.lvl = lvl;
                    game.CreateNewLvl(game.lvl);
                    game.LoadColors(snakecolor, wallcolor, foodcolor);
                    game.CreateNewFood();
                    game.Draw();
                    break;
                case 1:
                    mode = Mode.play;
                    game = Game.Load();
                    game.LoadColors(snakecolor, wallcolor, foodcolor);
                    game.Draw();
                    game.StopSnake();
                    break;
                case 2:
                    menu.ChangeOptions();
                    menumode = menu.menumode;
                    menu.DrawAll();
                    break;
                case 3:
                    break;
                case 4:
                    Switch = false;
                    EndProcess();
                    break;
            }
        }

        void OptionsAction()
        {
            switch (menu.ind)
            {
                case 0:
                    menu.ChangeColors();
                    menumode = menu.menumode;
                    obj = Obj.snake;
                    break;
                case 1:
                    menu.ChangeColors();
                    menumode = menu.menumode;
                    obj = Obj.wall;
                    break;
                case 2:
                    menu.ChangeColors();
                    menumode = menu.menumode;
                    obj = Obj.food;
                    break;
            }
        }

        void ColorsAction()
        {
            switch (menu.ind)
            {
                case 0:
                    color = ConsoleColor.Red;
                    break;
                case 1:
                    color = ConsoleColor.Yellow;
                    break;
                case 2:
                    color = ConsoleColor.Blue;
                    break;
                case 3:
                    color = ConsoleColor.Green;
                    break;
                case 4:
                    color = ConsoleColor.Cyan;
                    break;
                case 5:
                    color = ConsoleColor.White;
                    break;
                case 6:
                    color = ConsoleColor.Magenta;
                    break;
                case 7:
                    color = ConsoleColor.Gray;
                    break;
            }
            switch (obj)
            {
                case Obj.snake:
                    snakecolor = color;
                    break;
                case Obj.wall:
                    wallcolor = color;
                    break;
                case Obj.food:
                    foodcolor = color;
                    break;
            }
            menu.ChangeMenu();
            menumode = menu.menumode;
            menu.DrawAll();
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
            t = new Thread(ts);
            ThreadStart t1 = new ThreadStart(Process);
            t2 = new Thread(t1);

            t.Start();
            t2.Start();
        }

        void EndProcess()
        {
            t.Abort();
            t2.Abort();
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
