using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class GameScreen : Form

    {
        public int computerScore = 0;
        public int playerScore = 0;
        public bool buttonWasClicked = false;

        public GameScreen()
        {
            InitializeComponent();

            Image rock = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\RockPaperScissors\\Images\\Rock.png");
            pbxRock.Image = rock;
            pbxRock.SizeMode = PictureBoxSizeMode.StretchImage;

            Image paper = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\RockPaperScissors\\Images\\Paper.png");
            pbxPaper.Image = paper;
            pbxPaper.SizeMode = PictureBoxSizeMode.StretchImage;

            Image scissors = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\RockPaperScissors\\Images\\Scissors.png");
            pbxScissors.Image = scissors;
            pbxScissors.SizeMode = PictureBoxSizeMode.StretchImage;

            button1.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;

            GamePlay();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Hide();
            btnPlay.Show();
            lblWinner.Hide();
            rdbPaper.Checked = false;
            rdbRock.Checked = false;
            rdbScissors.Checked = false;
            //pbxComputerChoice.Hide();
            rdbRock.Show();
            rdbPaper.Show();
            rdbScissors.Show();
            pbxRock.Show();
            pbxPaper.Show();
            pbxScissors.Show();
            pbxComputerChoice.Image = null;

            GamePlay();

        }

        private void GamePlay()
        {
            Image rock = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\RockPaperScissors\\Images\\Rock.png");
            pbxComputerChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            Image paper = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\RockPaperScissors\\Images\\Paper.png");
            Image scissors = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\RockPaperScissors\\Images\\Scissors.png");
            string playerChoice = "";

            

            if (rdbRock.Checked || rdbPaper.Checked || rdbScissors.Checked)
            {
                if (rdbRock.Checked)
                {
                    playerChoice = rdbRock.Text;
                }

                if (rdbPaper.Checked)
                {
                    playerChoice = rdbPaper.Text;
                }

                if (rdbScissors.Checked)
                {
                    playerChoice = rdbScissors.Text;
                }

                if (playerChoice.ToLower() != "rock")
                {
                    pbxRock.Hide();
                    rdbRock.Hide();
                }

                if (playerChoice.ToLower() != "paper")
                {
                    pbxPaper.Hide();
                    rdbPaper.Hide();
                }

                if (playerChoice.ToLower() != "scissors")
                {
                    pbxScissors.Hide();
                    rdbScissors.Hide();
                }

                Random r = new Random();
                int rComputer = r.Next(1, 3);
                string computerChoice = "";

                if (rComputer == 1)
                {
                    pbxComputerChoice.Image = rock;
                    computerChoice = "Rock";
                }
                else if (rComputer == 2)
                {
                    pbxComputerChoice.Image = paper;
                    computerChoice = "Paper";
                }
                else
                {
                    pbxComputerChoice.Image = scissors;
                    computerChoice = "Scissors";
                }

                if (playerChoice.ToLower() == "rock" && computerChoice.ToLower() == "paper")
                {
                    lblWinner.Text = "Computer wins!";
                    lblWinner.Show();
                    computerScore++;
                    lblComputer.Text = computerScore.ToString();
                }

                if (playerChoice.ToLower() == "rock" && computerChoice.ToLower() == "scissors")
                {
                    lblWinner.Text = "Player wins!";
                    lblWinner.Show();
                    playerScore++;
                    lblPlayer.Text = playerScore.ToString();
                }

                if (playerChoice.ToLower() == "rock" && computerChoice.ToLower() == "rock")
                {
                    lblWinner.Text = "Draw!";
                    lblWinner.Show();
                }

                if (playerChoice.ToLower() == "paper" && computerChoice.ToLower() == "rock")
                {
                    lblWinner.Text = "Player wins!";
                    lblWinner.Show();
                    playerScore++;
                    lblPlayer.Text = playerScore.ToString();
                }

                if (playerChoice.ToLower() == "paper" && computerChoice.ToLower() == "scissors")
                {
                    lblWinner.Text = "Computer wins!";
                    lblWinner.Show();
                    computerScore++;
                    lblComputer.Text = computerScore.ToString();
                }

                if (playerChoice.ToLower() == "paper" && computerChoice.ToLower() == "paper")
                {
                    lblWinner.Text = "Draw!";
                    lblWinner.Show();
                }

                if (playerChoice.ToLower() == "scissors" && computerChoice.ToLower() == "rock")
                {
                    lblWinner.Text = "Computer wins!";
                    lblWinner.Show();
                    computerScore++;
                    lblComputer.Text = computerScore.ToString();
                }

                if (playerChoice.ToLower() == "scissors" && computerChoice.ToLower() == "paper")
                {
                    lblWinner.Text = "Player wins!";
                    lblWinner.Show();
                    playerScore++;
                    lblPlayer.Text = playerScore.ToString();
                }

                if (playerChoice.ToLower() == "scissors" && computerChoice.ToLower() == "scissors")
                {
                    lblWinner.Text = "Draw!";
                    lblWinner.Show();
                }
                btnPlay.Hide();
                button1.Show();
            }
            else if(!rdbRock.Checked && !rdbPaper.Checked && !rdbScissors.Checked && buttonWasClicked == true)
            {
                    MessageBox.Show("Make a selection and hit 'Play!'");
            }

            buttonWasClicked = false;
        }
    }
}
