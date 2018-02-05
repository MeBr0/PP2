﻿using System;
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

        public string Rename()
        {
            FileInfo fi = items[ind] as FileInfo;
            string s = Console.ReadLine();
            string w = items[ind].FullName.Remove(items[ind].FullName.Length - items[ind].Name.Length);
            string newFileName = $@"{s}{items[ind].Extension}";

            if (items[ind].GetType() == typeof(FileInfo))
            {
                string r = Path.Combine(fi.DirectoryName, newFileName);
                File.Move(items[ind].FullName, r);
            }
            else
            {
                string r = Path.Combine(w, newFileName);
                Directory.Move(items[ind].FullName, r);
            }

            return newFileName;
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
            if (this.items[this.ind].Name.Length <= 38)
            {
                Console.Write(" " + this.items[this.ind].Name);
                for (int j = 0; j < 39 - this.items[this.ind].Name.Length; ++j)
                {
                    Console.Write(" ");
                }
            }
            else
            {
                Console.Write(" ");
                for (int i = 0; i < 36; ++i)
                {
                    Console.Write(this.items[this.ind].Name[i]);
                }
                Console.Write("..  ");
            }
        }

        public void RefreshSingleRowInd(string s)
        {
            if (s.Length <= 38)
            {
                Console.Write(" " + s);
                for (int j = 0; j < 39 - s.Length; ++j)
                {
                    Console.Write(" ");
                }
            }
            else
            {
                Console.Write(" ");
                for (int i = 0; i < 36; ++i)
                {
                    Console.Write(s[i]);
                }
                Console.Write("..  ");
            }
        }

        public void DrawSingleRow()
        {
            if (this.items[this.ind].Name.Length <= 38)
            {
                Console.Write(" " + this.items[this.ind].Name);
                for (int j = 0; j < 40 - this.items[this.ind].Name.Length; ++j)
                {
                    Console.Write(" ");
                }
            }
            else
            {
                Console.Write(" ");
                for (int i = 0; i < 36; ++i)
                {
                    Console.Write(this.items[this.ind].Name[i]);
                }
                Console.Write("..  ");
            }
        }
        public string GetSelectedItemInfo()
        {
            return this.items[ind].FullName;
        }
    }
}
