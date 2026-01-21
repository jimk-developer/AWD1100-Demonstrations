using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class Form1 : Form
    {
        // Constants for choices
        public const int HEADS = 1;
        public const int TAILS = 2;

        // Random number generator for coin flip
        private Random randGenerator = new Random();

        // Score tracking
        private int playerScore = 0;
        private int computerScore = 0;
        private int currentRound = 0;
        private const int MAX_ROUNDS = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameRound(int playerChoice)
        {
            // Flip the coin (1 = Heads, 2 = Tails)
            int coinResult = randGenerator.Next(1, 3); // upper bounds

            // Display what the coin landed on
            if (coinResult == HEADS)
            {
                lblCoinResult.Text = "Coin landed on: Heads";
            }
            else
            {
                lblCoinResult.Text = "Coin landed on: Tails";
            }

            // Check if player guessed correctly and update scores
            if (playerChoice == coinResult)
            {
                lblRoundResult.Text = "Correct!";
                playerScore++;
            }
            else
            {
                lblRoundResult.Text = "Wrong!";
                computerScore++;
            }

            // Increment round counter
            currentRound++;

            // Update score labels
            lblPlayerScore.Text = "Your Score: " + playerScore;
            lblComputerScore.Text = "Computer Score: " + computerScore;
            lblRound.Text = "Round: " + currentRound + " of " + MAX_ROUNDS;

            // Check if game is over
            if (currentRound >= MAX_ROUNDS)
            {
                // Determine and display the winner
                if (playerScore > computerScore)
                {
                    lblWinner.Text = "You Win!";
                }
                else if (computerScore > playerScore)
                {
                    lblWinner.Text = "Computer Wins!";
                }
                else
                {
                    lblWinner.Text = "It's a Tie!";
                }
            }
        }
        public bool IsGameOver()
        {
            return currentRound >= MAX_ROUNDS;
        }

        private void btnHeads_Click(object sender, EventArgs e)
        {
            if (!(currentRound >= MAX_ROUNDS))
            {
                GameRound(HEADS);
            }
            else
            {
                btnHeads.Enabled = false;
                btnTails.Enabled = false;
                btnNewGame.Enabled = true;
            }
        }

        private void btnTails_Click(object sender, EventArgs e)
        {
            if (!(currentRound >= MAX_ROUNDS))
            {
                GameRound(TAILS);
            }
            else
            {
                btnHeads.Enabled = false;
                btnTails.Enabled = false;
                btnNewGame.Enabled = true;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnHeads.Enabled = true;
            btnTails.Enabled = true;
            btnNewGame.Enabled = false;

            //reset labels and fields
            lblCoinResult.Text = "";
            lblPlayerScore.Text = "";
            lblComputerScore.Text = "";
            lblWinner.Text = "";
            lblRound.Text = "";
            lblRoundResult.Text = "";
            playerScore = 0;
            computerScore = 0;
            currentRound = 0;
        }
    }
}
