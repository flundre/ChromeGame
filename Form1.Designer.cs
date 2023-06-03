
namespace ChromeGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.MaxScore = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.RestartButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TRex = new System.Windows.Forms.PictureBox();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.GameOverBox = new System.Windows.Forms.PictureBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.WhiteBox = new System.Windows.Forms.PictureBox();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RestartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(120, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(70, 24);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "SCORE";
            // 
            // MaxScore
            // 
            this.MaxScore.AutoSize = true;
            this.MaxScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxScore.Location = new System.Drawing.Point(8, 9);
            this.MaxScore.Name = "MaxScore";
            this.MaxScore.Size = new System.Drawing.Size(106, 24);
            this.MaxScore.TabIndex = 3;
            this.MaxScore.Text = "HI 00000";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimerTick);
            // 
            // RestartButton
            // 
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.Enabled = false;
            this.RestartButton.Image = global::ChromeGame.Properties.Resources.restart;
            this.RestartButton.Location = new System.Drawing.Point(326, 152);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(72, 64);
            this.RestartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RestartButton.TabIndex = 4;
            this.RestartButton.TabStop = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChromeGame.Properties.Resources.obstacle_1;
            this.pictureBox1.Location = new System.Drawing.Point(494, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Obstacle";
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChromeGame.Properties.Resources.obstacle_2;
            this.pictureBox2.Location = new System.Drawing.Point(572, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Obstacle";
            this.pictureBox2.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ChromeGame.Properties.Resources.flyer;
            this.pictureBox6.Location = new System.Drawing.Point(360, 281);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Obstacle";
            this.pictureBox6.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChromeGame.Properties.Resources.obstacle_3;
            this.pictureBox3.Location = new System.Drawing.Point(523, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Obstacle";
            this.pictureBox3.Visible = false;
            // 
            // TRex
            // 
            this.TRex.Image = global::ChromeGame.Properties.Resources.running;
            this.TRex.Location = new System.Drawing.Point(12, 302);
            this.TRex.Name = "TRex";
            this.TRex.Size = new System.Drawing.Size(40, 43);
            this.TRex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TRex.TabIndex = 0;
            this.TRex.TabStop = false;
            this.TRex.Tag = "Trex";
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.Image = global::ChromeGame.Properties.Resources.road;
            this.BackgroundBox.Location = new System.Drawing.Point(-24, 339);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(2404, 26);
            this.BackgroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackgroundBox.TabIndex = 0;
            this.BackgroundBox.TabStop = false;
            // 
            // GameOverBox
            // 
            this.GameOverBox.Image = global::ChromeGame.Properties.Resources.gameover;
            this.GameOverBox.Location = new System.Drawing.Point(175, 125);
            this.GameOverBox.Name = "GameOverBox";
            this.GameOverBox.Size = new System.Drawing.Size(381, 21);
            this.GameOverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameOverBox.TabIndex = 5;
            this.GameOverBox.TabStop = false;
            this.GameOverBox.Visible = false;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLabel.Location = new System.Drawing.Point(8, 168);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(430, 48);
            this.StartLabel.TabIndex = 6;
            this.StartLabel.Text = "Use W\\Up arrow to jump and to start\r\nUse S\\Down arrow to crouch\r\n";
            // 
            // WhiteBox
            // 
            this.WhiteBox.Location = new System.Drawing.Point(109, -3);
            this.WhiteBox.Name = "WhiteBox";
            this.WhiteBox.Size = new System.Drawing.Size(2500, 402);
            this.WhiteBox.TabIndex = 7;
            this.WhiteBox.TabStop = false;
            // 
            // StartTimer
            // 
            this.StartTimer.Interval = 20;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 364);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.WhiteBox);
            this.Controls.Add(this.GameOverBox);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MaxScore);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TRex);
            this.Controls.Add(this.BackgroundBox);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.RestartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox BackgroundBox;
        private System.Windows.Forms.PictureBox TRex;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label MaxScore;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.PictureBox RestartButton;
        private System.Windows.Forms.PictureBox GameOverBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.PictureBox WhiteBox;
        private System.Windows.Forms.Timer StartTimer;
    }
}

