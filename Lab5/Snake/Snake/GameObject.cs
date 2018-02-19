using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public abstract class GameObject
    {
        public List<Point> body { get; set; }
        public char c { get; }
        public ConsoleColor color { get; }

        public GameObject(Point first, ConsoleColor color, char c)
        {
            this.body = new List<Point>();
            if (first != null) this.body.Add(first);
            this.c = c;
            this.color = color;
        }
        
        public GameObject()
        {

        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(c);
            }
        }
    }
}
