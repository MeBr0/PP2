using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food : GameObject
    {
        public Food(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }
        public bool IsAlive;
        public void CreateNewFood()
        {
            body.Clear();
            int _y = new Random().Next(0, Game.boardH);
            int _x = new Random().Next(0, Game.boardW);
            body.Add(new Point { X = _x, Y = _y });

        }
    }
}
