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
    public class Game
    {
        public static int boardW = 35;
        public static int boardH = 35;
        public int speed = 200;
        public bool Alive;
        
        public Snake snake;
        public Food food;
        public Wall wall;

        GameLvl lvl;

        public Game(GameLvl lvl)
        {
            CreateNewLvl(lvl);
        }

        public Game()
        {

        }

        public void CreateNewLvl(GameLvl lvl)
        {
            Alive = true;
            if(lvl == GameLvl.first)
            {
                snake = new Snake(new Point { X = 17, Y = 17 }, ConsoleColor.Blue, 'o');
                food = new Food(new Point { X = -1, Y = -1 }, ConsoleColor.Red, '@');
                wall = new Wall(null, ConsoleColor.Gray, '#');
            }
            else
            {
                snake.body.Clear();
                snake.body.Add(new Point { X = 17, Y = 17 });
                wall.body.Clear();
            }
            

            wall.LoadLevel(lvl);
        }

        public void SnakeAction()
        {
            snake.Move();
            HeadCollision();
            CheckScore();
        }

        public void Process(ConsoleKeyInfo btn)
        {
            if (Alive)
            {
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        if(snake.DY != 1)
                        {
                            snake.DX = 0;
                            snake.DY = -1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (snake.DY != -1)
                        {
                            snake.DX = 0;
                            snake.DY = 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if(snake.DX != 1)
                        {
                            snake.DX = -1;
                            snake.DY = 0;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if(snake.DX != -1)
                        {
                            snake.DX = 1;
                            snake.DY = 0;
                        }
                        break;
                }
            }
        }

        void ReScore()
        {
            Console.SetCursorPosition(9, Game.boardH - 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(wall.count);
        }

        public void Draw()
        {
            Console.Clear();
            CreateNewFood();
            food.Draw();
            snake.Draw();
            wall.Draw();
            DrawStatus();
        }

        void DrawStatus()
        {
            Console.SetCursorPosition(0, Game.boardH - 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Score: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Level ");
            Console.ForegroundColor = ConsoleColor.Green;
            if (lvl == GameLvl.first) Console.Write("1");
            else if (lvl == GameLvl.second) Console.Write("2");
            else if (lvl == GameLvl.third) Console.Write("3");
            else if (lvl == GameLvl.fourth) Console.Write("4");
            else if (lvl == GameLvl.fifth) Console.Write("5");

        }

        void Over()
        {
            Alive = false;
        }

        void HeadCollision()
        {
            if (snake.body[0].Equals(food.body[0]))
            {
                snake.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y});
                wall.count += 10;
                ReScore();
                CreateNewFood();
                food.Draw();
                wall.Draw();
            }
            else
            {
                foreach (Point p in wall.body)
                {
                    if (p.Equals(snake.body[0]))
                    {
                        Over();
                        break;
                    }
                }
                foreach (Point p in snake.body)
                {
                    if (p.Equals(snake.body[0]) && p != snake.body[0])
                    {
                        Over();
                        break;
                    }
                }
            }
        }

        void CheckScore()
        {
            if(wall.count == 120)
            {
                if (lvl == GameLvl.first) lvl = GameLvl.second;
                else if (lvl == GameLvl.second) lvl = GameLvl.third;
                else if (lvl == GameLvl.third) lvl = GameLvl.fourth;
                else if (lvl == GameLvl.fourth) lvl = GameLvl.fifth;

                snake.DX = 0;
                snake.DY = 0;
                CreateNewLvl(lvl);
                Draw();
            }
        } 

        void CreateNewFood()
        {
            food.body.Clear();
            bool Re = true;
            Point q = new Point { X = 0, Y = 0 };

            while (Re)
            {
                Re = false;
                int _x = new Random().Next(0, Game.boardW - 1);
                int _y = new Random().Next(0, Game.boardH - 3);
                q = new Point { X = _x, Y = _y };

                for (int i = 0; i < wall.body.Count; ++i)
                {
                    if (wall.body[i].Equals(q))
                    {
                        Re = true;
                        break;
                    }
                }
                for (int i = 0; i < snake.body.Count; ++i)
                {
                    if (snake.body[i].Equals(q))
                    {
                        Re = true;
                        break;
                    }
                }
            }
            food.body.Add(q);
        }   

        public void SetUpWindow()
        {
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;
        }
    }
}
