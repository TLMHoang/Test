﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class Board
    {
            #region board

            private static int[,] board1 =
            {
                {5,4,9,8,2,7,6,3,1},
                {8,3,1,6,4,9,2,7,5},
                {6,7,2,5,3,1,9,4,8 },
                {1,5,7,4,9,6,8,2,3},
                {2,8,4,7,5,3,1,6,9},
                {3,9,6,2,1,8,7,5,4},
                {4,1,5,9,6,2,3,8,7},
                {9,2,8,3,7,4,5,1,6},
                {7,6,3,1,8,5,4,9,2 }
            };
            private static int[,] board2 =
            {
                {8,2,7,6,3,1,9,4,5 },
                {5,3,1,9,4,8,2,7,6 },
                {6,4,9,2,7,5,1,3,8 },
                {4,9,6,8,2,3,7,5,1 },
                {2,1,8,7,5,4,6,9,3 },
                {7,5,3,1,6,9,4,8,2 },
                {9,6,2,3,8,7,5,1,4 },
                {1,8,5,4,9,2,3,6,7 },
                {3,7,4,5,1,6,8,2,9 }
            };

            private static int[,] board3 =
            {
                {8,7,1,2,9,6,3,4,5 },
                {3,4,9,5,8,1,7,2,6 },
                {2,5,6,7,4,3,8,9,1 },
                {1,3,2,8,6,5,4,7,9 },
                {7,6,4,1,2,9,5,3,8 },
                {5,9,8,3,7,4,1,6,2 },
                {4,2,7,6,5,8,9,1,3 },
                {9,1,5,4,3,2,6,8,7 },
                {6,8,3,9,1,7,2,5,4 },
            };

            private static int[,] board4 =
            {
                {6,8,5,7,4,9,1,3,2 },
                {7,3,4,6,1,2,5,9,8 },
                {2,1,9,3,5,8,7,6,4 },
                {5,6,8,1,9,3,4,2,7 },
                {3,4,2,8,6,7,9,1,5 },
                {1,9,7,5,2,4,6,8,3 },
                {8,5,1,2,7,6,3,4,9 },
                {9,2,6,4,3,5,8,7,1 },
                {4,7,3,9,8,1,2,5,6 },
            };

            private static int[,] board5 =
            {
                {9,1,7,5,4,2,6,8,3},
                {4,3,2,8,7,6,9,1,5},
                {6,5,8,1,3,9,4,2,7},
                {2,9,6,4,5,3,8,7,1},
                {5,8,1,2,6,7,3,4,9},
                {7,4,3,9,1,8,2,5,6},
                {8,6,5,7,9,4,1,3,2},
                {3,7,4,6,2,1,5,9,8},
                {1,2,9,3,8,5,7,6,4},
            };

            public static List<int[,]> DataBoard = new List<int[,]>();

            #endregion


        public static void LoadBoard()
        {
            DataBoard.Add(board1);
            DataBoard.Add(board2);
            DataBoard.Add(board3);
            DataBoard.Add(board4);
            DataBoard.Add(board5);
        }

    }
}
