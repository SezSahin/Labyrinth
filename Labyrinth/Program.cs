using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Program
    {

        static void Main(string[] args)
        {
            //int a;
            //Console.WriteLine("Enter size of index:");
            //a = int.Parse(Console.ReadLine());
            //int[] index = new int[a];
            //Console.WriteLine("-");
            //for (int i = 0; i < index.Length; i++)
            //{
            //    Console.WriteLine(index[i]);
            //}
            //Console.WriteLine("-");
            //// The user is entering the numbers (code copied from your question).
            //for (int i = 0; i < index.Length; i++)
            //{
            //    Console.WriteLine("Enter number: ");
            //    index[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("-");
            //}

            //// Now display the numbers entered.
            //for (int i = 0; i < index.Length; i++)
            //{
            //    Console.WriteLine(index[i]);
            //}

            //// Finally, search for the element and display where it is.
            //int elementToSearchFor;
            //if (int.TryParse(Console.ReadLine(), out elementToSearchFor))
            //{
            //    Console.WriteLine(elementToSearchFor);
            //    Console.WriteLine("-");
            //}

            Console.Clear();
            Program myProgram = new Program();
            Console.WriteLine("Welcome to Labyrinth  \n\nDo you wish to play?  ");
            Thread.Sleep(70);
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "Yes":
                    myProgram.Labyrinth();
                    break;
                case "yes":
                    myProgram.Labyrinth();
                    break;
                case "y":
                    myProgram.Labyrinth();
                    break;
                case "No":
                    break;
                case "no":
                    break;
                case "n":
                    break;
                default:
                    throw new Exception();
            }
        }
        private void Labyrinth()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Escape!");
            Console.ForegroundColor = ConsoleColor.White;
            Labyrinth Lab = new Labyrinth();
            Maze Mz = new Maze();
            // LUAN !!!     Fix det plz :(
            Maze.Generator();
            Lab.Move();

            while(Console.ReadKey().Key == ConsoleKey.Backspace)
            {
                break;
            }
        }
    }
}
