using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Far_Manager
{
    enum FarMode //enum for Far modes
    {
        Explorer,
        FileReader
    }
    class Far
    {
        Stack<Layer> History = new Stack<Layer>(); //history of directories
        Layer current;                             //current location
        FarMode mode = FarMode.Explorer;           //mode for Far

        public Far(string path)
        {
            this.current = new Layer(path, 0);
        }

        public void Draw() //main function for drawing
        {
            switch (mode)
            {
                case FarMode.Explorer:
                    DrawExplorer();
                    break;
                case FarMode.FileReader:
                    DrawFileReader();
                    break;
            }
            DrawStatus();
            ShiftCursor();
        }

        private void ShiftCursor() //Shift cursor to bottom
        {
            if (current.ind > 36 || mode == FarMode.FileReader) Console.SetCursorPosition(39, 1 + current.ind);
            else
            {
                Console.SetCursorPosition(39, 0);
                Console.SetCursorPosition(39, 37);
            }
        }

        void DrawStatus() //Draw Status Bar
        {
            int shift = 36 - current.ind;
            if (shift < 0) Console.SetCursorPosition(0, 37 - shift);
            else Console.SetCursorPosition(0, 37);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            DrawStatus1(); //Draw current Mode 
            DrawStatus2(); //Draw Full Name of object
            DrawStatus3(); //Draw Number of directories and files if avialable
        }
        void DrawStatus1()
        {
            Console.Write(" Mode: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(mode);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 34 - mode.ToString().Length; ++i)
            {
                Console.Write(" ");
            }  
        }

        void DrawStatus2()
        {
            if (current.GetSelectedItemInfo().Length <= 38)
            {
                Console.Write(" " + current.GetSelectedItemInfo());
                for (int i = 0; i < 40 - current.GetSelectedItemInfo().Length; ++i)
                {
                    Console.Write(" ");
                }
            }
            else
            {
                Console.Write(" ");
                for (int i = 0; i < 35; ++i)
                {
                    Console.Write(current.GetSelectedItemInfo()[i]);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("...  ");
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        void DrawStatus3()
        {
            try
            {
                DirectoryInfo a = new DirectoryInfo(current.GetSelectedItemInfo());
                int b = a.GetFiles().Length;
                int c = a.GetDirectories().Length;
                Console.Write(" Directories: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Files: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(b);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" ");
                int d = 17 - c.ToString().Length - b.ToString().Length;
                for (int i = 0; i < d; ++i)
                {
                    Console.Write(" ");
                }
            }
            catch (Exception e)
            {
                for (int i = 0; i < 40; ++i)
                {
                    Console.Write(" ");
                }
            }
        }

        void DrawExplorer() //Draw in Explorer Mode
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            for (int i = 0; i < current.items.Count; ++i)
            {
                if (i == current.ind && current.items[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (i == current.ind && current.items[i].GetType() == typeof(FileInfo))
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (i != current.ind && current.items[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (i != current.ind && current.items[i].GetType() == typeof(FileInfo))
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.Write(" " + current.items[i].Name);
                for (int j = 0; j < 40 - current.items[i].Name.Length; ++j)
                {
                    Console.Write(" ");
                }
            }
        }

        void DrawFileReader() //Draw in FileReader Mode
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            FileStream fs = null;
            StreamReader sr = null;
            try //try to open
            {
                fs = new FileStream(current.GetSelectedItemInfo(), FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                Console.WriteLine(" " + sr.ReadToEnd());
            }
            catch (Exception e) //if not, write an error
            {
                Console.WriteLine(" cannot open file!");
            }
            finally //close files if open
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public void Shift(int q)
        {
            Console.SetCursorPosition(0, current.ind);
            current.SetColor();
            current.DrawSingleRow();

            current.ind += q;
            if (current.ind == current.items.Count) current.ind = 0;
            if (current.ind == -1) current.ind = current.items.Count - 1;

            Console.SetCursorPosition(0, current.ind);
            current.SetColorInd();
            current.DrawSingleRowInd();

        }

        public void Process(ConsoleKeyInfo pressed)
        {
            switch (pressed.Key)
            {
                case ConsoleKey.UpArrow:   //ind up
                    if (mode == FarMode.Explorer)
                    {
                        this.Shift(-1);
                        DrawStatus();
                        ShiftCursor();
                    }
                        break;
                case ConsoleKey.DownArrow: //ind down
                    if (mode == FarMode.Explorer)
                    {
                        this.Shift(1);
                        DrawStatus();
                        ShiftCursor();
                    }
                        break;
                case ConsoleKey.Enter:
                    if (mode == FarMode.Explorer)
                    {
                        try
                        {
                            if (current.items[current.ind].GetType() == typeof(DirectoryInfo)) //open directory
                            {
                                mode = FarMode.Explorer;
                                History.Push(current);
                                current = new Layer(current.GetSelectedItemInfo(), 0);
                                this.Draw();
                            }
                            else                                                               //open file
                            {
                                mode = FarMode.FileReader;
                                this.Draw();
                            }
                        }
                        catch (Exception e)
                        {
                            current = History.Pop();
                            this.Draw();
                        }
                    }
                    break;
                case ConsoleKey.Backspace:
                    if (mode == FarMode.Explorer)
                    {
                        current = History.Pop();
                        this.Draw();                                                   //back to directory
                    }
                    else
                    {
                        mode = FarMode.Explorer;
                        this.Draw();
                    }                                                                   //back to directory from file
                    break;
            }
        }
    }
}
