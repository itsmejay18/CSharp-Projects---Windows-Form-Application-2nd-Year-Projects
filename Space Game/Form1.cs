using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWar
{
    public partial class Form1 : Form
    {
        PictureBox [] stars;
        int backgroundSpeed;
        int playerSpeed;

        PictureBox[] Mutation;
        int mutationSpeed;

        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundSpeed  = 4;
            playerSpeed = 4;

            mutationSpeed = 20;
            Mutation = new PictureBox[3];
            
            stars = new PictureBox[10];
            random = new Random();

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(random.Next(20, 500), random.Next(-10, 400));

                if (1 % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.White;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }
            
        }

        private void MoveBackGround_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length/2; i++)
            {
                stars[i].Top += backgroundSpeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length/2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundSpeed - 2 ;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
        }

        private void RigthMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Right < 580)
            {
                player.Left += playerSpeed;
            }
        }

        private void UpMoveTImer_Tick(object sender, EventArgs e)
        {
            if (player.Top > 10)
            {
                player.Top -= playerSpeed;  
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top < 400)
            {
                player.Top += playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RigthMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                LeftMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                UpMoveTImer.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                DownMoveTimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           RigthMoveTimer.Stop();
            LeftMoveTimer.Stop() ;
            UpMoveTImer.Stop();
            DownMoveTimer.Stop();
        }
    }
}
