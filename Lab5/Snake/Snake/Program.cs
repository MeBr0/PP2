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

    enum Mode
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

            Mode mode = Mode.menu;
            GameLvl lvl = GameLvl.first;
            Menu menu = new Menu(null, ConsoleColor.Blue, '#');
            menu.LoadRamp();
            menu.Draw();
            /*Game game = new Game(lvl);
            game.SetUpWindow();
            game.Draw();
            game.StartLevel();*/
            /*while (game.Alive && mode == Mode.play)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                game.Process(btn);
            }*/
            while (mode == Mode.menu)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                menu.Process(btn);
            }

        }
    }
}
