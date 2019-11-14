using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
      class HandleSudoku
    {

        public static int[,] BoardCheck =
         {
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0,0 },
        };

        public static int[] NumTimes =
        {
            0,0,0,0,0,0,0,0,0
        };

        public static void LoadNumTimes()
        {
            int[] ValA = {
            0,0,0,0,0,0,0,0,0
            };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    switch (BoardCheck[i,j])
                    {
                        case 1:
                            ValA[0]++;
                            break;
                        case 2:
                            ValA[1]++;
                            break;
                        case 3:
                            ValA[2]++;
                            break;
                        case 4:
                            ValA[3]++;
                            break;
                        case 5:
                            ValA[4]++;
                            break;
                        case 6:
                            ValA[5]++;
                            break;
                        case 7:
                            ValA[6]++;
                            break;
                        case 8:
                            ValA[7]++;
                            break;
                        default:
                            ValA[8]++;
                            break;
                    }
                }
            }
            NumTimes = ValA;
        }

        public static void AddNumTimes(string Vstring, int[] Num)
        {
            switch (Vstring)
            {
                case "1":
                    Num[0]++;
                    break;
                case "2":
                    Num[1]++;
                    break;
                case "3":
                    Num[2]++;
                    break;
                case "4":
                    Num[3]++;
                    break;
                case "5":
                    Num[4]++;
                    break;
                case "6":
                    Num[5]++;
                    break;
                case "7":
                    Num[6]++;
                    break;
                case "8":
                    Num[7]++;
                    break;
                case "":
                    break;
                default:
                    Num[8]++;
                    break;
            }
        }

        public static void LoadbBoardCheck(List<List<TextBox>> Matrix)
        {
            for (int row = 0; row < Matrix.Count; row++)
            {
                for (int col = 0; col < Matrix[row].Count; col++)
                {
                    if (Matrix[row][col].Text != "")
                    {
                        BoardCheck[row, col] = Convert.ToInt32(Matrix[row][col].Text);
                        AddNumTimes(Matrix[row][col].Text, NumTimes);
                    } 
                }
            }
        }

        

        // lấy toa do box
        public static Point GetBox(List<List<TextBox>> Matrix, TextBox box)
        {


            int row = Convert.ToInt32(box.Tag);
            int col = Matrix[row].IndexOf(box);

            Point point = new Point(row, col);
            return point;
        }



        //Đưa ra diểm bắt đầu của hàng or cột
        public static int NumStart(int val)
        {
            int num;
            if ((val >= 0) && (val <= 2))
            {
                num = 0;
            }
            else
            {
                if ((val >= 3) && (val <= 5))
                {
                    num = 3;
                }
                else
                {
                    num = 6;
                }
            }
            return num;
        }

        public static bool CheckNullInBoard()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (BoardCheck[row,col] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        //public static bool CheckWin()
        //{
        //    if (CheckNullInBoard())
        //    {
        //        return false;
        //    }
        //    LoadNumTimes();
        //    for (int i = 0; i < NumTimes.Length; i++)
        //    {
        //        if (NumTimes[i] != 9)
        //        {
        //            return false;
        //        }
        //    }
        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            for (int x = 0; x < 9; x++)
        //            {
        //                if (x != j)
        //                {
        //                    if (BoardCheck[i,j] == BoardCheck[i,x])
        //                    {
        //                        return false;
        //                    }
        //                }
        //            }

        //            for (int x = 0; x < 9; x++)
        //            {
        //                if (x != j)
        //                {
        //                    if (BoardCheck[i, j] == BoardCheck[x,j])
        //                    {
        //                        return false;
        //                    }
        //                }
        //            }

        //            for (int x = NumStart(i); x < NumStart(i) + 3; x++)
        //            {
        //                for (int y = NumStart(j); y < NumStart(j) + 3; y++)
        //                {
        //                    if ((x != i) && (y != j))
        //                    {
        //                        if (BoardCheck[x, y] == BoardCheck[i, j])
        //                        {
        //                            return false;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
