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
    public partial class Game : Form
    {
        Logic logic = new Logic();
        public Game()
        {
            InitializeComponent();
        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            ScoreLabel.Text = "Score: " + logic.score;
            logic.OnMainTimer(TRex, MainTimer, this.Controls, this.ClientSize, GameOverBox,
            RestartButton, ScoreLabel);
            logic.replaceBackground(BackgroundBox);

            logic.changeDiff();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            logic.OnKeyDown(e, TRex, StartLabel, StartTimer);
            if (e.KeyCode == Keys.R && logic.isGameOver == true)
            {
                GameOverBox.Visible = false;
                RestartButton.Visible = false;
                RestartButton.Enabled = false;
                logic.changeMaxScore();
                GameReset();
            }
        }
    

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            logic.OnKeyUp(e, TRex);
        }

        private void GameReset()
        {
            StartTimer.Enabled = false;
            logic.OnGameReset(this.Controls, this.ClientSize, TRex);
            ScoreLabel.Text = "Score" + logic.score;
            MaxScore.Text = "HI " + logic.maxScore;
            MainTimer.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GameOverBox.Visible = false;
            RestartButton.Visible = false;
            RestartButton.Enabled = false;
            logic.changeMaxScore();
            GameReset();
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            ScoreLabel.Text = "Score: " + logic.score;

            logic.OnStartTimer(WhiteBox, TRex);

            if (WhiteBox.Left > 1750)
            {
                GameReset();
            }
        }
    }
}
