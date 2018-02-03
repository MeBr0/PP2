using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far_Manager
{
    class Layer
    {
        public DirectoryInfo dirInfo;
        public string path;
        public int ind;
        public List<FileSystemInfo> items;

        public Layer(string path, int ind)
        {
            this.path = path;
            this.ind = ind;
            this.dirInfo = new DirectoryInfo(path);
            items = new List<FileSystemInfo>();
            items.AddRange(dirInfo.GetDirectories());
            items.AddRange(dirInfo.GetFiles());
        }

        public void Process(int q)
        {
            this.ind += q;
            if (this.ind < 0) this.ind = items.Count() - 1;
            if (this.ind > items.Count - 1) this.ind = 0;
        }

        public void SetColorInd()
        {
            if (this.items[this.ind].GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
        }

        public void SetColor()
        {
            if (this.items[this.ind].GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        public void DrawSingleRowInd()
        {
            Console.Write(" " + this.items[this.ind].Name);
            for (int j = 0; j < 39 - this.items[this.ind].Name.Length; ++j)
            {
                Console.Write(" ");
            }
        }

        public void DrawSingleRow()
        {
            Console.Write(" " + this.items[this.ind].Name);
            for (int j = 0; j < 40 - this.items[this.ind].Name.Length; ++j)
            {
                Console.Write(" ");
            }
        }
        public string GetSelectedItemInfo()
        {
            return this.items[ind].FullName;
        }
    }
}
