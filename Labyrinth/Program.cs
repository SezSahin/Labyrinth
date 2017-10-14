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
                case "No":
                    break;
                case "no":
                    break;
                default:
                    throw new Exception();
            }
        }
        private void Labyrinth()
        {
            Labyrinth Lab = new Labyrinth();
            Lab.Move();
        }
    }
}
