using Kortspillet_Krig.Models;

namespace Kortspillet_Krig
{
    public partial class Form1 : Form
    {
        private Game game;
        private int currentRound;

        private int playerOneScore;
        private int playerTwoScore;


        public Form1()
        {
            InitializeComponent();
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            game = new Game();
            currentRound = 1;
            playerOneScore = 0;
            playerTwoScore = 0;

            PlayButton.Enabled = true;
            DealButton.Enabled = false;

            PlayerOneCard.Image = null;
            PlayerTwoCard.Image = null;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (currentRound <= 26)
            {
                Card playerOneCard = game.SelectCard();
                Card playerTwoCard = game.SelectCard();

                PlayerOneCard.Image = Image.FromFile($@"Content\img\{playerOneCard.CardImage}.png");
                PlayerTwoCard.Image = Image.FromFile($@"Content\img\{playerTwoCard.CardImage}.png");

                if (playerOneCard.FaceValue > playerTwoCard.FaceValue)
                {
                    playerOneScore += 2;
                    CardTextBox.Text += $"Player one won this round! {playerOneCard.FaceValue} vs {playerTwoCard.FaceValue} {Environment.NewLine}";
                }
                else if (playerOneCard.FaceValue < playerTwoCard.FaceValue)
                {
                    playerTwoScore += 2;
                    CardTextBox.Text += $"Player two won this round! {playerOneCard.FaceValue} vs {playerTwoCard.FaceValue} {Environment.NewLine}";
                }
                else
                {
                    playerOneScore++;
                    playerTwoScore++;
                    CardTextBox.Text += $"This round was a tie! {playerOneCard.FaceValue} vs {playerTwoCard.FaceValue} {Environment.NewLine}";
                }

                PlayerOneScoreLabel.Text = "" + playerOneScore;
                PlayerTwoScoreLabel.Text = "" + playerTwoScore;

                currentRound++;
            }
            else
            {
                if (playerOneScore > playerTwoScore)
                {
                    CardTextBox.Text += $"The winner of the game was: PlayerOne with {playerOneScore} against {playerTwoScore}";
                }
                else
                {
                    CardTextBox.Text += $"The winner of the game was: PlayerTwo with {playerTwoScore} against {playerOneScore}";
                }

                DealButton.Enabled = true;
                PlayButton.Enabled = false;
            }


        }
    }
}
