using System;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
//using Microsoft.VisualBasic.CompilerServices;
using Wisej.Web;

namespace TetrisBoxWisej
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
            _lnkBackgroundPicture.Name = "lnkBackgroundPicture";
            _radBackgroundPicture.Name = "radBackgroundPicture";
            _cboGradientDirection.Name = "cboGradientDirection";
            _pnlBackgroundGradient2.Name = "pnlBackgroundGradient2";
            _pnlBackgroundGradient1.Name = "pnlBackgroundGradient1";
            _radBackgroundGradient.Name = "radBackgroundGradient";
            _pnlBackgroundSolid.Name = "pnlBackgroundSolid";
            _radBackgroundSolid.Name = "radBackgroundSolid";
            _numCellSize.Name = "numCellSize";
            _numColumns.Name = "numColumns";
            _numRows.Name = "numRows";
            _pnlBlock7Color.Name = "pnlBlock7Color";
            _pnlBlock6Color.Name = "pnlBlock6Color";
            _pnlBlock5Color.Name = "pnlBlock5Color";
            _pnlBlock4Color.Name = "pnlBlock4Color";
            _pnlBlock3Color.Name = "pnlBlock3Color";
            _pnlBlock2Color.Name = "pnlBlock2Color";
            _pnlBlock1Color.Name = "pnlBlock1Color";
            _cboKeysDrop.Name = "cboKeysDrop";
            _cboKeysRotate.Name = "cboKeysRotate";
            _cboKeysRight.Name = "cboKeysRight";
            _cboKeysLeft.Name = "cboKeysLeft";
            _pnlUncompleteLine.Name = "pnlUncompleteLine";
            _pnlRandomBlock.Name = "pnlRandomBlock";
            _tbrSpeed.Name = "tbrSpeed";
            _btnResume.Name = "btnResume";
            _btnPause.Name = "btnPause";
            _btnStop.Name = "btnStop";
            _btnStart.Name = "btnStart";
            _lnkArticle.Name = "lnkArticle";
            _linkWiseJ.Name = "linkWiseJ";
            _TetrisBox1.Name = "TetrisBox1";
        }

        private int _newBlocksNumber;

        private void pnlBackgroundSolid_Click(object sender, EventArgs e)
        {
            ManageColorProperty((Panel)sender, "BackColor");
        }

        private void ManageColorProperty(Panel sender, string propertyName)
        {
            {
                var withBlock = dlgColor;
                withBlock.Color = sender.BackColor;
                if ((int)withBlock.ShowDialog(this) == (int)System.Windows.Forms.DialogResult.OK)
                {
                    sender.BackColor = withBlock.Color;
                    Microsoft.VisualBasic.Interaction.CallByName(TetrisBox1, propertyName, CallType.Set, (object)withBlock.Color);
                }
            }
        }

        private void pnlBackgroundGradient1_Click(object sender, EventArgs e)
        {
            ManageColorProperty((Panel)sender, "GradientColor1");
        }

        private void pnlBackgroundGradient2_Click(object sender, EventArgs e)
        {
            ManageColorProperty((Panel)sender, "GradientColor2");
        }

        private void lnkBackgroundPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Windows.Forms.DialogResult.OK 
            if (dlgBackgroundPicture.ShowDialog(this) == DialogResult.OK)
            {
                TetrisBox1.BackgroundImage = Image.FromFile(dlgBackgroundPicture.FileName);
            }
        }

        private void radBackgroundSolid_CheckedChanged(object sender, EventArgs e)
        {
            switch (true)
            {
                case object _ when radBackgroundSolid.Checked:
                    {
                        TetrisBox1.BackgroundStyle = TetrisBox.BackgroundStyles.SolidColor;
                        break;
                    }

                case object _ when radBackgroundGradient.Checked:
                    {
                        TetrisBox1.BackgroundStyle = TetrisBox.BackgroundStyles.Gradient;
                        break;
                    }

                case object _ when radBackgroundPicture.Checked:
                    {
                        TetrisBox1.BackgroundStyle = TetrisBox.BackgroundStyles.Picture;
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGradientDirection.SelectedIndex = 1;
            foreach (string name in Enum.GetNames(typeof(System.Windows.Forms.Keys)))
            {
                cboKeysLeft.Items.Add(name);
                cboKeysRight.Items.Add(name);
                cboKeysRotate.Items.Add(name);
                cboKeysDrop.Items.Add(name);
            }

            cboKeysLeft.SelectedItem = "Left";
            cboKeysRight.SelectedItem = "Right";
            cboKeysRotate.SelectedItem = "Up";
            cboKeysDrop.SelectedItem = "Down";
        }

        private void cboGradientDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboGradientDirection.SelectedIndex)
            {
                case 0:
                    {
                        TetrisBox1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
                        break;
                    }

                case 1:
                    {
                        TetrisBox1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                        break;
                    }

                case 2:
                    {
                        TetrisBox1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
                        break;
                    }

                case 3:
                    {
                        TetrisBox1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
                        break;
                    }
            }
        }

        private void numRows_ValueChanged(object sender, EventArgs e)
        {
            TetrisBox1.Rows = (int)numRows.Value;
        }

        private void numColumns_ValueChanged(object sender, EventArgs e)
        {
            TetrisBox1.Columns = (int)numColumns.Value;
        }

        private void numCellSize_ValueChanged(object sender, EventArgs e)
        {
            TetrisBox1.CellSize = (int)numCellSize.Value;
        }

        private void pnlBlock1Color_Click(object sender, EventArgs e)
        {
            ManageColorProperty((Panel)sender, ((Panel)sender).Name.Replace("pnl", string.Empty));
        }

        private void cboKeysLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageKeyProperty((ComboBox)sender, "LeftKey");
        }

        private void ManageKeyProperty(ComboBox sender, string propertyName)
        {
            var names = Enum.GetNames(typeof(System.Windows.Forms.Keys));
            int[] values = (int[])Enum.GetValues(typeof(System.Windows.Forms.Keys));
            for (int index = 0, loopTo = names.Length - 1; index <= loopTo; index++)
            {
                if (sender.SelectedItem.Equals(names[index]))
                {

                    Microsoft.VisualBasic.Interaction.CallByName(TetrisBox1, propertyName, CallType.Set, (System.Windows.Forms.Keys)Conversions.ToInteger(values[index]));
                }
            }
        }

        private void cboKeysRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageKeyProperty((ComboBox)sender, "RightKey");
        }

        private void cboKeysRotate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageKeyProperty((ComboBox)sender, "RotateKey");
        }

        private void cboKeysDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageKeyProperty((ComboBox)sender, "DropKey");
        }

        private void pnlRandomBlock_Click(object sender, EventArgs e)
        {
            ManageColorProperty((Panel)sender, "RandomBlockColor");
        }

        private void pnlUncompleteLine_Click(object sender, EventArgs e)
        {
            ManageColorProperty((Panel)sender, "UncompleteRowColor");
        }

        private void tbrSpeed_Scroll(object sender, EventArgs e)
        {
            TetrisBox1.TimerInterval = tbrSpeed.Value;
            TetrisBox1.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            gbxBackground.Enabled = false;
            gbxBlockColors.Enabled = false;
            gbxBoardSize.Enabled = false;
            gbxDifficulties.Enabled = false;
            gbxKeys.Enabled = false;
            _newBlocksNumber = 0;
            TetrisBox1.StartGame();
            TetrisBox1.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TetrisBox1.StopGame();
            GameStopped();
        }

        private void GameStopped()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnResume.Enabled = false;
            gbxBackground.Enabled = true;
            gbxBlockColors.Enabled = true;
            gbxBoardSize.Enabled = true;
            gbxDifficulties.Enabled = true;
            gbxKeys.Enabled = true;
        }

        private void TetrisBox1_FullRows(object sender, TetrisBox.FullRowsEventArgs e)
        {
            lstEvents.Items.Add("FullRows [NumberOfRows=" + e.NumberOfRows.ToString() + "]");
        }

        private void TetrisBox1_GameOver(object sender, EventArgs e)
        {
            GameStopped();
            lstEvents.Items.Add("GameOver");
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            TetrisBox1.Pause();
            btnPause.Enabled = false;
            btnResume.Enabled = true;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            TetrisBox1.Resume();
            btnPause.Enabled = true;
            btnResume.Enabled = false;
            TetrisBox1.Focus();
        }

        private void TetrisBox1_NewBlock(object sender, TetrisBox.NewBlockEventArgs e)
        {
            lstEvents.Items.Add("NewBlock [BlockType=" + e.BlockType.ToString() + ", NextBlockType=" + e.NextBlockType.ToString() + "]");
            _newBlocksNumber += 1;
            if (chkRandomBlock.Checked && _newBlocksNumber % numRandomBlock.Value == 0m)
            {
                TetrisBox1.AddRandomBlock();
            }

            if (chkUncompleteLine.Checked && _newBlocksNumber % numUncompleteLine.Value == 0m)
            {
                TetrisBox1.AddUncompleteRow();
            }
        }

        private void TetrisBox1_Starting(object sender, EventArgs e)
        {
            lstEvents.Items.Add("Starting");
        }

        private void lnkArticle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.codeproject.com/Articles/812310/Create-Tetris-games-in-Net");
        }

        private void linkWiseJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.wisej.com");
        }
    }
}