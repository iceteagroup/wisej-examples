
using System;
using System.Drawing;
using Wisej.Web;

//  field order:
//  0   1   2
//  3   4   5
//  6   7   8

//  winning combinations:
//  0   1   2       0   3   6       0   4   8
//  3   4   5       1   4   7       2   4   6
//  6   7   8       2   5   8

namespace TicTacToe
{
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
            ButtonArray = new Button[9] { Field11, Field12, Field13, Field21, Field22, Field23, Field31, Field32, Field33 };
            Fields = new Players[9];
            ResetGame();
		}

		private int PlayerScore { get; set; }
		private int ComputerScore { get; set; }
		private Players[] Fields { get;  }
		private Players CurrentPlayer { get; set; }
        private Button[] ButtonArray { get; }

        private void ResetGame()
		{
			for (int i = 0; i < Fields.Length; i++)
				Fields[i] = Players.None;
			CurrentPlayer = Players.Player;
			UpdateGame();
		}

		private void UpdateGame() 
		{
            for (int i = 0; i < Fields.Length; i++)
			    UpdateButton(ButtonArray[i], Fields[i]);
			
			lblPlayerScore.Text = $"Player: {PlayerScore}";
			lblComputerScore.Text = $"Computer: {ComputerScore}";
        }

        private void UpdateButton(Button button, Players player)
        {
            switch (player)
            {
                case Players.Player:
                    button.Text = "X";
                    button.BackColor = Color.Chartreuse;
                    button.ForeColor = Color.DarkGreen;
                    break;
                case Players.Computer:
                    button.Text = "O";
                    button.BackColor = Color.Crimson;
                    button.ForeColor = Color.White;
                    break;
                default:
                    button.Text = "";
                    button.BackColor = Color.LightGray;
                    button.ForeColor = Color.DarkBlue;
                    break;
            }
        }

        private int IndexOf(Button button)
        {
            for (int i = 0; i < ButtonArray.Length; i++)
                if (ButtonArray[i] == button)
                    return i;
            return -1;
        }

        private bool IsWinner(Players player)
        {
            //  winning combinations:
            //  0   1   2       0   3   6       0   4   8
            //  3   4   5       1   4   7       2   4   6
            //  6   7   8       2   5   8

            return ((Fields[0] == player && Fields[1] == player && Fields[2] == player) ||
                (Fields[3] == player && Fields[4] == player && Fields[5] == player) ||
                (Fields[6] == player && Fields[7] == player && Fields[8] == player) ||
                (Fields[0] == player && Fields[3] == player && Fields[6] == player) ||
                (Fields[1] == player && Fields[4] == player && Fields[7] == player) ||
                (Fields[2] == player && Fields[5] == player && Fields[8] == player) ||
                (Fields[0] == player && Fields[4] == player && Fields[8] == player) ||
                (Fields[2] == player && Fields[4] == player && Fields[6] == player));
        }

        private bool AnyChoiceLeft()
        {
            foreach (var field in Fields)
                if (field == Players.None)
                    return true;
            return false;
        }

        private void PlayerChoice(Button button)
        {
            int index = IndexOf(button);
            if (index < 0 || Fields[index] != Players.None)
                return;

            Fields[index] = Players.Player;
            UpdateButton(button, Players.Player);
            if (IsWinner(Players.Player))
            {
                GameOver(Players.Player);
                return;
            }
            if (!AnyChoiceLeft())
            {
                GameOver(Players.None);
                return;
            }

            CurrentPlayer = Players.Computer;
        }

        private void ComputerChoice()
        {
            int index = ComputerBrain.GetChoice(Fields);

            Fields[index] = Players.Computer;
            UpdateButton(ButtonArray[index], Players.Computer);

            if (IsWinner(Players.Computer))
            {
                GameOver(Players.Computer);
                return;
            }
            if (!AnyChoiceLeft())
            {
                GameOver(Players.None);
                return;
            }

            CurrentPlayer = Players.Player;
        }

        private void GameOver(Players player)
        {
            CurrentPlayer = Players.None;
            if (player == Players.Player)
            {
                PlayerScore++;
                MessageBox.Show("You won!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (player == Players.Computer)
            {
                ComputerScore++;
                MessageBox.Show("You lost!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Nobody won, it's a tie", "Tie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ResetGame();
        }

        private void Ticker_Tick(object sender, EventArgs e)
		{
            if (CurrentPlayer == Players.Computer)
                ComputerChoice();
        }

		private void Button_Click(object sender, EventArgs e)
		{
            if (CurrentPlayer == Players.Player)
                PlayerChoice(sender as Button);
        }
    }
}
