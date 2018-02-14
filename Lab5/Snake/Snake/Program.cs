using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public enum GameLvl
    {
        first,
        second,
        third,
        fourth,
        fifth
    }

    public enum Mode
    {
        play,
        menu
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;

            Engine engine = new Engine();
            while (engine.Switch)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                engine.Process(btn);
            }
        }
    }
}
