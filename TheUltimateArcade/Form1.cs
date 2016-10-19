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
                    if (gameValue == 1)
                    {
                        
                    }
                    else
                    {
                        gameValue--;
                    }
                    break;
                case Keys.Right:
                    gameValueHist = gameValue;
                    if (gameValue == 3)
                    {
                        
                    }
                    else
                    {
                        gameValue++;
                    }
                    
                    break;
                default:
                    rightPress = false;
                    leftPress = false;
                    break;
            }
            title.Text = gameValue +"";
            if (gameValue == 1)
            {
                snakeButton.Width = 192;
                pongButton.Width = 0;
                pacmanButton.Width = 0;
                title.Text = "Snake";
                description.Text = "Snake is the common name for a videogame concept where the player maneuvers a \nline which grows in length, with the line itself being a primary obstacle. The \nconcept originated in the 1976 arcade game Blockade, and the ease of \nimplementing Snake has led to hundreds of versions (some of which have the word \nsnake or worm in the title) for many platforms. There are over 300 for iOS alone.";
            }
            if (gameValue == 2)
            {
                snakeButton.Width = 0;
                pongButton.Width = 192;
                pacmanButton.Width = 0;
                title.Text = "Pong";
                description.Text = "The game was originally manufactured by Atari, which released it in 1972. Allan \nAlcorn created Pong as a training exercise assigned to him by Atari co-founder \nNolan Bushnell. ... As a result, Atari encouraged its staff to produce more innovative \ngames.";
                if (gameValue == gameValueHist - 1)
                {
                    for (int a = 0; a < 100; a++)
                    {
                        if (a % 25 == 0)
                        {
                            pcBox1Y = pcBox1Y + 5;
                            pcBox2Y = pcBox2Y - 5;
                        }
                        pcBox1X++;
                        pcBox2X = pcBox2X + 2;
                        pcBox3X = pcBox3X - 3;

                        pictureBox1.Location = new Point(pcBox1X, pcBox1Y);
                        pictureBox2.Location = new Point(pcBox2X, pcBox2Y);
                        pictureBox3.Location = new Point(pcBox3X, pcBox3Y);
                    }
                }
                if (gameValue == gameValueHist + 1)
                {
                    for (int a = 0; a < 100; a++)
                    {
                        if (a % 25 == 0)
                        {
                            pcBox1Y = pcBox1Y - 5;
                            pcBox2Y = pcBox2Y + 5;
                        }
                        pcBox1X++;
                        pcBox2X = pcBox2X + 2;
                        pcBox3X = pcBox3X - 3;

                        pictureBox1.Location = new Point(pcBox1X, pcBox1Y);
                        pictureBox2.Location = new Point(pcBox2X, pcBox2Y);
                        pictureBox3.Location = new Point(pcBox3X, pcBox3Y);
                    }
                }
            }
            if (gameValue == 3)
            {
                snakeButton.Width = 0;
                pongButton.Width = 0;
                pacmanButton.Width = 192;
                title.Text = "Pacman";
                description.Text = "Pac - Man(Japanese: パックマン Hepburn: Pakkuman ?) is an arcade game developed by \nNamco and first released in Japan in May 1980.It was created by Japanese video \ngame designer Toru Iwatani. It was licensed for distribution in the United States by \nMidway and released in October 1980.";
                //if (gameValue == gameValueHist - 1)
                //{
                //    for (int a = 0; a < 100; a++)
                //    {
                //        if (a % 25 == 0)
                //        {
                //            pcBox1Y = pcBox1Y + 5;
                //            pcBox2Y = pcBox2Y - 5;
                //        }
                //        pcBox1X++;
                //        pcBox2X = pcBox2X + 2;
                //        pcBox3X = pcBox3X - 3;

                //        pictureBox1.Location = new Point(pcBox1X, pcBox1Y);
                //        pictureBox2.Location = new Point(pcBox2X, pcBox2Y);
                //        pictureBox3.Location = new Point(pcBox3X, pcBox3Y);
                //    }
                //}
       
            }
            DoubleBuffered = true;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }
    }
}
