using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualBasic;
using Wisej.Web;
using KeyEventArgs = Wisej.Web.KeyEventArgs;

namespace TetrisBoxWisej
{
    // **********************************************************************************************
    // *** This is my TetrisBox class made for an Experts Exchange article                        ***
    // *** Feel free to modify and use at your convenience!                                       ***
    // *** Visit my profile on Experts Exchange for more articles and solutions:                  ***
    // *** http://www.experts-exchange.com/members/RolandDeschain.html                            ***
    // **********************************************************************************************
    // *** Version 1.0.0.0                                                                        ***
    // *** Released on 08/19/2014                                                                 ***
    // **********************************************************************************************
    // **********************************************************************************************
    // *** Ported to Wisej                                                                        ***
    // *** Released on Jan/2021                                                                   ***
    // **********************************************************************************************


    // As this class is, basically, a Tetris drawing surface, I thought that it would be logical to inherit it from the PictureBox class
    // Inherits System.Windows.Forms.PictureBox
    public class TetrisBox : PictureBox
    {

        /* TODO ERROR: Skipped RegionDirectiveTrivia */    // This enum is for the background style. You can choose between 3 background styles:
        public enum BackgroundStyles
        {
            SolidColor,  // Draw the background as a solid, unique color (use BackColor property)
            Gradient,    // Draw the background as a gradient (use GradientColor1, GradientColor2 and GradientDirection properties)
            Picture     // Draw the background as a picture (use the BackgroundImage property, it will be stretched to the control size)
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private class Block
        {
            // This class represents a falling block in Tetris game. There are 7 different blocks, as you Tetris gamers sure know.
            private int _type;    // Stores the block type. In the Experts Exchange article you'll find a guide matching _type value with each associated block type.

            public Color Color { get; set; }     // Each block type has a distinctive color.

            private int _rotationsNumber;     // Each block type has a concrete number of possible positions (rotations) in board.
            private Dictionary<int, List<string>> _rotations = new Dictionary<int, List<string>>(); // Stores the block definition for each rotation inside a 4x4 matrix
            private int _currentRotation = 1; // The current position of the block

            public int X { get; set; } = 0;    // The current column inside board
            public int Y { get; set; } = 0;    // The current row inside board

            public void OffsetRotation()
            {
                // Sets the block to the next possible rotation, in response to the user pressing the rotate key
                _currentRotation += 1;
                if (_currentRotation > _rotationsNumber)
                    _currentRotation = 1;
            }

            public bool FilledCell(int x, int y)
            {
                // Returns True if the specified x,y position is filled inside the 4x4 matrix
                return CurrentMatrix[y].Substring(x, 1).Equals("1");
            }

            public List<string> CurrentMatrix
            {
                get
                {
                    // Returns the 4x4 matrix corresponding to the current rotation of the block
                    return _rotations[_currentRotation];
                }
            }

            public List<string> NextRotationMatrix
            {
                get
                {
                    // Returns the 4x4 matrix corresponding to the next rotation of the block
                    int nextRotation = _currentRotation + 1;
                    if (nextRotation > _rotationsNumber)
                        nextRotation = 1;
                    return _rotations[nextRotation];
                }
            }

            public int Type
            {
                get
                {
                    // Returns the block's type
                    return _type;
                }
            }

            public Block(int blockType)
            {
                // Initializes the class. Depending on the block type it will initialize with its own values
                _type = blockType;
                switch (_type)
                {
                    case 1:
                        {
                            InitializeBlock(new List<string>() { "0100", "0100", "0100", "0100" }, new List<string>() { "0000", "1111", "0000", "0000" });
                            break;
                        }

                    case 2:
                        {
                            InitializeBlock(new List<string>() { "0110", "0110", "0000", "0000" });
                            break;
                        }

                    case 3:
                        {
                            InitializeBlock(new List<string>() { "0100", "1110", "0000", "0000" }, new List<string>() { "0100", "0110", "0100", "0000" }, new List<string>() { "1110", "0100", "0000", "0000" }, new List<string>() { "0100", "1100", "0100", "0000" });
                            break;
                        }

                    case 4:
                        {
                            InitializeBlock(new List<string>() { "0010", "0110", "0100", "0000" }, new List<string>() { "0110", "0011", "0000", "0000" });
                            break;
                        }

                    case 5:
                        {
                            InitializeBlock(new List<string>() { "0100", "0110", "0010", "0000" }, new List<string>() { "0011", "0110", "0000", "0000" });
                            break;
                        }

                    case 6:
                        {
                            InitializeBlock(new List<string>() { "0100", "0100", "0110", "0000" }, new List<string>() { "0111", "0100", "0000", "0000" }, new List<string>() { "0110", "0010", "0010", "0000" }, new List<string>() { "0001", "0111", "0000", "0000" });
                            break;
                        }

                    case 7:
                        {
                            InitializeBlock(new List<string>() { "0010", "0010", "0110", "0000" }, new List<string>() { "0100", "0111", "0000", "0000" }, new List<string>() { "0110", "0100", "0100", "0000" }, new List<string>() { "0111", "0001", "0000", "0000" });
                            break;
                        }
                }
            }

            private void InitializeBlock(params List<string>[] rotations)
            {
                // Initializes a new block

                // Set the number of possible rotations
                _rotationsNumber = rotations.Length;
                // Set the 4x4 matrix of each possible rotation
                for (int k = 0, loopTo = rotations.Length - 1; k <= loopTo; k++)
                    _rotations.Add(k + 1, rotations[k]);
            }
        }

