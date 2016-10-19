/// Created By:
/// 
/// January 21 2014
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class theUltimateArcade : Form
    {
        int gameValue = 2;
        int gameValueHist = 2;
        int pcBox1X = 190;
        int pcBox1Y = 25;
        int pcBox1W = 160;
        int pcBox1H = 112;

        int pcBox2X = 290;
        int pcBox2Y = 45;
        int pcBox3X = 490;
        int pcBox3Y = 25;
        bool rightPress = false;
        bool leftPress = false;
        //commit test
        /*if (gameValue == 1)
            {
                snakeButton.Width = 192;
                pongButton.Width = 0;
                pacmanButton.Width = 0;
                title.Text = "Snake";
                description.Text = Resources.resx/snakeDesc
            }
            if (gameValue == 2)
            {
                snakeButton.Width = 0;
                pongButton.Width = 192;
                pacmanButton.Width = 0;
                title.Text = "Pong";
                description.Text = Resources.resx/pongDesc
                if (gameValue = gameValueHist - 1)
                {
                    for(int a = 0; a < 100; a++)
                    {
                        if (a%25 == 0)
                        {
                            pcBox1Y = pcBox1Y + 5;
                            pcBox2y = pcBox2y - 5;
                        }
                        pcBox1X++;
                        pcBox2X = pcBox2X + 2;
                        pcBox3X = pcBox3X - 3;
                        
                        picturebox1.Location = pcBox1X, pcBox1Y;
                        picturebox2.Location = pcBox2X, pcBox2Y;
                        picturebox3.Location = pcBox3X, pcBox3Y;
                    }
                }
            }
            if (gameValue == 3)
            {
                snakeButton.Width = 0;
                pongButton.Width = 0;
                pacmanButton.Width = 192;
                title.Text = "Pacman";
                description.Text = Resources.resx/pakmanDesc
            }*/
        public theUltimateArcade()
        {
            InitializeComponent();           
        }
        private void theUltimateArcade_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    gameValueHist = gameValue;
                    gameValue++;
                    break;
                case Keys.Right:
                    gameValueHist = gameValue;
                    gameValue--;
                    break;
                default:
                    rightPress = false;
                    leftPress = false;
                    break;
            }

           
            
            Refresh();
        }
        private void snakeButton_Click(object sender, EventArgs e)
        {
            Process.Start("Snake Game.exe");
        }

        private void pongButton_Click(object sender, EventArgs e)
        {
            Process.Start("Pong.exe");
        }

        private void pacmanButton_Click(object sender, EventArgs e)
        {
            Process.Start("AnimatedGameSummative.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
