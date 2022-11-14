using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout
{
    public partial class Game_Form : Form
    {
        bool goLeft;
        bool goRight;

        int score;
        int ballXSpeed;
        int ballYSpeed;
        int paddleSpeed;

        Random random = new Random();
        public Game_Form()
        {
            InitializeComponent();
            setUpGame();
        }

        private void setUpGame()
        {
            score = 0;
            ballXSpeed = 10;
            ballYSpeed = 10;
            paddleSpeed = 12;

            gameTimer.Start();

            //Check user options
            switch(Menu.ColorIndex)
            {
                case 0:
                    Paddle.BackColor = Color.White;
                    break;
                case 1:
                    Paddle.BackColor = Color.Yellow;
                    break;
                case 2:
                    Paddle.BackColor = Color.Blue;
                    break;
                case 3:
                    Paddle.BackColor = Color.Red;
                    break;
                case 4:
                    Paddle.BackColor = Color.Green;
                    break;
                case 5:
                    Paddle.BackColor = Color.Purple;
                    break;
                case 6:
                    Paddle.BackColor = Color.Orange;
                    break;
            }

            switch (Menu.DifficultyIndex)
            {
                case 0:
                    ballXSpeed = 5;
                    ballYSpeed = 5;
                    paddleSpeed = 10;
                    setUpBlocks(0, 4);
                    break;
                case 1:
                    ballXSpeed = 10;
                    ballYSpeed = 10;
                    paddleSpeed = 15;
                    setUpBlocks(1,8);
                    break;
                case 2:
                    ballXSpeed = 15;
                    ballYSpeed = 15;
                    paddleSpeed = 20;
                    setUpBlocks(2,10);
                    break;
            }

            GameOverScoreLabel.Hide();
            YourScoreLabel.Hide();
            GameOverLabel.Hide();
            ReturnButton.Hide();
            PlayerNameTextBox.Hide();
            EnterYourNameLabel.Hide();
        }

        private void setUpBlocks(int firstIdx,int lastIdx)
        {
            
                foreach (Control x in this.Controls)
                {
                int rnd = random.Next(firstIdx, lastIdx);
                    if (x is PictureBox && (string)x.Tag == "blocks")
                    {
                        if (rnd > 6)
                        {
                            x.BackColor = Color.Red;
                            continue;
                        }
                        if (rnd > 4)
                        {
                            x.BackColor = Color.Green;
                            continue;
                        }
                        if (rnd > 2)
                            x.BackColor = Color.Blue;
                }

                }
          
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft == true && Paddle.Left > 0)
            {
                Paddle.Left -= paddleSpeed;
            }
            if (goRight == true && Paddle.Left < this.Width - Paddle.Width)
            {
                Paddle.Left += paddleSpeed;
            }

            Ball.Left += ballXSpeed;
            Ball.Top += ballYSpeed;

            //Side walls ball bouncing
            if (Ball.Left < 0 || Ball.Left > this.Width - Ball.Width)
            {
                Menu.ClickObjectSound.Play();
                ballXSpeed = -ballXSpeed;
            }
            
            //Top wall ball bouncing
            if (Ball.Top-10 < 0)
            {
                Menu.ClickObjectSound.Play();
                ballYSpeed = -ballYSpeed;
            }

            //Paddle bouncing
            if (Ball.Bounds.IntersectsWith(Paddle.Bounds))
            {
                Menu.ClickObjectSound.Play();
                ballYSpeed = -ballYSpeed;
            }

            //Enemy bouncing
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Menu.ClickObjectSound.Play();
                        ballYSpeed = -ballYSpeed;
                        if (x.BackColor == Color.White)
                        {
                            this.Controls.Remove(x);
                            score += 10;
                            ScoreLabel.Text = "Score: " + score;
                        }
                        else if (x.BackColor == Color.Blue)
                            x.BackColor = Color.White;
                        else if (x.BackColor == Color.Green)
                            x.BackColor = Color.Blue;
                        else if (x.BackColor == Color.Red)
                            x.BackColor = Color.Green;

                    }
                }
            }
            //GameOver
            if (score > 660 || Ball.Top>this.Height-Ball.Height) 
            {
                gameOver();
            }
            
        }

        private void gameOver()
        {
            gameTimer.Stop();
            Menu.GameOverSound.Play();
            //Hide paddle, ball etc.
            foreach (Control x in this.Controls)
            {
                x.Hide();
            }

            //Setup Score on Game Over screen
            GameOverScoreLabel.Text = ""+score;

            //Show Game Over screen
            GameOverScoreLabel.Show();
            YourScoreLabel.Show();
            GameOverLabel.Show();
            ReturnButton.Show();
            EnterYourNameLabel.Show();
            PlayerNameTextBox.Show();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left || e.KeyCode==Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Menu.ClickObjectSound.Play();
            if (!(PlayerNameTextBox.Text == ""))
            {
                Menu.PlayerInfo playerInfo = new Menu.PlayerInfo();
                playerInfo.Name = PlayerNameTextBox.Text;
                playerInfo.Score = GameOverScoreLabel.Text;
                Menu.PlayerList.Add(playerInfo); 
                this.Close();
            }
        }

        private void PlayerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameOverLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
