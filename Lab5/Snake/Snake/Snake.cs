using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : GameObject
    {
        public bool IsAlive;
        ConsoleColor headcolor = ConsoleColor.Green;
        public Snake(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }
        public void Move(int dx, int dy)
        {

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0] = new Point { X = body[0].X + dx, Y = body[0].Y + dy };
            ShiftHead();
            Draw();
        }
        void ShiftHead()
        {
            if (body[0].X >= Game.boardH) body[0].X = 0;
            else if (body[0].X < 0) body[0].X = Game.boardH - 1;
            if (body[0].Y >= Game.boardW) body[0].Y = 0;
            else if (body[0].Y < 0) body[0].Y = Game.boardW - 1;
        }
        public void Shift(int dx, int dy)
        {


            Console.SetCursorPosition(body[body.Count - 1].X, body[body.Count - 1].Y);
            Console.ForegroundColor = color;
            Console.Write(' ');

            Move(dx, dy);
            try
            {
                Console.SetCursorPosition(body[1].X, body[1].Y);
                Console.ForegroundColor = color;
                Console.Write(sign);
            }
            catch
            {

            }
            finally
            {
                Console.SetCursorPosition(body[0].X, body[0].Y);
                Console.ForegroundColor = headcolor;
                Console.Write(sign);
            }
        }
    }
}