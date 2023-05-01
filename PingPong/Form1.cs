using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        private int horSpeed = 2, vertSpeed = 2;
        private byte platformSpeed = 5;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            losePanel.Left = (panel.Width / 2) - (losePanel.Width / 2);
            losePanel.Top = (panel.Height / 2) - (losePanel.Height / 2);
            losePanel.Visible = false;
            timer.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            gamePanel.Top = panel.Bottom - (panel.Bottom / 10);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            int panelBottom = panel.Bottom - (panel.Bottom / 10);
            if (e.KeyCode == Keys.W && gamePanel.Top > panel.Top)
                gamePanel.Top -= platformSpeed;
            if (e.KeyCode == Keys.S && gamePanel.Bottom < panelBottom)
                gamePanel.Top += platformSpeed;
            if (e.KeyCode == Keys.A && gamePanel.Left >= panel.Left)
                gamePanel.Left -= platformSpeed;
            if (e.KeyCode == Keys.D && gamePanel.Right <= panel.Right)
                gamePanel.Left += platformSpeed;

            if (e.KeyCode == Keys.R)
            {
                losePanel.Visible = false;
                score = 0;
                result.Text = "Результат: 0";
                horSpeed = 2;
                vertSpeed = 2;
                platformSpeed = 5;
                gameBall.Left = 50;
                gameBall.Top = 70;
                gamePanel.Left = 100;
                gamePanel.Top = panel.Bottom - (panel.Bottom / 10);
                timer.Enabled = true;
            }

            if (e.KeyCode == Keys.G && gamePanel.Visible)
            {
                timer.Enabled = false;
                gamePanel.Visible = false;
                gameBall.Visible = false;
            }
            if (e.KeyCode==Keys.P && !gamePanel.Visible)
            {
                timer.Enabled = true;
                gamePanel.Visible = true;
                gameBall.Visible = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);

            gameBall.Left += horSpeed;
            gameBall.Top += vertSpeed;

            if (gameBall.Left <= panel.Left)
                horSpeed *= -1;
            if (gameBall.Right >= panel.Right)
                horSpeed *= -1;
            if (gameBall.Top <= panel.Top)
                vertSpeed *= -1;
            if (gameBall.Bottom >= panel.Bottom)
            {
                timer.Enabled = false;
                losePanel.Visible = true;
            }
            if (gameBall.Bottom >= gamePanel.Top && gameBall.Bottom <= gamePanel.Bottom &&
                gameBall.Left >= gamePanel.Left && gameBall.Right <= gamePanel.Right)
            {
                Random randColor = new Random();
                panel.BackColor = Color.FromArgb(randColor.Next(150, 255), randColor.Next(150, 255), randColor.Next(150, 255));
                vertSpeed += 2;
                horSpeed += 2;
                vertSpeed *= -1;
                platformSpeed += 2;
                score++;
                result.Text = "Результат: " + score.ToString();
            }



        }
    }
}
