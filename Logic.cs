using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeGame
{
    class Logic
    {
        public bool jumping;
        public bool crouching;
        public int jumpSpeed;
        public double force;
        public int score;
        public int obstacleSpeed;
        public Random rand = new Random();
        public bool isGameOver;
        public bool aero;
        public bool BlockJump;
        public bool BlockDuck;
        public int tickCounter;
        public int difficulty;
        public int maxScore;
        public bool gameStart;

        public Logic()
        {
            aero = false;
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            crouching = false;
            score = 0;
            obstacleSpeed = 10;
            isGameOver = false;
            BlockJump = false;
            BlockDuck = false;
            tickCounter = 0;
            difficulty = 1;
            maxScore = 0;
            gameStart = false;
        }

        public void changeDiff()
        {
            if (tickCounter / 200 > difficulty)
            {
                obstacleSpeed += 1;
                difficulty++;
            }
        }

        public void replaceBackground(PictureBox BackgroundBox)
        {
            if (BackgroundBox.Left < -1000)
            {
                BackgroundBox.Left = -24;
            }
            else
            {
                BackgroundBox.Left -= obstacleSpeed;
            }
        }

        public void OnGameReset(Control.ControlCollection ctrl, Size screensize, PictureBox Trex)
        {
            aero = false;
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            crouching = false;
            score = 0;
            obstacleSpeed = 10;
            isGameOver = false;
            BlockJump = false;
            BlockDuck = false;
            tickCounter = 0;
            difficulty = 1;
            gameStart = true;

            Trex.Image = Properties.Resources.running;
            Trex.Top = 304;

            foreach (Control x in ctrl)
            {
                if (x is PictureBox && (string)x.Tag == "Obstacle")
                {
                    x.Left -= obstacleSpeed;
                    x.Left = screensize.Width + rand.Next(200, 500) + (x.Width * 80);
                    x.Visible = true;
                }
            }
        }

        public void OnKeyUp(KeyEventArgs e, PictureBox Trex)
        {
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && jumping == true)
            {
                jumping = false;
            }

            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && crouching == true)
            {
                crouching = false;
                aero = false;
                Trex.Image = Properties.Resources.running;
                Trex.Top = 304;
                Trex.Size = new Size(40, 43);
            }
        }

        public void OnKeyDown(KeyEventArgs e, PictureBox TRex, Label StartLabel, Timer StartTimer)
        {
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && gameStart == false && BlockJump == false)
            {
                jumping = true;
                jumpSpeed = -4;
                StartLabel.Visible = false;
                StartTimer.Enabled = true;
                TRex.Image = Properties.Resources.running;
                TRex.Top = 304;
                TRex.Size = new Size(40, 43);
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && gameStart == false & BlockJump == true)
            {
                TRex.Image = Properties.Resources.running;
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && jumping == false && BlockJump == false)
            {
                jumping = true;
                jumpSpeed = -4;
                TRex.Image = Properties.Resources.running;
                TRex.Top = 304;
                TRex.Size = new Size(40, 43);
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && jumping == true && BlockJump == true)
            {
                TRex.Image = Properties.Resources.running;
            }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && jumping == false && BlockDuck == false)
            {
                crouching = true;
                TRex.Image = Properties.Resources.crouch;
                TRex.Top = 321;
                TRex.Size = new Size(51, 26);
            }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && jumping == false && BlockDuck == true)
            {
                aero = true;
                TRex.Image = Properties.Resources.running;
            }
        }

        public void OnMainTimer(PictureBox TRex, Timer MainTimer, Control.ControlCollection ctrl, Size screensize, PictureBox GameOverBox,
            PictureBox RestartButton, Label ScoreLabel) 
        {
            tickCounter++;
            TRex.Top += jumpSpeed;

            if (jumping == true && force < 0)
            {
                jumping = false;
                BlockJump = true;
            }
            if (jumping == true)
            {
                BlockDuck = true;
                if (jumpSpeed > -12)
                {
                    jumpSpeed -= 3;
                }
                force -= 2;

            }
            else if (jumping == false)
            {
                if (aero)
                {
                    jumpSpeed += 5;
                }
                jumpSpeed += 2;
            }

            if (TRex.Top > 300 && jumping == false && crouching == false)
            {
                force = 12;
                TRex.Top = 304;
                jumpSpeed = 0;
                aero = false;
                BlockJump = false;
                BlockDuck = false;
            }
            else if (crouching == true)
            {
                TRex.Top = 321;
            }

            foreach (Control x in ctrl)
            {
                if (x is PictureBox && (string)x.Tag == "Obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = screensize.Width + rand.Next(200, 500) + (x.Width * 80);
                        score++;
                    }

                    if (TRex.Bounds.IntersectsWith(x.Bounds))
                    {
                        MainTimer.Stop();
                        OnGameLoose(TRex, GameOverBox, RestartButton, ScoreLabel);
                    }
                }
            }
        }
        public void changeMaxScore()
        {
            if (maxScore < score)
            {
                maxScore = score;
            }
            
        }

        public void OnStartTimer(PictureBox WhiteBox, PictureBox Trex)
        {
            WhiteBox.Left += 60;
            Trex.Top += jumpSpeed;

            if (jumping == true && force < 0)
            {
                jumping = false;
                BlockJump = true;
            }
            if (jumping == true)
            {
                BlockDuck = true;
                if (jumpSpeed > -12)
                {
                    jumpSpeed -= 3;
                }
                force -= 2;

            }
            else if (jumping == false)
            {
                if (aero)
                {
                    jumpSpeed += 5;
                }
                jumpSpeed += 2;
            }

            if (Trex.Top > 300 && jumping == false && crouching == false)
            {
                force = 12;
                Trex.Top = 304;
                jumpSpeed = 0;
                aero = false;
                BlockJump = false;
                BlockDuck = false;
            }
            else if (crouching == true)
            {
                Trex.Top = 321;
            }
        }

        public void OnGameLoose(PictureBox TRex, PictureBox GameOverBox, PictureBox RestartButton, Label ScoreLabel)
        {
            TRex.Image = Properties.Resources.dead;
            ScoreLabel.Text += " Press R or click button to restart the game!";

            isGameOver = true;
            GameOverBox.Visible = true;
            RestartButton.Visible = true;
            RestartButton.Enabled = true;
        }
    }
}
