namespace matesha228
{
    partial class crossword
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crossword));
            this.yt_Button1 = new KidFormApp.yt_Button();
            this.board = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESERVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.AliceBlue;
            this.yt_Button1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button1.ForeColor = System.Drawing.Color.Black;
            this.yt_Button1.Location = new System.Drawing.Point(1070, 7);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Rounding = 100;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(116, 57);
            this.yt_Button1.TabIndex = 0;
            this.yt_Button1.Text = "В меню";
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // board
            // 
            this.board.AllowUserToDeleteRows = false;
            this.board.AllowUserToResizeColumns = false;
            this.board.AllowUserToResizeRows = false;
            this.board.ColumnHeadersHeight = 29;
            this.board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.board.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5,
            this.C6,
            this.C7,
            this.C8,
            this.C9,
            this.C10,
            this.C11,
            this.C12,
            this.RESERVE});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.board.DefaultCellStyle = dataGridViewCellStyle1;
            this.board.Location = new System.Drawing.Point(258, 75);
            this.board.Name = "board";
            this.board.RowHeadersWidth = 51;
            this.board.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.board.RowTemplate.Height = 24;
            this.board.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.board.Size = new System.Drawing.Size(928, 421);
            this.board.TabIndex = 1;
            this.board.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.board_CellContentClick);
            // 
            // C1
            // 
            this.C1.HeaderText = "C1";
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.Width = 71;
            // 
            // C2
            // 
            this.C2.HeaderText = "C2";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 71;
            // 
            // C3
            // 
            this.C3.HeaderText = "C3";
            this.C3.MinimumWidth = 6;
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Width = 71;
            // 
            // C4
            // 
            this.C4.HeaderText = "C4";
            this.C4.MinimumWidth = 6;
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Width = 71;
            // 
            // C5
            // 
            this.C5.HeaderText = "C5";
            this.C5.MinimumWidth = 6;
            this.C5.Name = "C5";
            this.C5.ReadOnly = true;
            this.C5.Width = 71;
            // 
            // C6
            // 
            this.C6.HeaderText = "C6";
            this.C6.MinimumWidth = 6;
            this.C6.Name = "C6";
            this.C6.ReadOnly = true;
            this.C6.Width = 71;
            // 
            // C7
            // 
            this.C7.HeaderText = "C7";
            this.C7.MinimumWidth = 6;
            this.C7.Name = "C7";
            this.C7.ReadOnly = true;
            this.C7.Width = 71;
            // 
            // C8
            // 
            this.C8.HeaderText = "C8";
            this.C8.MinimumWidth = 6;
            this.C8.Name = "C8";
            this.C8.ReadOnly = true;
            this.C8.Width = 71;
            // 
            // C9
            // 
            this.C9.HeaderText = "C9";
            this.C9.MinimumWidth = 6;
            this.C9.Name = "C9";
            this.C9.ReadOnly = true;
            this.C9.Width = 71;
            // 
            // C10
            // 
            this.C10.HeaderText = "C10";
            this.C10.MinimumWidth = 6;
            this.C10.Name = "C10";
            this.C10.ReadOnly = true;
            this.C10.Width = 71;
            // 
            // C11
            // 
            this.C11.HeaderText = "C11";
            this.C11.MinimumWidth = 6;
            this.C11.Name = "C11";
            this.C11.ReadOnly = true;
            this.C11.Width = 71;
            // 
            // C12
            // 
            this.C12.HeaderText = "C12";
            this.C12.MinimumWidth = 6;
            this.C12.Name = "C12";
            this.C12.ReadOnly = true;
            this.C12.Width = 71;
            // 
            // RESERVE
            // 
            this.RESERVE.HeaderText = "";
            this.RESERVE.MinimumWidth = 6;
            this.RESERVE.Name = "RESERVE";
            this.RESERVE.ReadOnly = true;
            this.RESERVE.Width = 22;
            // 
            // crossword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.board);
            this.Controls.Add(this.yt_Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "crossword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crossword";
            this.Load += new System.EventHandler(this.crossword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KidFormApp.yt_Button yt_Button1;
        private System.Windows.Forms.DataGridView board;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C5;
        private System.Windows.Forms.DataGridViewTextBoxColumn C6;
        private System.Windows.Forms.DataGridViewTextBoxColumn C7;
        private System.Windows.Forms.DataGridViewTextBoxColumn C8;
        private System.Windows.Forms.DataGridViewTextBoxColumn C9;
        private System.Windows.Forms.DataGridViewTextBoxColumn C10;
        private System.Windows.Forms.DataGridViewTextBoxColumn C11;
        private System.Windows.Forms.DataGridViewTextBoxColumn C12;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVE;
    }
}