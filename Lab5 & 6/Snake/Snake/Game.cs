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
        public static int boardW = 35; //ширина консоли
        public static int boardH = 35; //высота консоли
        public int speed = 200;        //скорость игры
        public bool Alive;             //булевое значение, жива ли змейка
        
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

        public void Save() //метод для сериализации игры
        {
            snake.Save();
            food.Save();
            SaveLvl();
        } 

        public void Load() //метод для десериализации игры
        {
            snake.body = snake.Load();
            food.body = food.Load();
            switch (LoadLvl())
            {
                case "first":
                    lvl = GameLvl.first;
                    break;
                case "second":
                    lvl = GameLvl.second;
                    break;
                case "third":
                    lvl = GameLvl.third;
                    break;
                case "fourth":
                    lvl = GameLvl.fourth;
                    break;
                case "fifth":
                    lvl = GameLvl.fifth;
                    break;
            }
        } 

        string LoadLvl() //метод для десериализации уровня
        {
            FileStream fs = new FileStream(@"XML\lvl.xml", FileMode.Open, FileAccess.Read);

            XmlSerializer xs = new XmlSerializer(typeof(GameLvl));

            string s = xs.Deserialize(fs) as string;

            fs.Close();

            return s;
        }   

        void SaveLvl() //метод для сериализации уровня
        {
            StreamWriter sw = new StreamWriter(@"XML\lvl.xml", false);
            XmlSerializer xs = new XmlSerializer(typeof(GameLvl));

            xs.Serialize(sw, lvl);

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
            Console.SetCursorPosition(9, Game.boardH - 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(wall.count);
        } 

        void DrawStatus() //метод для рисования меню статуса
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

        void Over() //метод для конца игры
        {
            Alive = false;
        }

        void HeadCollision() //метод для проверки столкновений головы
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

        void CheckScore() //метод для проверки счета
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

        void CreateNewFood() //метод для создания новой еды
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
    }
}
