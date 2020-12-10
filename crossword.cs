using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matesha228
{
    public partial class crossword : Form
    {
        public string [] w = { "", "Геометрия", "Фрактал", "Статистика", "Гипербола", "Теорема", "Факториал", "Интеграл", "Асимптота", "Проекция", "Аксиома" };
        public int[] nb = {0, 2, 0, 2, 2, 0, 4, 3, 3, 1, 5 }; 
        public crossword()
        {
            InitializeComponent();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void crossword_Load(object sender, EventArgs e)
        {
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            board.BackgroundColor = Color.Gray;
            board.DefaultCellStyle.BackColor = Color.Gray;
            for(int i = 0; i< 12; i++)
            {
                board.Rows.Add();
            }
            foreach (DataGridViewColumn c in board.Columns)
            {
                c.Width = board.Width / board.Columns.Count;
            }
            for (int r = 0; r < board.Rows.Count; r++)
            {
                for (int c = 0; c < board.Columns.Count; c++)
                {
                    board[c, r].ReadOnly = true;
                }


            for (int co = 0; co < 11; co++)
            {
            for(int i = 0; i < w[co].Length; i++)
                    {
                        forcell(i + nb[co],co, " ");
                    }
            }
            for (int a = 1; a < 11; a++)
                {
                    forcell0(6, a, "");
                }
            }
        }

        private void forcell(int r, int c, string letter)
        {
            DataGridViewCell s = board[c, r];
            s.Style.BackColor = Color.White;
            s.ReadOnly = false;
            s.Style.SelectionBackColor = Color.AntiqueWhite;
            s.Tag = letter;
        }
        private void forcell0(int r, int c, string letter)
        {
            DataGridViewCell s = board[c, r];
            s.Style.BackColor = Color.Lavender;
            s.ReadOnly = false;
            s.Style.SelectionBackColor = Color.PaleVioletRed;
            s.Tag = letter;
        }

        private void board_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
     public class idcells
    {
        public int x, y;
        public string num;
        public string word;

        public idcells (int x, int y, string n, string w)
        {
            this.x = x;
            this.y = y;
            this.num = n;
            this.word = w;

        }
    }
}
