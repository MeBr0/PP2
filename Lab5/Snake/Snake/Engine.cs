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

        void SaveGame()
        {
            FileStream fs = new FileStream(@"XML\snake.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Game));

            xs.Serialize(fs, game);

            fs.Close();
        }

        void LoadGame()
        {
            FileStream fs = new FileStream(@"XML\snake.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Game));

            xs.Serialize(fs, game);

            fs.Close();
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
                        game.Process(btn);
                        break;
                    case ConsoleKey.Tab:
                        SaveGame();
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
