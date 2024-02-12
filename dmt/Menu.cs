using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmt
{
    public class Menu
    {
        private List<Tuple<string, Action>> items;
        private int position;

        public Menu(List<Tuple<string, Action>> items)
        {
            this.items = items;
        }

        public void Create()
        {
            try
            {
                position = 0;
                Console.WriteLine("Created");
                if (items == null)
                {
                    throw new ArgumentNullException("No menu items added");
                }
                Render();
                while (true)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (position == 0) position = items.Count - 1;
                        else position--;
                        Console.Clear();
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        if (position == items.Count - 1) position = 0;
                        else position++;
                        Console.Clear();
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        items[position].Item2();
                    }
                    Render();
                }
            }
            catch(Exception ex)
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                Console.WriteLine(line);
            }
        }

        private void Render()
        {
            // Reset Visuals
            Console.Clear();
            for (int count = 0; count < items.Count; count++)
            {
                if (count == position)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write($"{count+1}. {items[count].Item1}");
                    Console.ResetColor();
                    Console.Write("\n");
                }
                else
                {
                    Console.WriteLine($"{count+1}. {items[count].Item1}");

                }
            }

        }







    }
}



