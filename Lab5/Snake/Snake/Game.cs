using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum GameLvl
    {
        first,
        second,
        third
    }
    class Game
    {
        public static int boardW = 35;
        public static int boardH = 35;

        Snake snake;
        Food food;
        Wall wall;

        public bool Alive;

        GameLvl lvl;

        public Game()
        {
            Alive = true;
            lvl = GameLvl.first;

            snake = new Snake(new Point { X = 17, Y = 17 }, ConsoleColor.Blue, 'o');
            food = new Food(new Point { X = 20, Y = 20 }, ConsoleColor.Red, '@');
            wall = new Wall(null, ConsoleColor.Gray, '#');

            wall.LoadLevel(lvl);

        }

        public void Draw()
        {
            food.Draw();
            snake.Draw();
            wall.Draw();
        }

        public void ColHead()
        {
            if (snake.body[0].Equals(food.body[0]))
            {
                snake.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y});
                CreateNew();
                food.Draw();
                wall.Draw();
            }
            else
            {
                foreach (Point p in wall.body)
                {
                    if (p.Equals(snake.body[0]))
                    {
                        Console.Clear();
                        Console.WriteLine("GAME OVER!!!");
                        Alive = false;
                        break;
                    }
                }
            }
        }

        public void CreateNew()
        {
            food.body.Clear();
            bool Re = true;
            Point q = new Point { X = 0, Y = 0 };

            while (Re)
            {
                Re = false;
                int _x = new Random().Next(0, Game.boardW - 1);
                int _y = new Random().Next(0, Game.boardH - 1);
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

        public void Process(ConsoleKeyInfo btn)
        {
            switch (btn.Key)
            {
                case ConsoleKey.UpArrow:
                    snake.DX = 0;
                    snake.DY = -1;
                    break;
                case ConsoleKey.DownArrow:
                    snake.DX = 0;
                    snake.DY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    snake.DX = -1;
                    snake.DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    snake.DX = 1;
                    snake.DY = 0;
                    break;
            }
            snake.Move();
            ColHead();
        }
    }
}
