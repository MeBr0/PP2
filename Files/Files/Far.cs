using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Far
    {
        Stack<Layer> History = new Stack<Layer>();
        Layer active;

        public Far(string path) //constructor
        {
            this.active = new Layer(path, 0);
        }

        public void Draw() //main function for drawing
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            DirectoryInfo DirInfo = new DirectoryInfo(active.path);
            FileInfo[] files = DirInfo.GetFiles();
            DirectoryInfo[] dirs = DirInfo.GetDirectories();

            Console.ForegroundColor = ConsoleColor.White;
            
            for(int i = 0; i < dirs.Length; ++i)
            {
                Console.WriteLine(dirs[i].Name);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            for(int i = 0; i < files.Length; ++i)
            {
                Console.WriteLine(files[i].Name);
            }
        }
    }
}
