using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using static Labyrinth.Extensions;

namespace Labyrinth
{
        public enum CellState
        {
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8,
            Visited = 128,
            Initial = Top | Right | Bottom | Left,
        }
        public struct RemoveWallAction
        {
            public Point Neighbour;
            public CellState Wall;
        }

        public class Maze
        {
            public bool currentPlayer = true;

            public char[,] Board;

            public string Name;

            int Rows;
            int Columns;
            int cellWidth;
            int cellHeight;
            private CellState[,] cells;
            private Random _rng;

            internal void Generator(int width, int height)
            {
                cellWidth = width;
                cellHeight = height;
                cells = new CellState[width, height];
                for (var x = 0; x < cellWidth; x++)
                    for (var y = 0; y < cellHeight; y++)
                        cells[x, y] = CellState.Initial;
                _rng = new Random();
                VisitCell(_rng.Next(width), _rng.Next(height));
            }
            public CellState this[int x, int y]
            {
                get { return cells[x, y]; }
                set { cells[x, y] = value; }
            }

            public IEnumerable<RemoveWallAction> GetNeighbours(Point p)
            {
                if (p.X > 0) yield return new RemoveWallAction { Neighbour = new Point(p.X - 1, p.Y), Wall = CellState.Left };
                if (p.Y > 0) yield return new RemoveWallAction { Neighbour = new Point(p.X, p.Y - 1), Wall = CellState.Top };
                if (p.X < cellWidth - 1) yield return new RemoveWallAction { Neighbour = new Point(p.X + 1, p.Y), Wall = CellState.Right };
                if (p.Y < cellHeight - 1) yield return new RemoveWallAction { Neighbour = new Point(p.X, p.Y + 1), Wall = CellState.Bottom };
            }

            public void VisitCell(int x, int y)
            {
                this[x, y] |= CellState.Visited;
                foreach (var p in GetNeighbours(new Point(x, y)).Shuffle(_rng).Where(z => !(this[z.Neighbour.X, z.Neighbour.Y].HasFlag(CellState.Visited))))
                {
                    this[x, y] -= p.Wall;
                    this[p.Neighbour.X, p.Neighbour.Y] -= p.Wall.OppositeWall();
                    VisitCell(p.Neighbour.X, p.Neighbour.Y);
                }
            }

            public void Display()
            {
                var firstLine = string.Empty;
                for (var y = 0; y < cellHeight; y++)
                {
                    var sbTop = new StringBuilder();
                    var sbMid = new StringBuilder();
                    for (var x = 0; x < cellWidth; x++)
                    {
                        sbTop.Append(this[x, y].HasFlag(CellState.Top) ? "+--" : "+  ");
                        sbMid.Append(this[x, y].HasFlag(CellState.Left) ? "|  " : "   ");
                    }
                    if (firstLine == string.Empty)
                        firstLine = sbTop.ToString();
                    Debug.WriteLine(sbTop + "+");
                    Debug.WriteLine(sbMid + "|");
                    Debug.WriteLine(sbMid + "|");
                }
                Debug.WriteLine(firstLine);
            }
        }

    public class Labyrinth //: ILabyrinth
    {
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
    }
}
