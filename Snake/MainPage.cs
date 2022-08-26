
using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.Web;

namespace Snake
{
	public partial class MainPage : Page
	{
		// dimension of game canvas
		private const int NUMBER_OF_FIELDS_X = 40;
		private const int NUMBER_OF_FIELDS_Y = 30;

		// size of food, snake's head and snake's body elements
		private const int FIELD_DIMENSION = 16;

		// snake starts with this length
		private const int INITIAL_SNAKE_LENGTH = 5;

		// speed of the snake's movement
		private const int SPEED = 180; // milliseconds

		// duration of a game
		private const int GAME_DURATION = 60000; // ticks (usually milliseconds)

		// the 4 possible direction that a snake can move
		private enum SnakeDirection { Left, Right, Up, Down }

		public MainPage()
		{
			InitializeComponent();

			// set the game canvas to a size specified by the constants above
			GameCanvas.Size = new Size(NUMBER_OF_FIELDS_X * FIELD_DIMENSION, NUMBER_OF_FIELDS_Y * FIELD_DIMENSION);

			// the progress bar shows the remaining time
			Progress.Size = new Size(NUMBER_OF_FIELDS_X * FIELD_DIMENSION, 5);
			lblScore.Location = new Point(GameCanvas.Location.X + GameCanvas.Width - lblScore.Width, lblTitle.Location.Y);

            // the reset button is located below the lower rioght corner of the game canvas
            btnReset.Location = new Point(GameCanvas.Left + GameCanvas.Width - btnReset.Width, GameCanvas.Top + GameCanvas.Height + 16);

			// the ticker moves the snake every SPEED/1000 seconds
			Ticker.Interval = SPEED;

			// clear the game canvas, set the score to 0 and create a new snake
			ResetGame();
		}

		// this is the snake itself. Each element contains it's x and y position 
		private List<Element> Snake { get; set; }

		// the goal of the game is to direct the snake's head over this Food so it can grow
		private Element Food { get; set; }

		// needed for random position of the food
		private Random Rand { get; } = new Random();

		// the direction in which the snake is currently moving
		private SnakeDirection Direction { get; set; }

		// number of times the snake has eaten food
		private int Score { get; set; }

		// tick counter at the time the game was started
		// later needed to determine if the maximum game time has expired
		private int StartTicks { get; set; }

		// Displays the number of elements the snake has eaten so far
		// If the parameter is omitted the score ist inkremented before
		// displaying it so simply calling this meththod without parameter
		// automatically inkrements the score
		private void DisplayScore(int value = -1)
        {
			if (value < 0)
				Score++;
			else
				Score = value;
            lblScore.Text = $"Score: {Score}";
        }

		// Set everything up for a fresh game:
		// clear the game canvas, set the score to 0, create a new snake and init the progress bar
		private void ResetGame()
        {
            Snake = CreateSnake();
			Food = CreateFood();
			Direction = SnakeDirection.Left;
            DisplayScore(0);
            GameCanvas.Invalidate();
            Ticker.Enabled = true;
			StartTicks = Environment.TickCount;
			Progress.Maximum = GAME_DURATION;
			Progress.Value = Progress.Maximum;
			Progress.BarColor = Color.LightGreen;
		}

		// creates food at a random position
        private Element CreateFood()
        {
			// just for safety make sure we always have the snake before creating the food
			if (Snake == null)
				Snake = CreateSnake();

			// make sure the food is not located on top of the snake
			bool collisionDetected = false;
			while (true)
			{
				Element element = new Element(Rand.Next(0, NUMBER_OF_FIELDS_X - 1), Rand.Next(0, NUMBER_OF_FIELDS_Y - 1));
				for (int i = 0; i < Snake.Count; i++)
					if (element.IsSamePosition(Snake[i]))
					{
						collisionDetected = true;
						break;
					}
				if (!collisionDetected)
					return element;
			}
        }

		// creates a new snake with head and body elements
        private List<Element> CreateSnake()
        {
            var result = new List<Element>();
            int x = NUMBER_OF_FIELDS_X / 2;
            int y = 4;
            for (int i = 0; i <= INITIAL_SNAKE_LENGTH; i++)
                result.Add(new Element(x + i, y));
			return result;
        }