        private class Cell
        {
            // This class represents a single cell (defined by its row and column) inside the game board
            public int Row { get; set; } = 0;          // Defines the cell row
            public int Column { get; set; } = 0;       // Defines the cell column
            public bool Fixed { get; set; } = false;    // When a block drops in the board to its ultimate position (and therefore it cannot be moved anymore), the board cells corresponding to the block filled cells become Fixed
            public Color Color { get; set; }              // The color in which this cell must be painted in the board

            public Cell(int row, int column)
            {
                // Instantiates a new Cell object passing its row and column
                Row = row;
                Column = column;
            }
        }

        private class CellPoint
        {
            // Really this class is very close to the System.Drawing.Point class, but I've overwritten its ToString function to return the row and column into a string
            // that is helpful to me because it's the Key in the cells collection of the board.
            public int Row { get; set; } = 0;          // Represents the row
            public int Column { get; set; } = 0;       // Represents the column

            public CellPoint(int row, int column)
            {
                // Instantiates a new CellPoint object passing its row and column
                Row = row;
                Column = column;
            }

            public override string ToString()
            {
                // Returns a string that can be used as a Key in the cells collection of the board
                return Row.ToString() + "," + Column.ToString();
            }
        }

        private class Board
        {
            // This class represents the game board. Many of the game logic is implemented here.
            public int Rows { get; set; } = 0;                     // Defines the number of rows
            public int Columns { get; set; } = 0;                  // Defines the number of columns
            public Dictionary<string, Cell> Cells { get; set; }    // Single-cell collection
            public Block FallingBlock { get; set; } = null;         // The current falling block, if there's any
            public Color Block1Color { get; set; } = Color.Red;        // Allows to customize the color of the type 1 blocks
            public Color Block2Color { get; set; } = Color.Blue;       // Allows to customize the color of the type 2 blocks
            public Color Block3Color { get; set; } = Color.Green;      // Allows to customize the color of the type 3 blocks
            public Color Block4Color { get; set; } = Color.Aqua;       // Allows to customize the color of the type 4 blocks
            public Color Block5Color { get; set; } = Color.Brown;      // Allows to customize the color of the type 5 blocks
            public Color Block6Color { get; set; } = Color.Yellow;     // Allows to customize the color of the type 6 blocks
            public Color Block7Color { get; set; } = Color.Purple;     // Allows to customize the color of the type 7 blocks

            private int _nextBlock = 0;                       // The next block that will fall after the current that is falling

            public event FullRowsEventHandler FullRows;

            public delegate void FullRowsEventHandler(object sender, FullRowsEventArgs e);     // Fires when the user completes any number of full rows. The completed rows will disappear.

            public event GameOverEventHandler GameOver;

            public delegate void GameOverEventHandler(object sender, EventArgs e);      // Fires when a block reaches the top of the game board.

            public event GotNewBlockEventHandler GotNewBlock;

            public delegate void GotNewBlockEventHandler(object sender, NewBlockEventArgs e);  // Fires every time a new block is created. This is useful for adding difficulties every certain number of blocks.

            public Board(int rows, int columns)
            {
                // Instantiates a new Board class passing its rows and columns number

                // Set the number of rows
                Rows = rows;
                // Set the number of columns
                Columns = columns;
                // Initialize the Cell collection
                Cells = new Dictionary<string, Cell>();
                for (int row = 0, loopTo = Rows - 1; row <= loopTo; row++)
                {
                    for (int column = 0, loopTo1 = Columns - 1; column <= loopTo1; column++)
                        Cells.Add(row.ToString() + "," + column.ToString(), new Cell(row, column));
                }
            }

            private int GetRandomNumber(int lowerbound, int upperbound)
            {
                // To get an integer random number inside a known interval, as seen on MSDN
                //return (int)Math.Floor((upperbound - lowerbound + 1) * VBMath.Rnd()) + lowerbound;
                Random r = new Random();
                int rInt = r.Next(lowerbound, upperbound); //for ints
                return rInt;
            }

