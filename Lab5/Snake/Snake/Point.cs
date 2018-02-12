using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            Point b = obj as Point;
            if (this.X == b.X && this.Y == b.Y) return true;
            return false;
        }
    }
}
