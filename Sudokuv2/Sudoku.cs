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
    class Sudoku
    {
        


        #region Chuẩn Bị
        #region Var
        //đếm số xuât hiện
        public static int[] NumTimes =
        {
            0,0,0,0,0,0,0,0,0
        };

        // số node còn null trong ô
        public static int[] NodesNull =
        {
            0,0,0,0,0,0,0,0,0
        };
        // tọ dộ từng ô
        public static List<Point> listBox = new List<Point>();
        //list ô bi block hay ko của Num
        //public static bool[] BoxNumBlock = new bool[9];
        // bool all true
        //public static bool[] Booltrue =
        //    {
        //    true, true, true, true, true, true,true, true, true
        //    };
        #endregion

        #region Sử lý chuẩn bị

        // dếm số xuất hiện và to màu
        public static void CountNum(List<List<TextBox>> Matrix)
        {

            for (int row = 0; row < Matrix.Count; row++)
            {
                for (int col = 0; col < Matrix[row].Count; col++)
                {
                    switch (Matrix[row][col].Text)
                    {
                        case "1":
                            NumTimes[0]++;
                            break;
                        case "2":
                            NumTimes[1]++;
                            break;
                        case "3":
                            NumTimes[2]++;
                            break;
                        case "4":
                            NumTimes[3]++;
                            break;
                        case "5":
                            NumTimes[4]++;
                            break;
                        case "6":
                            NumTimes[5]++;
                            break;
                        case "7":
                            NumTimes[6]++;
                            break;
                        case "8":
                            NumTimes[7]++;
                            break;
                        case "":
                            break;
                        default:
                            NumTimes[8]++;
                            break;
                    }
                }
            }
        }

        // tạo list tọa độ ô
        public static void CreateListBox()
        {
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    listBox.Add(new Point(i, j));
                }
            }
        }


        // Tạo NodesNull
        public static void LoadNodeNull(List<List<TextBox>> Matrix)
        {
            CreateListBox();
            for (int i = 0; i < NodesNull.Length; i++)
            {
                for (int row = listBox[i].X; row < listBox[i].X + 3; row++)
                {
                    for (int col = listBox[i].Y; col < listBox[i].Y + 3; col++)
                    {
                        if (Matrix[row][col].Text == "")
                        {
                            NodesNull[i]++;
                        }
                    }
                }
            }
        }

        #endregion

        // load du liệu cho sử lý chơi game
        public static void LoadPrepare(List<List<TextBox>> Matrix)
        {
            CountNum(Matrix);
            LoadNodeNull(Matrix);
        }

        #endregion


        //trả ại màu cho node
        public static void ReturnColor(List<List<TextBox>> Matrix)
        {
            for (int row = 0; row < Matrix.Count; row++)
            {
                for (int col = 0; col < Matrix[row].Count; col++)
                {
                    if (Matrix[row][col].BackColor == Color.Yellow)
                    {
                        Matrix[row][col].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        //Chọn số lượng số xuất hiện trong bản dô
        public static int LeverMap(ComboBox combo)
        {
            int lever;
            Random rd = new Random();
            switch (combo.Text)
            {
                case "Easy":
                    lever = 5;
                    break;
                case "Medium":
                    lever = 4;
                    break;
                default:
                    lever = 3;
                    break;
            }
            return lever;
        }

        #region Tạo Map Random


        public static void CreateBoard(List<List<TextBox>> Matrix, List<int[,]> DataBoard, int Lever)
        {
            int seed = DateTime.Now.Millisecond;
            int row, col, x, y;
            Random random = new Random();
            int NumBoard = random.Next(0, DataBoard.Count);
            int[,] board = DataBoard[NumBoard];
            do
            {
                x = random.Next(0, 3);
                y = random.Next(0, 3);
            } while (x == y);
            #region Xáo trộn board
            // đảo dòng lớn
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int val = board[x * 3 + i, j];
                    board[x * 3 + i, j] = board[y * 3 + i, j];
                    board[y * 3 + i, j] = val;
                }
            }
            //dao cot lớn
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int val = board[j, x * 3 + i];
                    board[j, x * 3 + i] = board[j, y * 3 + i];
                    board[j, y * 3 + i] = val;
                }
            }
            NumBoard = random.Next(0, 3);
            //dảo cột nhỏ
            for (int i = 0; i < 9; i++)
            {
                int val = board[i, NumBoard * 3 + x];
                board[i, NumBoard * 3 + x] = board[i, NumBoard * 3 + y];
                board[i, NumBoard * 3 + y] = val;
            }

            // đảo dòng nhỏ
            for (int i = 0; i < 9; i++)
            {
                int val = board[NumBoard * 3 + x, i];
                board[NumBoard * 3 + x, i] = board[NumBoard * 3 + y, i];
                board[NumBoard * 3 + y, i] = val;
            }

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Matrix[i][j].Text = board[i,j].ToString();
            //    }
            //}
            #endregion

            for (x = 0; x < 9; x += 3)
        {
            for (y = 0; y < 9; y += 3)
            {
            int TimesNode = random.Next(Lever, Lever + 2);
                for (int j = 0; j < TimesNode; j++)
                {
                    do
                    {
                       //tạo dọ độ random
                      row = random.Next(0, 3);
                      col = random.Next(0, 3);
                   } while (Matrix[x + row][y + col].Text != "");

                     Matrix[x + row][y + col].Text = board[x + row, y + col].ToString();
                     Matrix[x + row][y + col].ReadOnly = true;
                     Matrix[x + row][y + col].BackColor = Color.LightYellow;

                    }
                }
        }
        }

        #endregion

        #region sử lý với mảng

        #region biến Hỗ trợ

        public static List<int> RowBlock = new List<int>();

        public static List<int> ColBlock = new List<int>();

        public static List<Point> BoxBlock = new List<Point>();

        public static List<int> NumBlockFix = new List<int>();

        public static int XRowFix;

        public static int XColFix;



        #endregion

        // tô màu các toa dộ dòng cọ bị block
        public static void LoadBlockRCB(int[,] Board, int Num)
        {
            BoxBlock.Clear();
            RowBlock.Clear();
            ColBlock.Clear();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i,j] == Num)
                    {
                        RowBlock.Add(i);
                        ColBlock.Add(j);
                        BoxBlock.Add(new Point(HandleSudoku.NumStart(i), HandleSudoku.NumStart(j)));
                        
                    }
                }
            }
        }

        public static bool CheckInArrayBlock(List<int> ArrayBlock, int X)
        {
            for (int i = 0; i < ArrayBlock.Count; i++)
            {
                if (ArrayBlock[i] == X)
                {
                    return true;
                }
            }
            return false;
        }

        public static int[] CheckNull(int[,] Board, int Num, int RowStart, int ColStart)
        {
            int[] IntReturn = { 0, 0, 0 };

            for (int i = 0; i < BoxBlock.Count; i++)
            {
                if ((BoxBlock[i].X == RowStart) && (BoxBlock[i].Y == ColStart))
                {
                    return IntReturn;
                }
            }

            for (int i = RowStart; i < RowStart + 3; i++)
            {
                for (int j = ColStart; j < ColStart + 3; j++)
                {
                    if (true)
                    {

                    }
                    if ((Board[i,j] == 0) && !CheckInArrayBlock(RowBlock, i) && !CheckInArrayBlock(ColBlock, j))
                    {
                        IntReturn[0]++;
                        IntReturn[1] = i;
                        IntReturn[2] = j;
                    }
                }
            }

            return IntReturn;
        }

        public static void AddNumNodeNull(int row, int col)
        {
            NumBlockFix.Clear();
            int x = HandleSudoku.NumStart(row);
            int y = HandleSudoku.NumStart(col);
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y +3; j++)
                {
                    if (HandleSudoku.BoardCheck[i, j] != 0)
                    {
                        NumBlockFix.Add(HandleSudoku.BoardCheck[i, j]);
                    }
                }
            }
            int VNum = 0;
            do
            {
                Random random = new Random();
                VNum = random.Next(1, 10);
                for (int i = 0; i < NumBlockFix.Count; i++)
                {
                    if (NumBlockFix[i] == VNum)
                    {
                        VNum = 0;
                    }
                }
            } while (VNum == 0);

            NumBlockFix.Add(VNum);
            HandleSudoku.BoardCheck[row, col] = VNum;

        }

        #endregion

    }
}
    