using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day_planner
{
    class Menu
    {
        private int Index;
        private string[] Massive;
        private string Start;
        public int perecl;
        
        public Menu(string start, string[] options)
        {
            Start = start;
            Massive = options;
            Index = 0;
            perecl = 0;
        }
        public void DisplayOptions()
        {
           Console.WriteLine(Start);
            for (int i = 0; i < Massive.Length; i++)
            {
                string currentmassive = Massive[i];
                
                string strelocka;
                if (i == Index)
                {
                    strelocka = "->";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    strelocka = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{strelocka}{currentmassive}");
            }
            Console.ResetColor();
        }
        public int strelocki()
        {
            ConsoleKey keys;
            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keysI = Console.ReadKey(true);
                keys = keysI.Key;
                if (keys == ConsoleKey.UpArrow)
                {
                    Index--;
                    if (Index == -1)
                    {
                        Index = Massive.Length - 1;
                    }
                }
                else if (keys == ConsoleKey.DownArrow)
                {
                    Index++;
                    if (Index == Massive.Length)
                    {
                        Index = 0;
                    }
                }
                else if (keys == ConsoleKey.LeftArrow)
                {
                    perecl--;
                    if (perecl == -1)
                    {
                        perecl = 0;
                    }
                }
            }while(keys != ConsoleKey.Enter);
            return Index;
        }
    }
}
