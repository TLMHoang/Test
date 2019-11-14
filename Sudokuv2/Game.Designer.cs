namespace Sudoku
{
    partial class F_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameMap = new System.Windows.Forms.TableLayoutPanel();
            this.bt_NewGame = new System.Windows.Forms.Button();
            this.cB_lever = new System.Windows.Forms.ComboBox();
            this.bt_AutoPlay = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_check = new System.Windows.Forms.Button();
            this.bt_Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameMap
            // 
            this.GameMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameMap.ColumnCount = 9;
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.Location = new System.Drawing.Point(12, 12);
            this.GameMap.Name = "GameMap";
            this.GameMap.RowCount = 9;
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.GameMap.Size = new System.Drawing.Size(300, 300);
            this.GameMap.TabIndex = 0;
            this.GameMap.Paint += new System.Windows.Forms.PaintEventHandler(this.GameMap_Paint);
            // 
            // bt_NewGame
            // 
            this.bt_NewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_NewGame.Location = new System.Drawing.Point(162, 342);
            this.bt_NewGame.Name = "bt_NewGame";
            this.bt_NewGame.Size = new System.Drawing.Size(75, 23);
            this.bt_NewGame.TabIndex = 1;
            this.bt_NewGame.Text = "New Game";
            this.bt_NewGame.UseVisualStyleBackColor = true;
            this.bt_NewGame.Click += new System.EventHandler(this.bt_strat_Click);
            // 
            // cB_lever
            // 
            this.cB_lever.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_lever.FormattingEnabled = true;
            this.cB_lever.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cB_lever.Location = new System.Drawing.Point(12, 344);
            this.cB_lever.Name = "cB_lever";
            this.cB_lever.Size = new System.Drawing.Size(63, 21);
            this.cB_lever.TabIndex = 2;
            this.cB_lever.Text = "Easy";
            // 
            // bt_AutoPlay
            // 
            this.bt_AutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_AutoPlay.Location = new System.Drawing.Point(243, 342);
            this.bt_AutoPlay.Name = "bt_AutoPlay";
            this.bt_AutoPlay.Size = new System.Drawing.Size(75, 23);
            this.bt_AutoPlay.TabIndex = 4;
            this.bt_AutoPlay.Text = "AutoPlay";
            this.bt_AutoPlay.UseVisualStyleBackColor = true;
            this.bt_AutoPlay.Click += new System.EventHandler(this.bt_AutoPlay_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Reset.Location = new System.Drawing.Point(81, 342);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(75, 23);
            this.bt_Reset.TabIndex = 5;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minh Hoàng FS";
            // 
            // bt_check
            // 
            this.bt_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_check.Location = new System.Drawing.Point(12, 381);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(75, 23);
            this.bt_check.TabIndex = 7;
            this.bt_check.Text = "Check";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // bt_Input
            // 
            this.bt_Input.Location = new System.Drawing.Point(120, 381);
            this.bt_Input.Name = "bt_Input";
            this.bt_Input.Size = new System.Drawing.Size(75, 23);
            this.bt_Input.TabIndex = 8;
            this.bt_Input.Text = "Input";
            this.bt_Input.UseVisualStyleBackColor = true;
            this.bt_Input.Click += new System.EventHandler(this.bt_Input_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 413);
            this.Controls.Add(this.bt_Input);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.bt_AutoPlay);
            this.Controls.Add(this.cB_lever);
            this.Controls.Add(this.bt_NewGame);
            this.Controls.Add(this.GameMap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GameMap;
        private System.Windows.Forms.Button bt_NewGame;
        private System.Windows.Forms.ComboBox cB_lever;
        private System.Windows.Forms.Button bt_AutoPlay;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Button bt_Input;
    }
}

