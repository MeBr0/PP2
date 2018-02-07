using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Wall wall = new Wall(1);

            bool gameOver = false;
            Console.CursorVisible = false;
            wall.Draw();

            while (!gameOver)
            {
                snake.Draw();
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (keyInfo.Key == ConsoleKey.Escape)
                    gameOver = true;

                if (snake.cnt == 60)
                    wall = new Wall(2);

                Console.Clear();
            }
        }
    }
}