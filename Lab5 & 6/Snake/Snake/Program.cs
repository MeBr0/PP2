using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
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
