using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class F_Menu : Form
    {
        
        public F_Menu()
        {
            InitializeComponent();
            Board.LoadBoard();
            CreateMap();
            bt_AutoPlay.Enabled = false;
            //test pugh
            bt_check.Enabled = false;
        }

        // tạo list chứa ma trận textbox
        private List<List<TextBox>> Matrix;
        public List<List<TextBox>> Matrix1 { get => Matrix; set => Matrix = value; }

        private void bt_strat_Click(object sender, EventArgs e)
        {
            int[,] NewBoard ={
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
            HandleSudoku.BoardCheck = NewBoard;
            if (cB_lever.Text == "Hard")
            {
                DialogResult result =  MessageBox.Show("CareFul. If AutoPlay run error. Please click New Game. I will fix it as soon as possible. Yes Countine. No, Choose lever Medium", "Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    cB_lever.Text = "Medium";
                }
            }
            Sudoku.CreateBoard(Matrix, Board.DataBoard, Sudoku.LeverMap(cB_lever));
            HandleSudoku.LoadbBoardCheck(Matrix);
            bt_NewGame.Enabled = false;
            bt_AutoPlay.Enabled = true;
            bt_Reset.Enabled = true;

        }

        private void CreateMap()  // tạo ô game
        {
            Matrix1 = new List<List<TextBox>>();

            for (int row = 0; row < GameMap.RowCount; row++)
            {
                Matrix1.Add(new List<TextBox>());

                for (int col = 0; col < GameMap.ColumnCount; col++)
                {
                    var textbox = new TextBox
                    {
                        Dock = DockStyle.Fill,
                        Font = new Font("Time New Roman", 14f, FontStyle.Bold),
                        MaxLength = 1,
                        BackColor = Color.White,
                        TextAlign = HorizontalAlignment.Center,
                        Tag = row.ToString()
                    };
                    textbox.KeyPress += textBox_KeyPress;
                    //textbox.Enter += textBox_Enter;
                    textbox.Leave += textBox_Leave;
                    GameMap.Controls.Add(textbox);
                    Matrix1[row].Add(textbox);
                    
                }
            }
            
        }
        #region TextBox

        // TextBox nhan data
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Back;
            }
            TextBox box = sender as TextBox;
            
            
            if (box.Text != "")
            {
                HandleSudoku.BoardCheck[Convert.ToInt32(box.Tag), Matrix[Convert.ToInt32(box.Tag)].IndexOf(box)] = Convert.ToInt32(box.Text);
                HandleSudoku.AddNumTimes(box.Text, HandleSudoku.NumTimes);
            }

        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (box.Text != "")
            {
                if (box.Text == "0")
                {
                    box.Text = "";
                }
                if (box.Text != "")
                {
                    HandleSudoku.BoardCheck[Convert.ToInt32(box.Tag), Matrix[Convert.ToInt32(box.Tag)].IndexOf(box)] = Convert.ToInt32(box.Text);
                    HandleSudoku.AddNumTimes(box.Text, HandleSudoku.NumTimes);
                }
                
            }
        }
        #region hàm bug dùng chưa ổn định
        //private void textBox_Enter(object sender, EventArgs e)
        //{
        //    TextBox box = sender as TextBox;
        //    if (box.Text != "")
        //    {
        //        Support(box, true, Convert.ToInt32(box.Text));
        //    }



        //}



        //// to6 mau cac tai box, to mau block
        //private void Support(TextBox box, bool VBool, int Num)
        //{
        //    Point point = HandleSudoku.GetBox(Matrix, box);
        //    int rowstart = HandleSudoku.NumStart(point.X);
        //    int colstart = HandleSudoku.NumStart(point.Y);
        //    for (int row = rowstart; row < rowstart + 3; row++)
        //    {
        //        for (int col = colstart; col < colstart + 3; col++)
        //        {
        //            if (VBool)
        //            {
        //                Matrix[row][col].BackColor = Color.Yellow;
        //            }
        //            else
        //            {
        //                if (Matrix[row][col].Text == "")
        //                {
        //                    Matrix[row][col].BackColor = Color.LightYellow;
        //                }
        //                else
        //                {
        //                    Matrix[row][col].BackColor = Color.White;
        //                }
        //            }

        //        }
        //    }

        //    for (int row = 0; row < 9; row++)
        //    {
        //        if (VBool)
        //        {
        //            Matrix[row][point.Y].BackColor = Color.Yellow;
        //        }
        //        else
        //        {
        //            if (Matrix[row][point.Y].Text == "")
        //            {
        //                Matrix[row][point.Y].BackColor = Color.LightYellow;
        //            }
        //            else
        //            {
        //                Matrix[row][point.Y].BackColor = Color.White;
        //            }
        //        }
        //    }

        //    for (int col = 0; col < 9; col++)
        //    {
        //        if (VBool)
        //        {
        //            Matrix[point.X][col].BackColor = Color.Yellow;
        //        }
        //        else
        //        {
        //            if (Matrix[point.X][col].Text == "")
        //            {
        //                Matrix[point.X][col].BackColor = Color.LightYellow;
        //            }
        //            else
        //            {
        //                Matrix[point.X][col].BackColor = Color.White;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            if (HandleSudoku.BoardCheck[i, j] == Num)
        //            {
        //                if (VBool)
        //                {
        //                    Matrix[i][j].BackColor = Color.Yellow;
        //                }
        //                else
        //                {
        //                    if (Matrix[i][j].Text == "")
        //                    {
        //                        Matrix[i][j].BackColor = Color.LightYellow;
        //                    }
        //                    else
        //                    {
        //                        Matrix[i][j].BackColor = Color.White;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion


        #endregion



        private void bt_AutoPlay_Click(object sender, EventArgs e)
        {
            bt_check.Enabled = true;
            
            int DK;
        BigAgain:
            do
            {
                DK = 0;
                for (int Num = 1; Num < 10; Num++)
                {
                LoadAgain:
                    Sudoku.LoadBlockRCB(HandleSudoku.BoardCheck, Num);
                    for (int row = 0; row < 9; row += 3)
                    {
                        for (int col = 0; col < 9; col += 3)
                        {
                            int[] ANum = Sudoku.CheckNull(HandleSudoku.BoardCheck, Num, row, col);
                            if (ANum[0] == 1)
                            {
                                DK++;
                                HandleSudoku.BoardCheck[ANum[1], ANum[2]] = Num;
                                Matrix[ANum[1]][ANum[2]].Text = Num.ToString();
                                goto LoadAgain;
                            }
                        }
                    }
                }
            } while (HandleSudoku.CheckNullInBoard() && DK != 0);
            if (HandleSudoku.CheckNullInBoard())
            {
                for (int i = 0; i < 9; i++)
                {
                    bool ValBreak = false;
                    for (int j = 0; j < 9; j++)
                    {
                        if (HandleSudoku.BoardCheck[i, j] == 0)
                        {
                            ValBreak = true;
                            Sudoku.XRowFix = i;
                            Sudoku.XColFix = j;
                            break;
                        }
                        if (ValBreak)
                        {
                            break;
                        }
                    }
                }
                Sudoku.AddNumNodeNull(Sudoku.XRowFix, Sudoku.XColFix);
                goto BigAgain;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Matrix[i][j].Text = HandleSudoku.BoardCheck[i, j].ToString();
                    Matrix[i][j].ReadOnly = false;
                }
            }
        }

            // Vẽ hình chia ô
            private void GameMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, GameMap.Width, GameMap.Height);
            e.Graphics.FillRectangle(Brushes.Black, 0, 0, GameMap.Width, 6);
            e.Graphics.FillRectangle(Brushes.Black, 0, 97, GameMap.Width, 6);
            e.Graphics.FillRectangle(Brushes.Black, 0, 197, GameMap.Width, 6);
            e.Graphics.FillRectangle(Brushes.Black, 0, 295, GameMap.Width, 6);

            e.Graphics.FillRectangle(Brushes.Black, 0, 0, 6, GameMap.Height);
            e.Graphics.FillRectangle(Brushes.Black, 195, 0, 6, GameMap.Height);
            e.Graphics.FillRectangle(Brushes.Black, 96, 0, 6, GameMap.Height);
            e.Graphics.FillRectangle(Brushes.Black, 295, 0, 6, GameMap.Height);
        }

        #region Vẽ Viền

        //private int PaintRow(TextBox box)
        //{
        //    int i = box.Location.Y + box.Size.Height;
        //    return i;
        //}


        #endregion

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            Matrix.Clear();
            GameMap.Controls.Clear();
            CreateMap();
            bt_NewGame.Enabled = true;
            bt_AutoPlay.Enabled = false;
            bt_check.Enabled = false;
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Matrix[i][j].Text = HandleSudoku.BoardCheck[i, j].ToString();
                    switch (HandleSudoku.BoardCheck[i, j])
                    {
                        case 1:
                            Matrix[i][j].BackColor = Color.LightGreen;
                            break;
                        case 2:
                            Matrix[i][j].BackColor = Color.LightGray;
                            break;
                        case 3:
                            Matrix[i][j].BackColor = Color.LightBlue;
                            break;
                        case 4:
                            Matrix[i][j].BackColor = Color.LightCyan;
                            break;
                        case 5:
                            Matrix[i][j].BackColor = Color.LightSkyBlue;
                            break;
                        case 6:
                            Matrix[i][j].BackColor = Color.GreenYellow;
                            break;
                        case 7:
                            Matrix[i][j].BackColor = Color.Gold;
                            break;
                        case 8:
                            Matrix[i][j].BackColor = Color.LightPink;
                            break;
                        default:
                            break;
                    }
                }
            }
            MessageBox.Show("Success!!!!!!!!!");
        }

        private void bt_Input_Click(object sender, EventArgs e)
        {
            int[,] NewBoard ={
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
            HandleSudoku.BoardCheck = NewBoard;
            bt_AutoPlay.Enabled = true;
            bt_NewGame.Enabled = false;
            
        }
    }
}
