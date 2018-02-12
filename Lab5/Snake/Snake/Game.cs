using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum GameLevel
    {
        First,
        Second
    }

    class Game
    {
        public static int boardW = 35;
        public static int boardH = 35;

        char[,] field = new char[35, 35];

        Snake snake;
        Food food;
        Wall wall;
        public bool IsAlive = true;

        GameLevel gameLevel;

        List<GameObject> g_objects = new List<GameObject>();

        public void SetupBoard()
        {
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;
        }

        public Game()
        {
            gameLevel = GameLevel.First;

            snake = new Snake(new Point { X = 17, Y = 17 },
                            ConsoleColor.Blue, 'o');
            food = new Food(new Point { X = new Random().Next(0, Game.boardW), Y = new Random().Next(0, Game.boardH)},
                           ConsoleColor.Red, 'Q');
            food.IsAlive = true;
            wall = new Wall(null, ConsoleColor.Gray, '#');

            wall.LoadLevel(gameLevel);

            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);
        }

        public void Draw()
        {
            Console.Clear();
            foreach (GameObject g in g_objects)
            {
                g.Draw();
            }
        }

        public void Exit()
        {

        }

        public void Start()
        {

        }

        void Collision()
        {
            if (snake.body[0].Equals(food.body[0]))
            {
                snake.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y });
                CreateFood();
                food.Draw();
            }
            else
            {
                foreach (Point p in wall.body)
                {
                    if (p.Equals(snake.body[0]))
                    {
                        Console.Clear();
                        Console.WriteLine("GAME OVER!!!");
                        IsAlive = false;
                        break;
                    }
                }
                foreach (Point p in snake.body)
                {
                    if (p.Equals(snake.body[0]) && p != snake.body[0])
                    {
                        Console.Clear();
                        Console.WriteLine("GAME OVER!!!");
                        IsAlive = false;
                        break;
                    }
                }

            }
        }

        void CreateFood()
        {
            food.body.Clear();
            while (true)
            {
                int _y = new Random().Next(0, Game.boardH);
                int _x = new Random().Next(0, Game.boardW);

                bool t = false;
                bool t2 = false;

                Point p = new Point { X = _x, Y = _y };
                for (int i = 0; i < snake.body.Count; ++i)
                {
                    if (snake.body[i] == p)
                    {
                        t = true;
                        break;
                    }    
                }
                if (!t)
                {
                    for (int i = 0; i < wall.body.Count; ++i)
                    {
                        if (wall.body[i] == p)
                        {
                            t2 = true;
                            break;
                        }
                    }
                }
                if (!t && !t2)
                {
                    food.body.Add(p);
                    break;
                }
            }
            
        }


        public void Process(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
            {
                case ConsoleKey.UpArrow:
                    snake.Shift(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    snake.Shift(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    snake.Shift(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    snake.Shift(1, 0);
                    break;
                case ConsoleKey.Escape:
                    break;
            }
            Collision();
            
        }
    }
}
