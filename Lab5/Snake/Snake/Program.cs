using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    enum GameLvl
    {
        first,
        second,
        third,
        fourth,
        fifth
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            
            Console.CursorVisible = false;

            Game game = new Game(GameLvl.first);

            game.Draw();
            game.StartLevel();

            while (game.Alive)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                game.Process(btn);
            }

        }
    }
}
