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
    public class Game //класс отвечающий за игровую часть
    {
        public int speed = 200;        //скорость игры
        public bool Alive;             //булевое значение, жива ли змейка
        int coef = 10;
        public int score;
        
        public Snake snake; //змейка
        public Food food;   //еда
        public Wall wall;   //стенка

        public GameLvl lvl; //текущий уровень

        public Game(GameLvl lvl) //конструктор
        {
            CreateNewLvl(lvl);
        }

        public Game() //пустой конструктор для сериализации
        {

        }

        public void CreateNewLvl(GameLvl lvl) //метод для создания нового уровня
        {
            Alive = true;
            if(lvl == GameLvl.first)
            {
                snake = new Snake(new Point { X = 17, Y = 16 }, ConsoleColor.Blue, 'o');
                food = new Food(new Point { X = -1, Y = -1 }, ConsoleColor.Red, '@');
                wall = new Wall(null, ConsoleColor.Gray, '#');
                score = 0;
            }
            else
            {
                score += (snake.body.Count - 1) * coef;
                snake.body.Clear();
                snake.body.Add(new Point { X = 17, Y = 16 });
                wall.body.Clear();
            }
            
            wall.LoadLevel(lvl);
        }

        public Game Load() // десериалзация игры
        {
            FileStream fs = new FileStream(@"XML\game.xml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(Game));

            Game s = xs.Deserialize(fs) as Game;

            fs.Close();

            return s;
        }
        
        public void Save() // сериализация игры
        {
            StreamWriter sw = new StreamWriter(@"XML\game.xml", false);
            XmlSerializer xs = new XmlSerializer(typeof(Game));

            xs.Serialize(sw, this);

            sw.Close();
        }

        public void StopSnake() //метод для остановки змейки
        {
            snake.Stop();
        } 

        public void SnakeAction() //метод осуществлящий движение змеи, с последующими проверками
        {
            snake.Move();
            HeadCollision();
            CheckScore();
        } 

        public void Process(ConsoleKeyInfo btn) //основной процесс игры
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

        public void Draw() //метод для рисования игры
        {
            Console.Clear();
            CreateNewFood();
            food.Draw();
            snake.Draw();
            wall.Draw();
            DrawStatus();
        } 

        void ReScore() //метод для изменения счета
        {
            Console.SetCursorPosition(9, Engine.boardH - 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(score + (snake.body.Count - 1) * 10);
        } 

        void DrawStatus() //метод для рисования меню статуса
        {
            Console.SetCursorPosition(0, Engine.boardH - 2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Score: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(score + (snake.body.Count - 1) * coef);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Level ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Level(lvl));

        }

        static int Level(GameLvl lvl)
        {
            int a = 1;
            if (lvl == GameLvl.first) a = 1;
            else if (lvl == GameLvl.second) a = 2;
            else if (lvl == GameLvl.third) a = 3;
            else if (lvl == GameLvl.fourth) a = 4;
            else if (lvl == GameLvl.fifth) a = 5;
            return a;
        }

        void HeadCollision() //метод для проверки столкновений головы
        {
            if (snake.body[0].Equals(food.body[0]))
            {
                snake.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y});
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
                        Alive = false;
                        break;
                    }
                }
                foreach (Point p in snake.body)
                {
                    if (p.Equals(snake.body[0]) && p != snake.body[0])
                    {
                        Alive = false;
                        break;
                    }
                }
            }
        }

        void ProceedLevel()
        {
            if (lvl == GameLvl.first) lvl = GameLvl.second;
            else if (lvl == GameLvl.second) lvl = GameLvl.third;
            else if (lvl == GameLvl.third) lvl = GameLvl.fourth;
            else if (lvl == GameLvl.fourth) lvl = GameLvl.fifth;
        }

        void CheckScore() //метод для проверки счета
        {
            if( 12 == snake.body.Count - 1)
            {
                ProceedLevel();
                snake.Stop();
                CreateNewLvl(lvl);
                Draw();
            }
        } 

        void CreateNewFood() //метод для создания новой еды
        {
            food.body.Clear();
            bool Re = true;
            Point q = new Point { X = 0, Y = 0 };

            while (Re)
            {
                Re = false;
                int _x = new Random().Next(0, Engine.boardW - 1);
                int _y = new Random().Next(0, Engine.boardH - 3);
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
    }
}
