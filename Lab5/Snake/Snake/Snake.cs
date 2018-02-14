using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake: GameObject
    {
        public int DX = 0, DY = 0;

        public Snake(Point first, ConsoleColor color, char c) : base(first, color, c)
        {

        }

        public Snake()
        {

        }
        public void Move()
        {
            Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

            for(int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0].X += DX;
            body[0].Y += DY;

            Check();


            Console.SetCursorPosition(body[0].X, body[0].Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(c);

            if (body.Count != 1)
            {
                Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = color;
                Console.WriteLine(c);
            }
            try
            {
                Console.SetCursorPosition(body[1].X, body[1].Y);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = color;
                Console.WriteLine(c);
            }
            catch
            {

            }
        }

        void Check()
        {
            if (body[0].X > Game.boardW - 1) body[0].X = 0;
            else if (body[0].X < 0) body[0].X = Game.boardW - 1;
            if (body[0].Y > Game.boardH - 3) body[0].Y = 0;
            else if (body[0].Y < 0) body[0].Y = Game.boardH - 3;

        }
    }
}
