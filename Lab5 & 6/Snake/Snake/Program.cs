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

    public enum MenuMode
    {
        main,
        options,
        colors
    }

    class Program
    {
        static void Main(string[] args)
        {
            Engine.SetUpWindow();

            Engine engine = new Engine();

            engine.StartProcess();
        }
    }
}
