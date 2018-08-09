using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player
{
    public partial class Form1 : Form
    {
        private Random rn = new Random();
        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        int jumpSpeed =20;
        int force =5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        

        private void Initialize()
        {
            board.Backgroundcolor = Color.Black;
            board.DefaultCellStyle.BlackColor = Color.Black;

            for (int i = 0; i < 25; i++)
                board.Rows.Add();

            foreach (DataGridViewColumn c in board.Colums)
                c.Width = board.Width / board.Columns.Count;

            foreach (DataGridViewRow r in board.Rows)
                r.Height = board.Height / board.Rows.Count;

                        
        }
  

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Color randomColor = Color.FromArgb(rn.Next(256), rn.Next(256), rn.Next(256));
            BackColor = randomColor;
        }

        //player is created with a rectagle box in the form. This player is given actions to each cell in the grid which is filled with random colors
        

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        
        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }

        }

       player.Top +=jumpSpeed;

       if (jumping && force<0)
       {
        jumping = false;
       }
        if(goleft)
        {
            player.Left -= 5;
        }
        if(goright)
{
    player.Left += 5;
}
    if(jumping)
{
    jumpSpeed = -12;
    force -=1;
}
    else
{
    jumpSpeed =12;
}

    
}
      