            public bool Rotate()
            {
                // Tries to rotate the current falling block, returning True if the rotation has been done
                if (CanRotate())
                {
                    FallingBlock.OffsetRotation();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private bool CanRotate()
            {
                // Ensures that the current falling block can rotate. It can rotate if, once rotated, keeps inside board margins and doesn't overlap with existing fixed cells.
                if (FallingBlock is object)
                {
                    // Get the 4x4 matrix corresponding to the next rotation of the block
                    var nextRotation = FallingBlock.NextRotationMatrix;
                    // Check each filled cell of the block. It must be inside board margins and not overlap with fixed cells.
                    for (int row = 0; row <= 3; row++)
                    {
                        for (int column = 0; column <= 3; column++)
                        {
                            if (nextRotation[row].Substring(column, 1).Equals("1"))
                            {
                                // This is a filled cell.
                                // Translate its coordinates to board-coordinates.
                                var pt = BlockToBoard(new CellPoint(row, column));
                                // Check if the cell is inside board margins and doesn't overlap with fixed cells.
                                if (pt.Column < 0 || pt.Column >= Columns || pt.Row < 0 || pt.Row >= Rows || Cells[new CellPoint(pt.Row, pt.Column).ToString()].Fixed)
                                {
                                    return false;
                                }
                            }
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool MoveLeft()
            {
                // Tries to move the current block 1 column to the left, returning True if it has been moved
                if (CanMoveLeft())
                {
                    FallingBlock.X -= 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private bool CanMoveLeft()
            {
                // Ensures that the current falling block can move to the left. It can move if, once moved, keeps inside board margins and doesn't overlap with existing fixed cells.
                if (FallingBlock is object)
                {
                    // Check each filled cell of the block. It must be inside board margins and not overlap with fixed cells.
                    for (int row = 0; row <= 3; row++)
                    {
                        for (int column = 0; column <= 3; column++)
                        {
                            if (FallingBlock.FilledCell(column, row))
                            {
                                // This is a filled cell.
                                // Translate its coordinates to board-coordinates.
                                var pt = BlockToBoard(new CellPoint(row, column));
                                // Check if the cell is inside board margins and doesn't overlap with fixed cells.
                                if (pt.Column.Equals(0) || Cells[new CellPoint(pt.Row, pt.Column - 1).ToString()].Fixed)
                                {
                                    return false;
                                }
                            }
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }

            private bool CanMoveRight()
            {
                // Ensures that the current falling block can move to the right. It can move if, once moved, keeps inside board margins and doesn't overlap with existing fixed cells.
                if (FallingBlock is object)
                {
                    // Check each filled cell of the block. It must be inside board margins and not overlap with fixed cells.
                    for (int row = 0; row <= 3; row++)
                    {
                        for (int column = 3; column >= 0; column -= 1)
                        {
                            if (FallingBlock.FilledCell(column, row))
                            {
                                // This is a filled cell.
                                // Translate its coordinates to board-coordinates.
                                var pt = BlockToBoard(new CellPoint(row, column));
                                // Check if the cell is inside board margins and doesn't overlap with fixed cells.
                                if (pt.Column.Equals(Columns - 1) || Cells[new CellPoint(pt.Row, pt.Column + 1).ToString()].Fixed)
                                {
                                    return false;
                                }
                            }
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool MoveRight()
            {
                // Tries to move the current block 1 column to the right, returning True if it has been moved
                if (CanMoveRight())
                {
                    FallingBlock.X += 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void NewBlock()
            {
                // Creates a new block.

                if (_nextBlock.Equals(0))
                {
                    // This is the first block requested, so get its block type randomly
                    FallingBlock = new Block(GetRandomNumber(1, 7));
                }
                else
                {
                    // This is not the first block, so use the _nextBlock variable
                    FallingBlock = new Block(_nextBlock);
                }
                // Set the block color
                switch (FallingBlock.Type)
                {
                    case 1:
                        {
                            FallingBlock.Color = Block1Color;
                            break;
                        }

                    case 2:
                        {
                            FallingBlock.Color = Block2Color;
                            break;
                        }

                    case 3:
                        {
                            FallingBlock.Color = Block3Color;
                            break;
                        }

                    case 4:
                        {
                            FallingBlock.Color = Block4Color;
                            break;
                        }

                    case 5:
                        {
                            FallingBlock.Color = Block5Color;
                            break;
                        }

                    case 6:
                        {
                            FallingBlock.Color = Block6Color;
                            break;
                        }

                    case 7:
                        {
                            FallingBlock.Color = Block7Color;
                            break;
                        }
                }
                // Select the next block to fall (after the one just chosen)
                _nextBlock = GetRandomNumber(1, 7);
                // Position the new block inside the board
                FallingBlock.X = (int)((Columns - 4) / 2d);
                FallingBlock.Y = 0;
                // Notify user that a new block has been created
                GotNewBlock?.Invoke(this, new NewBlockEventArgs(FallingBlock.Type, _nextBlock));
            }

            public void CheckBlock()
            {
                // Checks game logic with the falling block. Concretely, checks that:
                // 1) The falling block has reached the top of the board (it overlaps with existing fixed cells)
                // 2) The falling block has reached its ultimate position and, therefore, it cannot be moved anymore (for example, it has been dropped to the bottom of the board)

                if (FallingBlock is object)
                {
                    // Let's see if the falling block overlaps with existing fixed cells. If so, the game is over
                    bool overlapBlock = false;
                    // Check each existing filled cell on the current falling block
                    for (int row = 0; row <= 3; row++)
                    {
                        for (int column = 0; column <= 3; column++)
                        {
                            if (FallingBlock.FilledCell(column, row))
                            {
                                // This is a filled cell
                                // Translate its coordinates to board-coordinates
                                var pt = BlockToBoard(new CellPoint(row, column));
                                if (Cells[pt.ToString()].Fixed)
                                {
                                    overlapBlock = true;
                                    break;
                                }
                            }
                        }

                        if (overlapBlock)
                            break;
                    }

                    if (overlapBlock)
                    {
                        // An overlap exists. This is game over!
                        GameOver?.Invoke(this, new EventArgs());
                    }
                    else
                    {
                        // Now check if the current falling block has been dropped to its ultimate position. If so, transform each filled cell of the block into a fixed cell on the board.
                        bool fixBlock = false;
                        for (int column = 0; column <= 3; column++)
                        {
                            for (int row = 3; row >= 0; row -= 1)
                            {
                                if (FallingBlock.FilledCell(column, row))
                                {
                                    var pt = BlockToBoard(new CellPoint(row, column));
                                    // If the falling block has a filled cell just over the board's bottom, or just over a fixed cell in the next line, it must be fixed
                                    if (pt.Row.Equals(Rows - 1) || Cells[new CellPoint(pt.Row + 1, pt.Column).ToString()].Fixed)
                                    {
                                        fixBlock = true;
                                    }

                                    break;
                                }
                            }

                            if (fixBlock)
                                break;
                        }

                        if (fixBlock)
                        {
                            // Transform each filled cell on the block into a fixed cell on the board
                            for (int row = 0; row <= 3; row++)
                            {
                                for (int column = 0; column <= 3; column++)
                                {
                                    if (FallingBlock.FilledCell(column, row))
                                    {
                                        var pt = BlockToBoard(new CellPoint(row, column));
                                        Cells[pt.ToString()].Fixed = true;
                                        Cells[pt.ToString()].Color = FallingBlock.Color;
                                    }
                                }
                            }

                            FallingBlock = null;
                            // As a block has been dropped and fixed, check if the player has completed full rows
                            CheckFullRows();
                        }
                    }
                }
            }

            private void CheckFullRows()
            {
                // Checks if the player has completed full rows (this is the main Tetris objective!)

                var fullRows = new List<int>();

                // Check each row from bottom to top
                for (int row = Rows - 1; row >= 0; row -= 1)
                {
                    bool fullRow = true;
                    // Check if all columns are fixed in the row
                    for (int column = 0, loopTo = Columns - 1; column <= loopTo; column++)
                    {
                        if (!Cells[row.ToString() + "," + column.ToString()].Fixed)
                        {
                            fullRow = false;
                            break;
                        }
                    }
                    // The row is full filled
                    if (fullRow)
                        fullRows.Add(row);
                }

                if (fullRows.Count > 0)
                {
                    // Delete the full rows
                    foreach (int row in fullRows)
                        DeleteRow(row);
                    // Notify the user (you should probably reward the player)
                    FullRows?.Invoke(this, new FullRowsEventArgs(fullRows.Count));
                }
            }

            private void DeleteRow(int row)
            {
                // Delete a row

                // To delete a row, drop-down the entire board over the deleted row and clear the first row
                for (int r = row; r >= 1; r -= 1)
                {
                    for (int col = 0, loopTo = Columns - 1; col <= loopTo; col++)
                    {
                        Cells[r.ToString() + "," + col.ToString()].Fixed = Cells[(r - 1).ToString() + "," + col.ToString()].Fixed;
                        Cells[r.ToString() + "," + col.ToString()].Color = Cells[(r - 1).ToString() + "," + col.ToString()].Color;
                    }
                }
                // Clear the first row
                for (int col = 0, loopTo1 = Columns - 1; col <= loopTo1; col++)
                    Cells["0," + col.ToString()].Fixed = false;
            }

            private CellPoint BlockToBoard(CellPoint p)
            {
                // Translate a block coordinate into a board coordinate
                return new CellPoint(p.Row + FallingBlock.Y, p.Column + FallingBlock.X);
            }

            private CellPoint BoardToBlock(CellPoint p)
            {
                // Translate a board coordinate into a block coordinate
                return new CellPoint(p.Row - FallingBlock.Y, p.Column - FallingBlock.X);
            }

            public Color GetCellColor(CellPoint p)
            {
                // Returns the color in which a cell must be painted. Defaults to Transparent, which means that the cell is empty.
                var output = Color.Transparent;
                if (Cells[p.Row.ToString() + "," + p.Column.ToString()].Fixed)
                {
                    // If the cell if fixed in the board, return its fixed color
                    output = Cells[p.Row.ToString() + "," + p.Column.ToString()].Color;
                }
                // If the cell is inside the 4x4 matrix of the falling block...
                else if (FallingBlock is object && CellIsInsideBlock(p.Row, p.Column))
                {
                    // Translate to block coordinates
                    var pt = BoardToBlock(p);
                    // If 
                    if (FallingBlock.FilledCell(pt.Column, pt.Row))
                    {
                        output = FallingBlock.Color;
                    }
                    // If Me.FallingBlock.CurrentMatrix(pt.Row).Substring(pt.Column, 1).Equals("1") Then
                    // End If
                }

                return output;
            }

            private bool CellIsInsideBlock(int row, int column)
            {
                // Returns true if the row,column coordinate (board system) is inside the current falling block 4x4 matrix
                return row >= FallingBlock.Y && row <= FallingBlock.Y + 3 && column >= FallingBlock.X && column <= FallingBlock.X + 3;
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */            // Argument for the FullRows event.
        public class FullRowsEventArgs : EventArgs
        {

            // Contains the number of rows filled at once, from 1 to 4. In the classic Tetris game, the more rows you filled at once, the more points are you rewarded with.
            public int NumberOfRows { get; set; } = 0;

            public FullRowsEventArgs(int numberOfRows)
            {
                NumberOfRows = numberOfRows;
            }
        }
        // Argument for the NewBlock event.
        public class NewBlockEventArgs : EventArgs
        {

            // This property notifies about the falling block type
            public int BlockType { get; set; } = 0;
            // This property notifies about the next falling block type
            public int NextBlockType { get; set; } = 0;

            public NewBlockEventArgs(int blockType, int nextBlockType)
            {
                BlockType = blockType;
                NextBlockType = nextBlockType;
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */    // Fires when the player completes entire rows
        public event FullRowsEventHandler FullRows;

        public delegate void FullRowsEventHandler(object sender, FullRowsEventArgs e);
        // Fires when a block reaches the top of the board and, therefore, overlaps with existing fixed cells
        public event GameOverEventHandler GameOver;

        public delegate void GameOverEventHandler(object sender, EventArgs e);
        // Fires when the game is about to start
        public event StartingEventHandler Starting;

        public delegate void StartingEventHandler(object sender, EventArgs e);
        // Fires every time a new block is created
        public event NewBlockEventHandler NewBlock;

        public delegate void NewBlockEventHandler(object sender, NewBlockEventArgs e);
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private int _rows = 20;       // Number of board rows. Internal storage for Rows property.
        private int _columns = 10;    // Number of board columns. Internal storage for Columns property.
        private int _cellSize = 25;   // Cell size (in pixels). Internal storage for CellSize property. [Board width = Columns x CellSize] [Board height = Rows x CellSize]
        private BackgroundStyles _backgroundStyle = BackgroundStyles.SolidColor;  // Background style. Internal storage for BackgroundStyle property.
        private Color _gradientColor1 = Color.SteelBlue;  // First gradient color. Internal storage for GradientColor1 property.
        private Color _gradientColor2 = Color.Black;      // Second gradient color. Internal storage for GradientColor2 property.
        private System.Drawing.Drawing2D.LinearGradientMode _gradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;  // Gradient direction. Internal storage for GradientDirection property.

        // Private _timer As System.Timers.Timer = Nothing     'Timer used to drop the falling block 1 row automatically.
        private Timer _timer = null;     // Timer used to drop the falling block 1 row automatically.
        private Board _board;                             // The board.
        private bool _running = false;                 // Stores a value indicating whether the game is running or not
        private bool _pause = false;                   // Stores a value indicating whether the game is paused or not

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public TetrisBox()
        {
            // Set DoubleBuffered to true to avoid screen-flickering.
            DoubleBuffered = true;
            // Instantiate the Timer and set a default interval of 1000 ms.

            // winforms setting
            // _timer = New Timers.Timer(1000)
            _timer = new Timer();

            // wisej setting
            _timer.Interval = 1000;

            // Set the SynchronizingObject of the timer (if not, the Elapsed event fires into its own subprocess and it's impossible to update the UI)

            // TODO: find equivalent property
            // _timer.SynchronizingObject = Me


            // Add a handler to the Elapsed event
            // winforms setting
            // AddHandler _timer.Elapsed, AddressOf TimerElapsed
            // wisejs setting
            _timer.Tick += TimerElapsed;
            // AddHandler Me.OnPaint, AddressOf XPaint


            Paint += Me_OnPaint;
            KeyDown += Me_hook_KeyDown;
        }


        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public Color RandomBlockColor { get; set; } = Color.LightYellow;       // The color of random-generated blocks (difficulty)
        public Color UncompleteRowColor { get; set; } = Color.LightYellow;     // The color of umcomplete rows (difficulty)
        public Keys LeftKey { get; set; } = Keys.Left;     // Allows to customize the Left key for the game (defaults to the left direction key)
        public Keys RightKey { get; set; } = Keys.Right;   // Allows to customize the Right key for the game (defaults to the right direction key)
        public Keys RotateKey { get; set; } = Keys.Up;     // Allows to customize the Rotate key for the game (defaults to the up direction key)
        public Keys DropKey { get; set; } = Keys.Down;     // Allows to customize the Drop key for the game (defaults to the down direction key)
        public Color Block1Color { get; set; } = Color.Red;        // Allows to customize the color of the type 1 blocks
        public Color Block2Color { get; set; } = Color.Blue;       // Allows to customize the color of the type 2 blocks
        public Color Block3Color { get; set; } = Color.Green;      // Allows to customize the color of the type 3 blocks
        public Color Block4Color { get; set; } = Color.Aqua;       // Allows to customize the color of the type 4 blocks
        public Color Block5Color { get; set; } = Color.Brown;      // Allows to customize the color of the type 5 blocks
        public Color Block6Color { get; set; } = Color.Yellow;     // Allows to customize the color of the type 6 blocks
        public Color Block7Color { get; set; } = Color.Purple;     // Allows to customize the color of the type 7 blocks
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */    // Gets or sets the Timer interval (game speed). The shorter interval, the higher speed.
        public int TimerInterval
        {
            get
            {
                return _timer.Interval;
            }

            set
            {
                _timer.Interval = value;
            }
        }

        // Gets or sets the first color of the gradient when BackgroundStyle = Gradient
        public Color GradientColor1
        {
            get
            {
                return _gradientColor1;
            }

            set
            {
                _gradientColor1 = value;
                if (BackgroundStyle == BackgroundStyles.Gradient)
                    Invalidate();
            }
        }

        // Gets or sets the second color of the gradient when BackgroundStyle = Gradient
        public Color GradientColor2
        {
            get
            {
                return _gradientColor2;
            }

            set
            {
                _gradientColor2 = value;
                if (BackgroundStyle == BackgroundStyles.Gradient)
                    Invalidate();
            }
        }

        // Gets or sets the direction of the gradient when BackgroundStyle = Gradient
        public System.Drawing.Drawing2D.LinearGradientMode GradientDirection
        {
            get
            {
                return _gradientDirection;
            }

            set
            {
                _gradientDirection = value;
                if (BackgroundStyle == BackgroundStyles.Gradient)
                    Invalidate();
            }
        }

        // Gets or sets the background style
        public BackgroundStyles BackgroundStyle
        {
            get
            {
                return _backgroundStyle;
            }

            set
            {
                _backgroundStyle = value;
                Invalidate();
            }
        }

        // Gets or sets the number of rows in the game board
        public int Rows
        {
            get
            {
                return _rows;
            }

            set
            {
                _rows = value;
                Invalidate();
            }
        }

        // Gets or sets the number of columns in the game board
        public int Columns
        {
            get
            {
                return _columns;
            }

            set
            {
                _columns = value;
                Invalidate();
            }
        }

        // Gets or sets the cell size (in pixels)
        public int CellSize
        {
            get
            {
                return _cellSize;
            }

            set
            {
                _cellSize = value;
                Invalidate();
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void Me_OnPaint(object sender, PaintEventArgs e)
        {

            // First, set the control's size
            Width = Columns * CellSize - (Columns - 1);
            Height = Rows * CellSize - (Rows - 1);

            // Draw the background
            switch (BackgroundStyle)
            {
                case BackgroundStyles.SolidColor:
                    {
                        // Draws a single color
                        e.Graphics.Clear(BackColor);
                        break;
                    }

                case BackgroundStyles.Gradient:
                    {
                        // Draws a gradient
                        using (var b = new System.Drawing.Drawing2D.LinearGradientBrush(DisplayRectangle, GradientColor1, GradientColor2, GradientDirection))
                        {
                            e.Graphics.FillRectangle(b, DisplayRectangle);
                        }

                        break;
                    }

                case BackgroundStyles.Picture:
                    {
                        // Draws a picture if BackgroundImage is set; if not, draws a single color
                        if (BackgroundImage is object)
                        {
                            e.Graphics.DrawImage(BackgroundImage, 0, 0, Width, Height);
                        }
                        else
                        {
                            e.Graphics.Clear(BackColor);
                        }

                        break;
                    }
            }

            // Paint cells
            if (_board is object)
            {
                for (int row = 0, loopTo = Rows - 1; row <= loopTo; row++)
                {
                    for (int column = 0, loopTo1 = Columns - 1; column <= loopTo1; column++)
                    {
                        // Get the cell color
                        var c = _board.GetCellColor(new CellPoint(row, column));
                        if (c != Color.Transparent)
                        {
                            // Draw the cell background
                            using (var b = new SolidBrush(c))
                            {
                                e.Graphics.FillRectangle(b, new Rectangle(column * (CellSize - 1), row * (CellSize - 1), CellSize - 1, CellSize - 1));
                            }
                            // Draw the cell border
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(column * (CellSize - 1), row * (CellSize - 1), CellSize - 1, CellSize - 1));
                        }
                    }
                }
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void StartGame()
        {
            // Starts a game
            if (!IsRunning() && !IsPaused())
            {
                // Initialize the ramdom number generator
                //VBMath.Randomize();


                // Initialize the game board
                _board = new Board(Rows, Columns);
                {
                    var withBlock = _board;
                    withBlock.Block1Color = Block1Color;
                    withBlock.Block2Color = Block2Color;
                    withBlock.Block3Color = Block3Color;
                    withBlock.Block4Color = Block4Color;
                    withBlock.Block5Color = Block5Color;
                    withBlock.Block6Color = Block6Color;
                    withBlock.Block7Color = Block7Color;
                }
                // Add handlers to catch board events
                _board.FullRows += CatchFullRows;
                _board.GameOver += CatchGameOver;
                _board.GotNewBlock += CatchNewBlock;
                // Set that the game is running
                _running = true;

                // Notify user
                Starting?.Invoke(this, new EventArgs());
                // Start the timer
                _timer.Start();
            }
        }

        public void StopGame()
        {
            // Stops a running game
            if (IsRunning())
            {
                // Stop the timer
                _timer.Stop();
                // Not running
                _running = false;
                // Not paused
                _pause = false;
            }
        }

        public int FreeRowsFromTop()
        {
            // In classic Tetris game, the game was not continuous, but the player should be playing among different screens, each one with its one goal. For example, the first
            // screen was an initial empty board and the player must play until he completes 5 full rows. In this game system, when a new screen was achieved, the game rewarded
            // the player not only for the full rows completed, but also for the completely free rows from the top of the board until the first not-completely free row. So you
            // can use this function to get the number of free rows from board's top.
            int freeRows = 0;
            if (_board is object)
            {
                for (int row = 0, loopTo = Rows - 1; row <= loopTo; row++)
                {
                    bool freeRow = true;
                    for (int column = 0, loopTo1 = Columns - 1; column <= loopTo1; column++)
                    {
                        if (_board.Cells[row.ToString() + "," + column.ToString()].Fixed)
                        {
                            freeRow = false;
                            break;
                        }
                    }

                    if (freeRow)
                    {
                        freeRows += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return freeRows;
        }

        public void AddRandomBlock()
        {
            // Adds a random block to the board. The block is always positioned over the board's bottom or a existing fixed cell.

            // Choose the column
            int whichColumn;
            do
                whichColumn = GetRandomNumber(0, Columns - 1);
            while (_board.Cells["0," + whichColumn.ToString()].Fixed);

            // Check for a fixed cell in the column to position the random block over it.
            for (int row = Rows - 1; row >= 0; row -= 1)
            {
                if (!_board.Cells[row.ToString() + "," + whichColumn.ToString()].Fixed)
                {
                    _board.Cells[row.ToString() + "," + whichColumn.ToString()].Fixed = true;
                    _board.Cells[row.ToString() + "," + whichColumn.ToString()].Color = RandomBlockColor;
                    Invalidate();
                    break;
                }
            }
        }

        public void AddUncompleteRow()
        {
            // Adds an uncomplete row at the bottom of the board, moving up the rest of the cells. This can cause a game over.
            bool forceGameOver = false;

            // If there's a fixed cell in first row, moving up the entire board will cause a game over
            if (ThereIsSomethingInFirstRow())
            {
                forceGameOver = true;
            }
            // Move all the board up 1 row
            for (int row = 0, loopTo = Rows - 2; row <= loopTo; row++)
            {
                for (int column = 0, loopTo1 = Columns - 1; column <= loopTo1; column++)
                {
                    _board.Cells[row.ToString() + "," + column.ToString()].Fixed = _board.Cells[(row + 1).ToString() + "," + column.ToString()].Fixed;
                    _board.Cells[row.ToString() + "," + column.ToString()].Color = _board.Cells[(row + 1).ToString() + "," + column.ToString()].Color;
                }
            }
            // Choose the empty column
            int emptyColumn = GetRandomNumber(0, Columns - 1);
            // Draw the uncomplete row
            for (int column = 0, loopTo2 = Columns - 1; column <= loopTo2; column++)
            {
                if (column.Equals(emptyColumn))
                {
                    _board.Cells[(Rows - 1).ToString() + "," + column.ToString()].Fixed = false;
                }
                else
                {
                    _board.Cells[(Rows - 1).ToString() + "," + column.ToString()].Fixed = true;
                    _board.Cells[(Rows - 1).ToString() + "," + column.ToString()].Color = UncompleteRowColor;
                }
            }
            // Redraw
            Invalidate();
        }

        public bool IsRunning()
        {
            // Returns True if a game is running
            return _running;
        }

        public bool IsPaused()
        {
            // Returns True if a game is paused
            return _pause;
        }

        public void Pause()
        {
            // Pauses a running game
            if (IsRunning() && !IsPaused())
            {
                _pause = true;
            }
        }

        public void Resume()
        {
            if (IsPaused())
            {
                _pause = false;
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        // Timer elapsed event
        private void TimerElapsed(object sender, EventArgs e)
        {
            if (!IsPaused())
            {
                // Redraw the board and check the current falling block
                RedrawAndCheckBlock();
                if (_board.FallingBlock is null)
                {
                    // If there's not a falling block, create new one
                    _board.NewBlock();
                    RedrawAndCheckBlock();
                }
                else
                {
                    // Drop the falling block 1 line
                    _board.FallingBlock.Y += 1;
                }
            }
        }

        // Redraws the board and checks the falling block
        private void RedrawAndCheckBlock()
        {
            Invalidate();
            _board.CheckBlock();
        }

        // Catches keystrokes
        // Private Sub _hook_KeyDown( Key As Wisej.Web.Keys) Handles _hook.KeyDown
        private void Me_hook_KeyDown(object sender, KeyEventArgs Key)
        {
            if (!IsPaused())
            {
                switch (Key.KeyData)
                {
                    case Keys.Left: // left 1
                        {
                            if (_board.MoveLeft())
                                RedrawAndCheckBlock();
                            break;
                        }

                    case Keys.Right: // 2
                        {
                            if (_board.MoveRight())
                                RedrawAndCheckBlock();
                            break;
                        }

                    case Keys.Up:     // 3
                        {
                            if (_board.Rotate())
                                RedrawAndCheckBlock();
                            break;
                        }

                    case Keys.Down: // 4
                        {
                            TimerElapsed(null, null);
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                // If Key = Me.LeftKey Then
                // If _board.MoveLeft() Then Call RedrawAndCheckBlock()
                // ElseIf Key = Me.RightKey Then
                // If _board.MoveRight() Then Call RedrawAndCheckBlock()
                // ElseIf Key = Me.DropKey Then
                // 'If the user presses the Drop key, force a 1-line drop
                // Call TimerElapsed(Nothing, Nothing)
                // ElseIf Key = Me.RotateKey Then
                // If _board.Rotate() Then Call RedrawAndCheckBlock()
                // End If
            }
        }

        // The board notifies that the player has completed full rows. Notify and redraw board.
        private void CatchFullRows(object sender, FullRowsEventArgs e)
        {
            FullRows?.Invoke(this, e);
            Invalidate();
        }

        // The board notifies that the game is over.
        private void CatchGameOver(object sender, EventArgs e)
        {
            // Stop the game
            StopGame();

            // Notify the user
            GameOver?.Invoke(this, e);
        }

        // The board notifies that a new block has been created. Notify.
        private void CatchNewBlock(object sender, NewBlockEventArgs e)
        {
            NewBlock?.Invoke(sender, e);
        }

        // Checks if there is a fixed cell in the first row
        private bool ThereIsSomethingInFirstRow()
        {
            bool output = false;
            for (int column = 0, loopTo = Columns - 1; column <= loopTo; column++)
            {
                if (_board.Cells["0," + column.ToString()].Fixed)
                {
                    output = true;
                    break;
                }
            }

            return output;
        }

        private int GetRandomNumber(int lowerbound, int upperbound)
        {
            // Get a random integer number as seen on MSDN
            //return (int)Math.Floor((upperbound - lowerbound + 1) * VBMath.Rnd()) + lowerbound;

            Random r = new Random();
            int rInt = r.Next(lowerbound, upperbound); //for ints

            return rInt;


        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}