using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    public class Snake: GameObject //змейка, наследуется от GameObject
    {
        public int DX = 0, DY = 0; //координаты сообщающие о движении змейки

        public ConsoleColor colorh;

        public Snake(Point first, ConsoleColor color, char c) : base(first, color, c) //наследуемый конструктор
        {

        }

        public Snake() //пустой конструктор для сериализации
        {

        }

        public void Move() //метод для движения змейки
        {           
            if(DX != 0 || DY != 0)
            {
                Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
                Console.WriteLine(" ");

                for (int i = body.Count - 1; i > 0; --i)
                {
                    body[i].X = body[i - 1].X;
                    body[i].Y = body[i - 1].Y;
                }

                body[0].X += DX;
                body[0].Y += DY;

                Check();


                Console.SetCursorPosition(body[0].X, body[0].Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(c);

                if (body.Count != 1)
                {
                    Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
                    Console.ForegroundColor = color;
                    Console.WriteLine(c);
                }
                try
                {
                    Console.SetCursorPosition(body[1].X, body[1].Y);
                    Console.ForegroundColor = color;
                    Console.WriteLine(c);
                }
                catch
                {

                }
            }
            
        }

        void Check() //метод проверки выхода за границы
        {
            if (body[0].X > Engine.boardW - 1) body[0].X = 0;
            else if (body[0].X < 0) body[0].X = Engine.boardW - 1;
            if (body[0].Y > Engine.boardH - 3) body[0].Y = 0;
            else if (body[0].Y < 0) body[0].Y = Engine.boardH - 3;
        }

        public void Draw() //ненаследуемый метод для рисования
        {
            int q = 0;
            for (int i = 0; i < body.Count; ++i){
                Console.SetCursorPosition(body[i].X, body[i].Y);
                if (q == 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = color;
                Console.WriteLine(c);
                q++;
            }
        }

        public void Stop() //остановление змейки
        {
            DX = 0;
            DY = 0;
        }
    }
}
