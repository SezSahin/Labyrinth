﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public interface ILabyrinth
    {
        string GetBoardView();
        bool Move();
        bool CheckWin();
        void Generator(int width, int height);
    }
}