		// walks the snake to the next position depending on the Direction and checks for "eating it's own body" and eats food
		private void MoveSnake()
		{
			int timeDiff = StartTicks + GAME_DURATION - Environment.TickCount;
			Progress.Value = timeDiff < 0 ? 0 : timeDiff;
			if (timeDiff < 3000)
				Progress.BarColor = Color.HotPink;
			if (timeDiff < 0)
            {
				GameOver($"The game is over.{Environment.NewLine}You increased the snake's length by {Score} body elements", "Game over");
				return;
            }

			// store last element for later when the snake eats food
			int tailX = Snake[Snake.Count - 1].X;
			int tailY = Snake[Snake.Count - 1].Y;

			// move snake's body without the head because the head may change direction
			for (int i = Snake.Count - 1; i > 0; i--)
			{
				Snake[i].X = Snake[i - 1].X;
				Snake[i].Y = Snake[i - 1].Y;
			}
			
			// nove the snake's head
			switch (Direction)
            {
				case SnakeDirection.Left:
					Snake[0].X--;
					break;
				case SnakeDirection.Right:
					Snake[0].X++;
					break;
				case SnakeDirection.Up:
					Snake[0].Y--;
					break;
				case SnakeDirection.Down:
					Snake[0].Y++;
					break;
			}

			// wrap snake around when it leaves the game canvas
			if (Snake[0].X < 0)
				Snake[0].X = NUMBER_OF_FIELDS_X - 1;
			if (Snake[0].X >= NUMBER_OF_FIELDS_X)
				Snake[0].X = 0;
			if (Snake[0].Y < 0)
				Snake[0].Y = NUMBER_OF_FIELDS_Y - 1;
			if (Snake[0].Y >= NUMBER_OF_FIELDS_Y)
				Snake[0].Y = 0;

			// collision detection
			for(int i = 1; i < Snake.Count; i++)
            {
				if (Snake[0].IsSamePosition(Snake[i]))
				{
					GameOver("Oops, the snake bit itself and died", "Sorry!");
					return;
				}
			}

			// eat food
			if (Snake[0].IsSamePosition(Food))
			{
				Snake.Add(new Element(tailX, tailY));
				DisplayScore();
				Food = CreateFood();
			}

			// redraw game canvas
			GameCanvas.Invalidate();
		}

        private void GameOver(string message, string caption)
        {
			System.Media.SystemSounds.Exclamation.Play();
			Ticker.Enabled = false;
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ResetGame();
		}

		private void DrawGame(object sender, PaintEventArgs e)
        {
			// draw snake head
			var image = Properties.Resources.Head;
			Point point = new Point(Snake[0].X * FIELD_DIMENSION, Snake[0].Y * FIELD_DIMENSION);
			e.Graphics.DrawImage(image, point);

			// draw snake body
			image = Properties.Resources.Body;
			for (int i = 1; i < Snake.Count - 1; i++)
            {				
				point = new Point(Snake[i].X * FIELD_DIMENSION, Snake[i].Y * FIELD_DIMENSION);
				e.Graphics.DrawImage(image, point);
			}

			// draw food
			image = Properties.Resources.Rat;
			point = new Point(Food.X * FIELD_DIMENSION, Food.Y * FIELD_DIMENSION);
			e.Graphics.DrawImage(image, point);
		}

		private void ChangeDirection(Keys keyCode)
		{
			switch (keyCode)
			{
				case Keys.Left:
					Direction = SnakeDirection.Left;
					break;
				case Keys.Right:
					Direction = SnakeDirection.Right;
					break;
				case Keys.Up:
					Direction = SnakeDirection.Up;
					break;
				case Keys.Down:
					Direction = SnakeDirection.Down;
					break;
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
        {
			ResetGame();
        }

        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            ChangeDirection(e.KeyCode);
        }

        private void Ticker_Tick(object sender, EventArgs e)
		{
			MoveSnake();
		}
	}
}
