using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Labyrinth //: ILabyrinth
    {
        public bool currentPlayer = true;

        public char[,] Board;

        //public string GetBoardView()
        //{
        //    Board = new char[10, 10]
        //    {
        //        { }
        //    }
        //}
        public bool Move()
        {
            int col = 7;
            int row = 7;
            Console.SetCursorPosition(col, row);    //Places the "*" before the loop    //In column 7, row 7
            Console.Write("*");
            Console.SetCursorPosition(col, row);
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.W)       //Compares the given info in ReadKey to the given ConsoleKey ("W")
                {
                    Console.Write(" ");
                    Debug.Print("W");
                    row--;
                }
                if (info.Key == ConsoleKey.S)
                {
                    Console.Write(" ");
                    Debug.Print("S");
                    row++;
                }

                if (info.Key == ConsoleKey.A)
                {
                    Console.Write(" ");
                    Debug.Print("A");
                    col--;
                }

                if (info.Key == ConsoleKey.D)
                {
                    Console.Write(" ");
                    Debug.Print("D");       //Writes a message followed by a line terminator to the trace listeners in the Listeners collection.
                    col++;
                }

                //Debug.Print & Console.Writeline
                //Debug writes the message to the Output > Debug. Console.WriteLine writes the message to the standard output (Console).

                Console.SetCursorPosition(col, row);    //Places the "*" after the loop
                Console.Write("*");
                Console.SetCursorPosition(col, row);
            }
        }
        public bool CheckWin()
        {
            return true;
        }
    }
}
