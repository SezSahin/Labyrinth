﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Extra
    {
        //public string Draw()
        //{
        //    string resultat = "";
        //    resultat = resultat + "Y\n";
        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[0, 0] + "  -" + Board[0, 1] + "    -" + Board[0, 2] + "    -" + Board[0, 3] + "   -" + Board[0, 4] + "    -" + Board[0, 5] + "    -" + Board[0, 6] + "   -" + Board[0, 7] + "    -" + Board[0, 8] + "    -" + Board[0, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[1, 0] + "  -" + Board[1, 1] + "    -" + Board[1, 2] + "    -" + Board[1, 3] + "   -" + Board[1, 4] + "    -" + Board[1, 5] + "    -" + Board[1, 6] + "   -" + Board[1, 7] + "    -" + Board[1, 8] + "    -" + Board[1, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[2, 0] + "  -" + Board[2, 1] + "    -" + Board[2, 2] + "    -" + Board[2, 3] + "   -" + Board[2, 4] + "    -" + Board[2, 5] + "    -" + Board[2, 6] + "   -" + Board[2, 7] + "    -" + Board[2, 8] + "    -" + Board[2, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[3, 0] + "  -" + Board[3, 1] + "    -" + Board[3, 2] + "    -" + Board[3, 3] + "   -" + Board[3, 4] + "    -" + Board[3, 5] + "    -" + Board[3, 6] + "   -" + Board[3, 7] + "    -" + Board[3, 8] + "    -" + Board[3, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[4, 0] + "  -" + Board[4, 1] + "    -" + Board[4, 2] + "    -" + Board[4, 3] + "   -" + Board[4, 4] + "    -" + Board[4, 5] + "    -" + Board[4, 6] + "   -" + Board[4, 7] + "    -" + Board[4, 8] + "    -" + Board[4, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[5, 0] + "  -" + Board[5, 1] + "    -" + Board[5, 2] + "    -" + Board[5, 3] + "   -" + Board[5, 4] + "    -" + Board[5, 5] + "    -" + Board[5, 6] + "   -" + Board[5, 7] + "    -" + Board[5, 8] + "    -" + Board[5, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[6, 0] + "  -" + Board[6, 1] + "    -" + Board[6, 2] + "    -" + Board[6, 3] + "   -" + Board[6, 4] + "    -" + Board[6, 5] + "    -" + Board[6, 6] + "   -" + Board[6, 7] + "    -" + Board[6, 8] + "    -" + Board[6, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[7, 0] + "  -" + Board[7, 1] + "    -" + Board[7, 2] + "    -" + Board[7, 3] + "   -" + Board[7, 4] + "    -" + Board[7, 5] + "    -" + Board[7, 6] + "   -" + Board[7, 7] + "    -" + Board[7, 8] + "    -" + Board[7, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[8, 0] + "  |" + Board[8, 1] + "    |" + Board[8, 2] + "    |" + Board[8, 3] + "   |" + Board[8, 4] + "    |" + Board[8, 5] + "    |" + Board[8, 6] + "   |" + Board[8, 7] + "    |" + Board[8, 8] + "    |" + Board[8, 9] + "   |\n";

        //    resultat = resultat + "  *********************************************************\n";

        //    resultat = resultat + " | " + Board[9, 0] + "  |" + Board[9, 1] + "    |" + Board[9, 2] + "    |" + Board[9, 3] + "   |" + Board[9, 4] + "    |" + Board[9, 5] + "    |" + Board[9, 6] + "   |" + Board[9, 7] + "    |" + Board[9, 8] + "    |" + Board[9, 9] + "   |\n";

        //    resultat = resultat + "     1     2     3    4    5     6     7    8     9     10 \n";

        //    return resultat;

        //    //foreach(char c in resultat)
        //    //{
        //    //    Console.Write(c);
        //    //    Thread.Sleep(70);
        //    //}
        //}


        //public void GetBoardView()
        //{

        //    //To indicate up or down movement |
        //    //To indicate right or left movement -

        //    Board = new char[10, 10]
        //    {
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        //        {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}
        //    };
        //    Console.WriteLine(Board);
        //    Thread.Sleep(70);
        //}


        //public bool CheckWin()
        //{
        //    foreach(char fin in Board)
        //    {
        //        if (fin == '!') return false;
        //    }
        //    return true;
        //}



    }
}
