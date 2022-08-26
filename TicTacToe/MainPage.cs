
using System;
using System.Drawing;
using System.Linq;
using Wisej.Web;

namespace TicTacToe
{

/*	Field locations:
		1   2   3
		4   5   6
		7   8   9
*/

    public partial class MainPage : Page
	{

		private enum Players { None, Player, Computer }

        public MainPage()
		{
			InitializeComponent();
            ResetGame();
        }

        private int PlayerScore { get; set; } = 0;
        private int ComputerScore { get; set; } = 0;
        private Players CurrentPlayer { get; set; } = Players.Player;
        
        private readonly Random Rand = new Random();

		private void ResetGame()
		{
            // clear all fields
            foreach (var c in Controls)
                if (c is Button field && field.Name.StartsWith("Field"))
					SetFieldState(field, Players.None);

            UpdateScoreDisplay();
        }

        private void SetFieldState(Button field, Players player)
        {
            // display field depending on who clicked it
            field.Tag = player;
            switch (player)
            {
                case Players.Player:
                    field.Text = "X";
                    field.BackColor = Color.Chartreuse;
                    field.ForeColor = Color.DarkGreen;
                    break;
                case Players.Computer:
                    field.Text = "O";
                    field.BackColor = Color.Crimson;
                    field.ForeColor = Color.White;
                    break;
                default:
                    field.Text = "";
                    field.BackColor = Color.LightGray;
                    field.ForeColor = Color.DarkBlue;
                    break;
            }
        }

        private Players GetState(Button field)
        {
            // return who clicked this field
            if (field == null || !field.Name.StartsWith("Field") || field.Tag == null)
                return Players.None;
            return (Players)field.Tag;
        }

        private bool GameOver(Players player)
        {
            if (player == Players.None)
                return false;

            // check if there' 3 in a row (horizontally, vertically or diagonally
            bool gameOver = 
                (GetState(Field11) == player && GetState(Field12) == player && GetState(Field13) == player) ||
                (GetState(Field21) == player && GetState(Field22) == player && GetState(Field23) == player) ||
                (GetState(Field31) == player && GetState(Field32) == player && GetState(Field33) == player) ||
                (GetState(Field11) == player && GetState(Field21) == player && GetState(Field31) == player) ||
                (GetState(Field12) == player && GetState(Field22) == player && GetState(Field32) == player) ||
                (GetState(Field13) == player && GetState(Field23) == player && GetState(Field33) == player) ||
                (GetState(Field11) == player && GetState(Field22) == player && GetState(Field33) == player) ||
                (GetState(Field13) == player && GetState(Field22) == player && GetState(Field31) == player);


            if (!gameOver)
            {
                // no more buttons left? Then it's a tie
                if (NoMoreButtonsLeft())
                    player = Players.None;
                else
                    return false;
            }

            CurrentPlayer = Players.None;
            try
            {
                switch (player)
                {
                    case Players.Player:
                        PlayerScore++;
                        MessageBox.Show("You won!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case Players.Computer:
                        ComputerScore++;
                        MessageBox.Show("I'm sorry but this time you lost :-(", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Nobody won, it's a tie!", "Woah!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

                UpdateScoreDisplay();
                ResetGame();
            }
            finally
            {
                CurrentPlayer = Players.Player;
            }

            return true;
        }

        private bool NoMoreButtonsLeft()
        {
            return
                GetState(Field11) != Players.None && GetState(Field12) != Players.None && GetState(Field13) != Players.None &&
                GetState(Field21) != Players.None && GetState(Field22) != Players.None && GetState(Field23) != Players.None &&
                GetState(Field31) != Players.None && GetState(Field32) != Players.None && GetState(Field33) != Players.None;
        }

        private void UpdateScoreDisplay()
        {
            lblPlayerScore.Text = $"Player: {PlayerScore}";
            lblComputerScore.Text = $"Computer: {ComputerScore}";
        }

        private void ComputerChoice()
        {
            Button field;

            // find a random field that hasn't been clicked yet
            while (true)
            {
                field = GetFieldByIndex(Rand.Next(0, 9));
                if (GetState(field) == Players.None)
                    break;
            }

            // click the field
            SetFieldState(field, Players.Computer);
            if (GameOver(Players.Computer))
                return;

            // next player
            CurrentPlayer = Players.Player;
        }

        private Button GetFieldByIndex(int index)
        {
            // there are 9 fields (0-8)
            // depending on the index this method returns the according button
            int row = (index / 3) + 1;
            int col = (index % 3) + 1;
            Button field = Controls.FirstOrDefault(x => x.Name.Equals($"Field{row}{col}")) as Button;
            return field;
        }

        private void Field_Click(object sender, EventArgs e)
        {
            // the player clicked a field
            if (CurrentPlayer != Players.Player)
                return;

            // remove the ugly focus around the field button
            ActiveControl = null;

            // don't do anything if the field has already bee clicked
            Button field = sender as Button;
            if ((Players)field.Tag != Players.None)
                return;

            // mark the field as a player's field
            SetFieldState(field, Players.Player);

            // check if there's 3 in a row
            if (GameOver(Players.Player))
                return;

            // next player
            CurrentPlayer = Players.Computer;
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            // the ticker fires periodically and when it's the computer's turn a click is generated
            if (CurrentPlayer == Players.Computer)
                ComputerChoice();
        }
    }
}
