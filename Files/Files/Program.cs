using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void PrintState(int index, FileSystemInfo[] arr)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for(int i = 0; i < arr.Length; ++i)
            {
                if(arr[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if(i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write(arr[i].Name);
                for (int j = 1; j <= 40 - arr[i].Name.Length; ++j)
                {
                    Console.Write(' ');
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine('|');
            }
        }
        static void Main(string[] args)
        {
            var Aza = new Stack<DirectoryInfo>();
            var Indexx = new Stack<int>();
            DirectoryInfo a = new DirectoryInfo(@"C:\Users\Lenovo\Desktop\Study\ICT");
            FileSystemInfo[] qwe = a.GetFileSystemInfos();
            Aza.Push(a);
            int index = 0;
            Indexx.Push(index);
            bool w = false;

            while (!w)
            {
                PrintState(index, qwe);
                ConsoleKeyInfo btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        if (Indexx.Peek() < 0) index = qwe.Length - 1;
                        Indexx.Pop();
                        Indexx.Push(index);
                        break;
                    case ConsoleKey.DownArrow:
                        index = (index + 1) % qwe.Length;
                        Indexx.Pop();
                        Indexx.Push(index);
                        break;
                    case ConsoleKey.Enter:
                        if (qwe[index].GetType() == typeof(DirectoryInfo))
                        {
                            string q = qwe[index].FullName;
                            index = 0;
                            Indexx.Push(index);
                            DirectoryInfo c = new DirectoryInfo(@q);
                            Aza.Push(c);
                            qwe = Aza.Peek().GetFileSystemInfos();
                        }
                        break;
                    case ConsoleKey.B:
                        Aza.Pop();
                        qwe = Aza.Peek().GetFileSystemInfos();
                        Indexx.Pop();
                        index = Indexx.Peek();
                        break;
                    case ConsoleKey.Escape:
                        w = true;
                        break;
                }
            }
            
        }
    }
}
