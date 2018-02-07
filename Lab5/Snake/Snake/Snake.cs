using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        List<Point> body;
        public char c;
        public ConsoleColor color;
        public int cnt;
        public Snake()
        {
            cnt = 0;
            c = '*';
            body = new List<Point>();
            body.Add(new Point(12, 10));
            body.Add(new Point(11, 10));
            body.Add(new Point(10, 10));
            color = ConsoleColor.Yellow;
        }

        public void Move(int dx, int dy)
        {
            //cnt++;
            //if (cnt % 20 == 0)
            //    body.Add(new Point(0, 0));

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x < 1)
                body[0].x = 38;
            if (body[0].x > 38)
                body[0].x = 1;
            if (body[0].y < 1)
                body[0].y = 18;
            if (body[0].y > 18)
                body[0].y = 1;
        }

        public void Shift(int dx, int dy)
        {
            Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
            Console.Write(' ');
            Console.SetCursorPosition(body[0].x, body[0].y);
            Console.ForegroundColor = color;
            Console.Write('*');

            Move(dx, dy);

            Console.SetCursorPosition(body[0].x, body[0].y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('*');
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            int index = 0;
            foreach (Point p in body)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(c);
                index++;
            }
        }

    }
}