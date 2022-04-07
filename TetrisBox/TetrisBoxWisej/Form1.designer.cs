using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Wisej.Web;

namespace TetrisBoxWisej
{
    [DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbxBackground = new GroupBox();
            _lnkBackgroundPicture = new LinkLabel();
            _lnkBackgroundPicture.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkBackgroundPicture_LinkClicked);
            _radBackgroundPicture = new RadioButton();
            _radBackgroundPicture.CheckedChanged += new EventHandler(radBackgroundSolid_CheckedChanged);
            _cboGradientDirection = new ComboBox();
            _cboGradientDirection.SelectedIndexChanged += new EventHandler(cboGradientDirection_SelectedIndexChanged);
            _pnlBackgroundGradient2 = new Panel();
            _pnlBackgroundGradient2.Click += new EventHandler(pnlBackgroundGradient2_Click);
            Label1 = new Label();
            _pnlBackgroundGradient1 = new Panel();
            _pnlBackgroundGradient1.Click += new EventHandler(pnlBackgroundGradient1_Click);
            _radBackgroundGradient = new RadioButton();
            _radBackgroundGradient.CheckedChanged += new EventHandler(radBackgroundSolid_CheckedChanged);
            _pnlBackgroundSolid = new Panel();
            _pnlBackgroundSolid.Click += new EventHandler(pnlBackgroundSolid_Click);
            _radBackgroundSolid = new RadioButton();
            _radBackgroundSolid.CheckedChanged += new EventHandler(radBackgroundSolid_CheckedChanged);
            dlgBackgroundPicture = new OpenFileDialog(components);
            dlgColor = new ColorDialog(components);
            gbxBoardSize = new GroupBox();
            Label4 = new Label();
            _numCellSize = new NumericUpDown();
            _numCellSize.ValueChanged += new EventHandler(numCellSize_ValueChanged);
            Label3 = new Label();
            _numColumns = new NumericUpDown();
            _numColumns.ValueChanged += new EventHandler(numColumns_ValueChanged);
            Label2 = new Label();
            _numRows = new NumericUpDown();
            _numRows.ValueChanged += new EventHandler(numRows_ValueChanged);
            gbxBlockColors = new GroupBox();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            _pnlBlock7Color = new Panel();
            _pnlBlock7Color.Click += new EventHandler(pnlBlock1Color_Click);
            _pnlBlock6Color = new Panel();
            _pnlBlock6Color.Click += new EventHandler(pnlBlock1Color_Click);
            _pnlBlock5Color = new Panel();
            _pnlBlock5Color.Click += new EventHandler(pnlBlock1Color_Click);
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            _pnlBlock4Color = new Panel();
            _pnlBlock4Color.Click += new EventHandler(pnlBlock1Color_Click);
            _pnlBlock3Color = new Panel();
            _pnlBlock3Color.Click += new EventHandler(pnlBlock1Color_Click);
            _pnlBlock2Color = new Panel();
            _pnlBlock2Color.Click += new EventHandler(pnlBlock1Color_Click);
            _pnlBlock1Color = new Panel();
            _pnlBlock1Color.Click += new EventHandler(pnlBlock1Color_Click);
            gbxKeys = new GroupBox();
            Label15 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            Label12 = new Label();
            _cboKeysDrop = new ComboBox();
            _cboKeysDrop.SelectedIndexChanged += new EventHandler(cboKeysDrop_SelectedIndexChanged);
            _cboKeysRotate = new ComboBox();
            _cboKeysRotate.SelectedIndexChanged += new EventHandler(cboKeysRotate_SelectedIndexChanged);
            _cboKeysRight = new ComboBox();
            _cboKeysRight.SelectedIndexChanged += new EventHandler(cboKeysRight_SelectedIndexChanged);
            _cboKeysLeft = new ComboBox();
            _cboKeysLeft.SelectedIndexChanged += new EventHandler(cboKeysLeft_SelectedIndexChanged);
            gbxDifficulties = new GroupBox();
            Label19 = new Label();
            _pnlUncompleteLine = new Panel();
            _pnlUncompleteLine.Click += new EventHandler(pnlUncompleteLine_Click);
            Label18 = new Label();
            numUncompleteLine = new NumericUpDown();
            chkUncompleteLine = new CheckBox();
            _pnlRandomBlock = new Panel();
            _pnlRandomBlock.Click += new EventHandler(pnlRandomBlock_Click);
            Label17 = new Label();
            Label16 = new Label();
            numRandomBlock = new NumericUpDown();
            chkRandomBlock = new CheckBox();
            GroupBox6 = new GroupBox();
            Label22 = new Label();
            Label21 = new Label();
            Label20 = new Label();
            _tbrSpeed = new TrackBar();
            _tbrSpeed.Scroll += new EventHandler(tbrSpeed_Scroll);
            _tbrSpeed.ValueChanged += new EventHandler(tbrSpeed_Scroll);
            _tbrSpeed.Scroll += new EventHandler(tbrSpeed_Scroll);
            _tbrSpeed.ValueChanged += new EventHandler(tbrSpeed_Scroll);
            _btnResume = new Button();
            _btnResume.Click += new EventHandler(btnResume_Click);
            _btnPause = new Button();
            _btnPause.Click += new EventHandler(btnPause_Click);
            _btnStop = new Button();
            _btnStop.Click += new EventHandler(btnStop_Click);
            _btnStart = new Button();
            _btnStart.Click += new EventHandler(btnStart_Click);
            GroupBox7 = new GroupBox();
            lstEvents = new ListBox();
            Label23 = new Label();
            _lnkArticle = new LinkLabel();
            _lnkArticle.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkArticle_LinkClicked);
            _linkWiseJ = new LinkLabel();
            _linkWiseJ.LinkClicked += new LinkLabelLinkClickedEventHandler(linkWiseJ_LinkClicked);
            _TetrisBox1 = new TetrisBox();
            _TetrisBox1.FullRows += new TetrisBox.FullRowsEventHandler(TetrisBox1_FullRows);
            _TetrisBox1.GameOver += new TetrisBox.GameOverEventHandler(TetrisBox1_GameOver);
            _TetrisBox1.NewBlock += new TetrisBox.NewBlockEventHandler(TetrisBox1_NewBlock);
            _TetrisBox1.Starting += new TetrisBox.StartingEventHandler(TetrisBox1_Starting);
            gbxBackground.SuspendLayout();
            gbxBoardSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_numCellSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numRows).BeginInit();
            gbxBlockColors.SuspendLayout();
            gbxKeys.SuspendLayout();
            gbxDifficulties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUncompleteLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRandomBlock).BeginInit();
            GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_tbrSpeed).BeginInit();
            GroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TetrisBox1).BeginInit();
            SuspendLayout();
            // 
            // gbxBackground
            // 
            gbxBackground.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbxBackground.Controls.Add(_lnkBackgroundPicture);
            gbxBackground.Controls.Add(_radBackgroundPicture);
            gbxBackground.Controls.Add(_cboGradientDirection);
            gbxBackground.Controls.Add(_pnlBackgroundGradient2);
            gbxBackground.Controls.Add(Label1);
            gbxBackground.Controls.Add(_pnlBackgroundGradient1);
            gbxBackground.Controls.Add(_radBackgroundGradient);
            gbxBackground.Controls.Add(_pnlBackgroundSolid);
            gbxBackground.Controls.Add(_radBackgroundSolid);
            gbxBackground.Location = new System.Drawing.Point(691, 14);
            gbxBackground.Name = "gbxBackground";
            gbxBackground.Size = new System.Drawing.Size(305, 113);
            gbxBackground.TabIndex = 1;
            gbxBackground.Text = "Background";
            // 
            // lnkBackgroundPicture
            // 
            _lnkBackgroundPicture.AutoSize = true;
            _lnkBackgroundPicture.Location = new System.Drawing.Point(91, 93);
            _lnkBackgroundPicture.Name = "_lnkBackgroundPicture";
            _lnkBackgroundPicture.Size = new System.Drawing.Size(83, 16);
            _lnkBackgroundPicture.TabIndex = 8;
            _lnkBackgroundPicture.Text = "Select picture...";
            // 
            // radBackgroundPicture
            // 
            _radBackgroundPicture.Cursor = Cursors.Hand;
            _radBackgroundPicture.Location = new System.Drawing.Point(4, 89);
            _radBackgroundPicture.Name = "_radBackgroundPicture";
            _radBackgroundPicture.Size = new System.Drawing.Size(68, 23);
            _radBackgroundPicture.TabIndex = 7;
            _radBackgroundPicture.Text = "Picture";
            // 
            // cboGradientDirection
            // 
            _cboGradientDirection.Cursor = Cursors.Hand;
            _cboGradientDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboGradientDirection.FormattingEnabled = true;
            _cboGradientDirection.Items.AddRange(new object[] { "Horizontal", "Vertical", "ForwardDiagonal", "BackwardDiagonal" });
            _cboGradientDirection.Location = new System.Drawing.Point(163, 59);
            _cboGradientDirection.Name = "_cboGradientDirection";
            _cboGradientDirection.Size = new System.Drawing.Size(114, 22);
            _cboGradientDirection.TabIndex = 6;
            // 
            // pnlBackgroundGradient2
            // 
            _pnlBackgroundGradient2.BackColor = System.Drawing.Color.Black;
            _pnlBackgroundGradient2.BorderStyle = BorderStyle.Solid;
            _pnlBackgroundGradient2.Cursor = Cursors.Hand;
            _pnlBackgroundGradient2.Location = new System.Drawing.Point(135, 60);
            _pnlBackgroundGradient2.Name = "_pnlBackgroundGradient2";
            _pnlBackgroundGradient2.Size = new System.Drawing.Size(25, 24);
            _pnlBackgroundGradient2.TabIndex = 5;
            _pnlBackgroundGradient2.TabStop = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(117, 63);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(15, 16);
            Label1.TabIndex = 4;
            Label1.Text = "to";
            // 
            // pnlBackgroundGradient1
            // 
            _pnlBackgroundGradient1.BackColor = System.Drawing.Color.SteelBlue;
            _pnlBackgroundGradient1.BorderStyle = BorderStyle.Solid;
            _pnlBackgroundGradient1.Cursor = Cursors.Hand;
            _pnlBackgroundGradient1.Location = new System.Drawing.Point(89, 60);
            _pnlBackgroundGradient1.Name = "_pnlBackgroundGradient1";
            _pnlBackgroundGradient1.Size = new System.Drawing.Size(25, 24);
            _pnlBackgroundGradient1.TabIndex = 3;
            _pnlBackgroundGradient1.TabStop = true;
            // 
            // radBackgroundGradient
            // 
            _radBackgroundGradient.Cursor = Cursors.Hand;
            _radBackgroundGradient.Location = new System.Drawing.Point(4, 60);
            _radBackgroundGradient.Name = "_radBackgroundGradient";
            _radBackgroundGradient.Size = new System.Drawing.Size(78, 23);
            _radBackgroundGradient.TabIndex = 2;
            _radBackgroundGradient.Text = "Gradient";
            // 
            // pnlBackgroundSolid
            // 
            _pnlBackgroundSolid.BackColor = System.Drawing.Color.SteelBlue;
            _pnlBackgroundSolid.BorderStyle = BorderStyle.Solid;
            _pnlBackgroundSolid.Cursor = Cursors.Hand;
            _pnlBackgroundSolid.Location = new System.Drawing.Point(89, 28);
            _pnlBackgroundSolid.Name = "_pnlBackgroundSolid";
            _pnlBackgroundSolid.Size = new System.Drawing.Size(25, 24);
            _pnlBackgroundSolid.TabIndex = 1;
            _pnlBackgroundSolid.TabStop = true;
            // 
            // radBackgroundSolid
            // 
            _radBackgroundSolid.Checked = true;
            _radBackgroundSolid.Cursor = Cursors.Hand;
            _radBackgroundSolid.Location = new System.Drawing.Point(4, 28);
            _radBackgroundSolid.Name = "_radBackgroundSolid";
            _radBackgroundSolid.Size = new System.Drawing.Size(88, 23);
            _radBackgroundSolid.TabIndex = 0;
            _radBackgroundSolid.TabStop = true;
            _radBackgroundSolid.Text = "Solid color";
            // 
            // dlgBackgroundPicture
            // 
            dlgBackgroundPicture.Filter = "Picture files|*.jpg;*.png;*.gif;*.bmp";
            dlgBackgroundPicture.Title = "Select background picture";
            // 
            // gbxBoardSize
            // 
            gbxBoardSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbxBoardSize.Controls.Add(Label4);
            gbxBoardSize.Controls.Add(_numCellSize);
            gbxBoardSize.Controls.Add(Label3);
            gbxBoardSize.Controls.Add(_numColumns);
            gbxBoardSize.Controls.Add(Label2);
            gbxBoardSize.Controls.Add(_numRows);
            gbxBoardSize.Location = new System.Drawing.Point(691, 133);
            gbxBoardSize.Name = "gbxBoardSize";
            gbxBoardSize.Size = new System.Drawing.Size(305, 128);
            gbxBoardSize.TabIndex = 2;
            gbxBoardSize.Text = "Board size";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new System.Drawing.Point(4, 105);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(49, 16);
            Label4.TabIndex = 9;
            Label4.Text = "Cell size:";
            // 
            // numCellSize
            // 
            _numCellSize.Location = new System.Drawing.Point(91, 103);
            _numCellSize.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            _numCellSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            _numCellSize.Name = "_numCellSize";
            _numCellSize.Size = new System.Drawing.Size(70, 22);
            _numCellSize.TabIndex = 8;
            _numCellSize.TextAlign = HorizontalAlignment.Right;
            _numCellSize.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(4, 68);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(53, 16);
            Label3.TabIndex = 7;
            Label3.Text = "Columns:";
            // 
            // numColumns
            // 
            _numColumns.Location = new System.Drawing.Point(91, 66);
            _numColumns.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            _numColumns.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            _numColumns.Name = "_numColumns";
            _numColumns.Size = new System.Drawing.Size(70, 22);
            _numColumns.TabIndex = 6;
            _numColumns.TextAlign = HorizontalAlignment.Right;
            _numColumns.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new System.Drawing.Point(4, 31);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(35, 16);
            Label2.TabIndex = 5;
            Label2.Text = "Rows:";
            // 
            // numRows
            // 
            _numRows.Location = new System.Drawing.Point(91, 28);
            _numRows.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            _numRows.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            _numRows.Name = "_numRows";
            _numRows.Size = new System.Drawing.Size(70, 22);
            _numRows.TabIndex = 0;
            _numRows.TextAlign = HorizontalAlignment.Right;
            _numRows.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // gbxBlockColors
            // 
            gbxBlockColors.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbxBlockColors.Controls.Add(Label11);
            gbxBlockColors.Controls.Add(Label10);
            gbxBlockColors.Controls.Add(Label9);
            gbxBlockColors.Controls.Add(_pnlBlock7Color);
            gbxBlockColors.Controls.Add(_pnlBlock6Color);
            gbxBlockColors.Controls.Add(_pnlBlock5Color);
            gbxBlockColors.Controls.Add(Label8);
            gbxBlockColors.Controls.Add(Label7);
            gbxBlockColors.Controls.Add(Label6);
            gbxBlockColors.Controls.Add(Label5);
            gbxBlockColors.Controls.Add(_pnlBlock4Color);
            gbxBlockColors.Controls.Add(_pnlBlock3Color);
            gbxBlockColors.Controls.Add(_pnlBlock2Color);
            gbxBlockColors.Controls.Add(_pnlBlock1Color);
            gbxBlockColors.Location = new System.Drawing.Point(691, 267);
            gbxBlockColors.Name = "gbxBlockColors";
            gbxBlockColors.Size = new System.Drawing.Size(305, 145);
            gbxBlockColors.TabIndex = 3;
            gbxBlockColors.Text = "Block colors";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new System.Drawing.Point(131, 95);
            Label11.Name = "Label11";
            Label11.Size = new System.Drawing.Size(73, 16);
            Label11.TabIndex = 17;
            Label11.Text = "Type 7 Block:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new System.Drawing.Point(131, 63);
            Label10.Name = "Label10";
            Label10.Size = new System.Drawing.Size(73, 16);
            Label10.TabIndex = 16;
            Label10.Text = "Type 6 Block:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new System.Drawing.Point(131, 31);
            Label9.Name = "Label9";
            Label9.Size = new System.Drawing.Size(73, 16);
            Label9.TabIndex = 15;
            Label9.Text = "Type 5 Block:";
            // 
            // pnlBlock7Color
            // 
            _pnlBlock7Color.BackColor = System.Drawing.Color.Purple;
            _pnlBlock7Color.BorderStyle = BorderStyle.Solid;
            _pnlBlock7Color.Cursor = Cursors.Hand;
            _pnlBlock7Color.Location = new System.Drawing.Point(216, 87);
            _pnlBlock7Color.Name = "_pnlBlock7Color";
            _pnlBlock7Color.Size = new System.Drawing.Size(25, 24);
            _pnlBlock7Color.TabIndex = 14;
            _pnlBlock7Color.TabStop = true;
            // 
            // pnlBlock6Color
            // 
            _pnlBlock6Color.BackColor = System.Drawing.Color.Yellow;
            _pnlBlock6Color.BorderStyle = BorderStyle.Solid;
            _pnlBlock6Color.Cursor = Cursors.Hand;
            _pnlBlock6Color.Location = new System.Drawing.Point(216, 54);
            _pnlBlock6Color.Name = "_pnlBlock6Color";
            _pnlBlock6Color.Size = new System.Drawing.Size(25, 24);
            _pnlBlock6Color.TabIndex = 13;
            _pnlBlock6Color.TabStop = true;
            // 
            // pnlBlock5Color
            // 
            _pnlBlock5Color.BackColor = System.Drawing.Color.Brown;
            _pnlBlock5Color.BorderStyle = BorderStyle.Solid;
            _pnlBlock5Color.Cursor = Cursors.Hand;
            _pnlBlock5Color.Location = new System.Drawing.Point(216, 22);
            _pnlBlock5Color.Name = "_pnlBlock5Color";
            _pnlBlock5Color.Size = new System.Drawing.Size(25, 24);
            _pnlBlock5Color.TabIndex = 12;
            _pnlBlock5Color.TabStop = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new System.Drawing.Point(4, 127);
            Label8.Name = "Label8";
            Label8.Size = new System.Drawing.Size(73, 16);
            Label8.TabIndex = 11;
            Label8.Text = "Type 4 Block:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new System.Drawing.Point(4, 95);
            Label7.Name = "Label7";
            Label7.Size = new System.Drawing.Size(73, 16);
            Label7.TabIndex = 10;
            Label7.Text = "Type 3 Block:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new System.Drawing.Point(4, 63);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(73, 16);
            Label6.TabIndex = 9;
            Label6.Text = "Type 2 Block:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new System.Drawing.Point(4, 31);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(73, 16);
            Label5.TabIndex = 8;
            Label5.Text = "Type 1 Block:";
            // 
            // pnlBlock4Color
            // 
            _pnlBlock4Color.BackColor = System.Drawing.Color.Aqua;
            _pnlBlock4Color.BorderStyle = BorderStyle.Solid;
            _pnlBlock4Color.Cursor = Cursors.Hand;
            _pnlBlock4Color.Location = new System.Drawing.Point(90, 119);
            _pnlBlock4Color.Name = "_pnlBlock4Color";
            _pnlBlock4Color.Size = new System.Drawing.Size(25, 24);
            _pnlBlock4Color.TabIndex = 5;
            _pnlBlock4Color.TabStop = true;
            // 
            // pnlBlock3Color
            // 
            _pnlBlock3Color.BackColor = System.Drawing.Color.Green;
            _pnlBlock3Color.BorderStyle = BorderStyle.Solid;
            _pnlBlock3Color.Cursor = Cursors.Hand;
            _pnlBlock3Color.Location = new System.Drawing.Point(90, 87);
            _pnlBlock3Color.Name = "_pnlBlock3Color";
            _pnlBlock3Color.Size = new System.Drawing.Size(25, 24);
            _pnlBlock3Color.TabIndex = 4;
            _pnlBlock3Color.TabStop = true;
            // 
            // pnlBlock2Color
            // 
            _pnlBlock2Color.BackColor = System.Drawing.Color.Blue;
            _pnlBlock2Color.BorderStyle = BorderStyle.Solid;
            _pnlBlock2Color.Cursor = Cursors.Hand;
            _pnlBlock2Color.Location = new System.Drawing.Point(90, 54);
            _pnlBlock2Color.Name = "_pnlBlock2Color";
            _pnlBlock2Color.Size = new System.Drawing.Size(25, 24);
            _pnlBlock2Color.TabIndex = 3;
            _pnlBlock2Color.TabStop = true;
            // 
            // pnlBlock1Color
            // 
            _pnlBlock1Color.BackColor = System.Drawing.Color.Red;
            _pnlBlock1Color.BorderStyle = BorderStyle.Solid;
            _pnlBlock1Color.Cursor = Cursors.Hand;
            _pnlBlock1Color.Location = new System.Drawing.Point(90, 22);
            _pnlBlock1Color.Name = "_pnlBlock1Color";
            _pnlBlock1Color.Size = new System.Drawing.Size(25, 24);
            _pnlBlock1Color.TabIndex = 2;
            _pnlBlock1Color.TabStop = true;
            // 
            // gbxKeys
            // 
            gbxKeys.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbxKeys.Controls.Add(Label15);
            gbxKeys.Controls.Add(Label14);
            gbxKeys.Controls.Add(Label13);
            gbxKeys.Controls.Add(Label12);
            gbxKeys.Controls.Add(_cboKeysDrop);
            gbxKeys.Controls.Add(_cboKeysRotate);
            gbxKeys.Controls.Add(_cboKeysRight);
            gbxKeys.Controls.Add(_cboKeysLeft);
            gbxKeys.Location = new System.Drawing.Point(691, 419);
            gbxKeys.Name = "gbxKeys";
            gbxKeys.Size = new System.Drawing.Size(305, 96);
            gbxKeys.TabIndex = 4;
            gbxKeys.Text = "Keys";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new System.Drawing.Point(140, 69);
            Label15.Name = "Label15";
            Label15.Size = new System.Drawing.Size(33, 16);
            Label15.TabIndex = 14;
            Label15.Text = "Drop:";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new System.Drawing.Point(140, 32);
            Label14.Name = "Label14";
            Label14.Size = new System.Drawing.Size(41, 16);
            Label14.TabIndex = 13;
            Label14.Text = "Rotate:";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new System.Drawing.Point(4, 69);
            Label13.Name = "Label13";
            Label13.Size = new System.Drawing.Size(35, 16);
            Label13.TabIndex = 12;
            Label13.Text = "Right:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new System.Drawing.Point(4, 32);
            Label12.Name = "Label12";
            Label12.Size = new System.Drawing.Size(26, 16);
            Label12.TabIndex = 11;
            Label12.Text = "Left:";
            // 
            // cboKeysDrop
            // 
            _cboKeysDrop.Cursor = Cursors.Hand;
            _cboKeysDrop.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboKeysDrop.FormattingEnabled = true;
            _cboKeysDrop.Location = new System.Drawing.Point(182, 66);
            _cboKeysDrop.Name = "_cboKeysDrop";
            _cboKeysDrop.Size = new System.Drawing.Size(81, 22);
            _cboKeysDrop.Sorted = true;
            _cboKeysDrop.TabIndex = 10;
            // 
            // cboKeysRotate
            // 
            _cboKeysRotate.Cursor = Cursors.Hand;
            _cboKeysRotate.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboKeysRotate.FormattingEnabled = true;
            _cboKeysRotate.Location = new System.Drawing.Point(182, 28);
            _cboKeysRotate.Name = "_cboKeysRotate";
            _cboKeysRotate.Size = new System.Drawing.Size(81, 22);
            _cboKeysRotate.Sorted = true;
            _cboKeysRotate.TabIndex = 9;
            // 
            // cboKeysRight
            // 
            _cboKeysRight.Cursor = Cursors.Hand;
            _cboKeysRight.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboKeysRight.FormattingEnabled = true;
            _cboKeysRight.Location = new System.Drawing.Point(43, 66);
            _cboKeysRight.Name = "_cboKeysRight";
            _cboKeysRight.Size = new System.Drawing.Size(81, 22);
            _cboKeysRight.Sorted = true;
            _cboKeysRight.TabIndex = 8;
            // 
            // cboKeysLeft
            // 
            _cboKeysLeft.Cursor = Cursors.Hand;
            _cboKeysLeft.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboKeysLeft.FormattingEnabled = true;
            _cboKeysLeft.Location = new System.Drawing.Point(43, 28);
            _cboKeysLeft.Name = "_cboKeysLeft";
            _cboKeysLeft.Size = new System.Drawing.Size(81, 22);
            _cboKeysLeft.Sorted = true;
            _cboKeysLeft.TabIndex = 7;
            // 
            // gbxDifficulties
            // 
            gbxDifficulties.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbxDifficulties.Controls.Add(Label19);
            gbxDifficulties.Controls.Add(_pnlUncompleteLine);
            gbxDifficulties.Controls.Add(Label18);
            gbxDifficulties.Controls.Add(numUncompleteLine);
            gbxDifficulties.Controls.Add(chkUncompleteLine);
            gbxDifficulties.Controls.Add(_pnlRandomBlock);
            gbxDifficulties.Controls.Add(Label17);
            gbxDifficulties.Controls.Add(Label16);
            gbxDifficulties.Controls.Add(numRandomBlock);
            gbxDifficulties.Controls.Add(chkRandomBlock);
            gbxDifficulties.Location = new System.Drawing.Point(691, 522);
            gbxDifficulties.Name = "gbxDifficulties";
            gbxDifficulties.Size = new System.Drawing.Size(305, 187);
            gbxDifficulties.TabIndex = 5;
            gbxDifficulties.Text = "Difficulties";
            // 
            // Label19
            // 
            Label19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Label19.AutoSize = true;
            Label19.Location = new System.Drawing.Point(17, 147);
            Label19.Name = "Label19";
            Label19.Size = new System.Drawing.Size(69, 32);
            Label19.TabIndex = 19;
            Label19.Text = "Uncomplete lines color:";
            // 
            // pnlUncompleteLine
            // 
            _pnlUncompleteLine.BackColor = System.Drawing.Color.Orange;
            _pnlUncompleteLine.BorderStyle = BorderStyle.Solid;
            _pnlUncompleteLine.Cursor = Cursors.Hand;
            _pnlUncompleteLine.Location = new System.Drawing.Point(148, 144);
            _pnlUncompleteLine.Name = "_pnlUncompleteLine";
            _pnlUncompleteLine.Size = new System.Drawing.Size(25, 24);
            _pnlUncompleteLine.TabIndex = 18;
            _pnlUncompleteLine.TabStop = true;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Location = new System.Drawing.Point(236, 101);
            Label18.Name = "Label18";
            Label18.Size = new System.Drawing.Size(63, 16);
            Label18.TabIndex = 17;
            Label18.Text = "new blocks";
            // 
            // numUncompleteLine
            // 
            numUncompleteLine.Location = new System.Drawing.Point(167, 98);
            numUncompleteLine.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numUncompleteLine.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numUncompleteLine.Name = "numUncompleteLine";
            numUncompleteLine.Size = new System.Drawing.Size(63, 22);
            numUncompleteLine.TabIndex = 16;
            numUncompleteLine.TextAlign = HorizontalAlignment.Right;
            numUncompleteLine.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // chkUncompleteLine
            // 
            chkUncompleteLine.AutoSize = false;
            chkUncompleteLine.Cursor = Cursors.Hand;
            chkUncompleteLine.Location = new System.Drawing.Point(4, 94);
            chkUncompleteLine.Name = "chkUncompleteLine";
            chkUncompleteLine.Size = new System.Drawing.Size(135, 36);
            chkUncompleteLine.TabIndex = 15;
            chkUncompleteLine.Text = "Add an uncomplete line every";
            // 
            // pnlRandomBlock
            // 
            _pnlRandomBlock.BackColor = System.Drawing.Color.Orange;
            _pnlRandomBlock.BorderStyle = BorderStyle.Solid;
            _pnlRandomBlock.Cursor = Cursors.Hand;
            _pnlRandomBlock.Location = new System.Drawing.Point(148, 64);
            _pnlRandomBlock.Name = "_pnlRandomBlock";
            _pnlRandomBlock.Size = new System.Drawing.Size(25, 24);
            _pnlRandomBlock.TabIndex = 14;
            _pnlRandomBlock.TabStop = true;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new System.Drawing.Point(11, 72);
            Label17.Name = "Label17";
            Label17.Size = new System.Drawing.Size(118, 16);
            Label17.TabIndex = 13;
            Label17.Text = "Random blocks color:";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new System.Drawing.Point(236, 26);
            Label16.Name = "Label16";
            Label16.Size = new System.Drawing.Size(63, 16);
            Label16.TabIndex = 12;
            Label16.Text = "new blocks";
            // 
            // numRandomBlock
            // 
            numRandomBlock.Location = new System.Drawing.Point(165, 26);
            numRandomBlock.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numRandomBlock.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numRandomBlock.Name = "numRandomBlock";
            numRandomBlock.Size = new System.Drawing.Size(65, 22);
            numRandomBlock.TabIndex = 1;
            numRandomBlock.TextAlign = HorizontalAlignment.Right;
            numRandomBlock.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // chkRandomBlock
            // 
            chkRandomBlock.AutoSize = false;
            chkRandomBlock.Cursor = Cursors.Hand;
            chkRandomBlock.Location = new System.Drawing.Point(4, 19);
            chkRandomBlock.Name = "chkRandomBlock";
            chkRandomBlock.Size = new System.Drawing.Size(155, 39);
            chkRandomBlock.TabIndex = 0;
            chkRandomBlock.Text = "Add a random single-cell block every";
            // 
            // GroupBox6
            // 
            GroupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GroupBox6.Controls.Add(Label22);
            GroupBox6.Controls.Add(Label21);
            GroupBox6.Controls.Add(Label20);
            GroupBox6.Controls.Add(_tbrSpeed);
            GroupBox6.Controls.Add(_btnResume);
            GroupBox6.Controls.Add(_btnPause);
            GroupBox6.Controls.Add(_btnStop);
            GroupBox6.Controls.Add(_btnStart);
            GroupBox6.Location = new System.Drawing.Point(463, 14);
            GroupBox6.Name = "GroupBox6";
            GroupBox6.Size = new System.Drawing.Size(223, 184);
            GroupBox6.TabIndex = 6;
            GroupBox6.Text = "Game control";
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Location = new System.Drawing.Point(4, 181);
            Label22.Name = "Label22";
            Label22.Size = new System.Drawing.Size(36, 16);
            Label22.TabIndex = 7;
            Label22.Text = "Faster";
            // 
            // Label21
            // 
            Label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label21.AutoSize = true;
            Label21.Location = new System.Drawing.Point(147, 181);
            Label21.Name = "Label21";
            Label21.Size = new System.Drawing.Size(39, 16);
            Label21.TabIndex = 6;
            Label21.Text = "Slower";
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Location = new System.Drawing.Point(4, 119);
            Label20.Name = "Label20";
            Label20.Size = new System.Drawing.Size(70, 16);
            Label20.TabIndex = 5;
            Label20.Text = "Game speed";
            // 
            // tbrSpeed
            // 
            _tbrSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _tbrSpeed.Location = new System.Drawing.Point(4, 143);
            _tbrSpeed.Maximum = 1000;
            _tbrSpeed.Minimum = 100;
            _tbrSpeed.Name = "_tbrSpeed";
            _tbrSpeed.Size = new System.Drawing.Size(186, 34);
            _tbrSpeed.TabIndex = 4;
            _tbrSpeed.TickStyle = TickStyle.None;
            _tbrSpeed.Value = 1000;
            // 
            // btnResume
            // 
            _btnResume.Cursor = Cursors.Hand;
            _btnResume.Enabled = false;
            _btnResume.Location = new System.Drawing.Point(100, 70);
            _btnResume.Name = "_btnResume";
            _btnResume.Size = new System.Drawing.Size(85, 35);
            _btnResume.TabIndex = 3;
            _btnResume.Text = "Resume";
            // 
            // btnPause
            // 
            _btnPause.Cursor = Cursors.Hand;
            _btnPause.Enabled = false;
            _btnPause.Location = new System.Drawing.Point(4, 70);
            _btnPause.Name = "_btnPause";
            _btnPause.Size = new System.Drawing.Size(86, 35);
            _btnPause.TabIndex = 2;
            _btnPause.Text = "Pause";
            // 
            // btnStop
            // 
            _btnStop.Cursor = Cursors.Hand;
            _btnStop.Enabled = false;
            _btnStop.Location = new System.Drawing.Point(100, 28);
            _btnStop.Name = "_btnStop";
            _btnStop.Size = new System.Drawing.Size(86, 35);
            _btnStop.TabIndex = 1;
            _btnStop.Text = "Stop";
            // 
            // btnStart
            // 
            _btnStart.Cursor = Cursors.Hand;
            _btnStart.Location = new System.Drawing.Point(4, 28);
            _btnStart.Name = "_btnStart";
            _btnStart.Size = new System.Drawing.Size(86, 35);
            _btnStart.TabIndex = 0;
            _btnStart.Text = "Start";
            // 
            // GroupBox7
            // 
            GroupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GroupBox7.Controls.Add(lstEvents);
            GroupBox7.Location = new System.Drawing.Point(463, 204);
            GroupBox7.Name = "GroupBox7";
            GroupBox7.Size = new System.Drawing.Size(223, 505);
            GroupBox7.TabIndex = 7;
            GroupBox7.Text = "Events";
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.ItemHeight = 15;
            lstEvents.Location = new System.Drawing.Point(7, 28);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new System.Drawing.Size(180, 471);
            lstEvents.TabIndex = 0;
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.Location = new System.Drawing.Point(466, 746);
            Label23.Name = "Label23";
            Label23.Size = new System.Drawing.Size(133, 16);
            Label23.TabIndex = 8;
            Label23.Text = "Original winform project";
            // 
            // lnkArticle
            // 
            _lnkArticle.AutoSize = true;
            _lnkArticle.Location = new System.Drawing.Point(605, 746);
            _lnkArticle.Name = "_lnkArticle";
            _lnkArticle.Size = new System.Drawing.Size(259, 16);
            _lnkArticle.TabIndex = 9;
            _lnkArticle.Text = "Codeproject Create Falling Blocks games in .NET";
            // 
            // linkWiseJ
            // 
            _linkWiseJ.AutoSize = true;
            _linkWiseJ.Font = new System.Drawing.Font("@windowTitle", 16.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            _linkWiseJ.LinkArea = new LinkArea(0, 16);
            _linkWiseJ.Location = new System.Drawing.Point(466, 721);
            _linkWiseJ.Name = "_linkWiseJ";
            _linkWiseJ.Size = new System.Drawing.Size(133, 19);
            _linkWiseJ.TabIndex = 11;
            _linkWiseJ.Text = "More about WiseJ";
            // 
            // TetrisBox1
            // 
            _TetrisBox1.BackColor = System.Drawing.Color.SteelBlue;
            _TetrisBox1.Location = new System.Drawing.Point(10, 14);
            _TetrisBox1.Name = "_TetrisBox1";
            _TetrisBox1.RandomBlockColor = System.Drawing.Color.Orange;
            _TetrisBox1.Size = new System.Drawing.Size(241, 481);
            _TetrisBox1.UncompleteRowColor = System.Drawing.Color.Orange;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 17.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1006, 980);
            Controls.Add(_linkWiseJ);
            Controls.Add(_lnkArticle);
            Controls.Add(Label23);
            Controls.Add(GroupBox7);
            Controls.Add(GroupBox6);
            Controls.Add(gbxDifficulties);
            Controls.Add(gbxKeys);
            Controls.Add(gbxBlockColors);
            Controls.Add(gbxBoardSize);
            Controls.Add(gbxBackground);
            Controls.Add(_TetrisBox1);
            Font = new System.Drawing.Font("Segoe UI", 9.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Form1";
            Text = "TetrisBox Test";
            gbxBackground.ResumeLayout(false);
            gbxBackground.PerformLayout();
            gbxBoardSize.ResumeLayout(false);
            gbxBoardSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_numCellSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numRows).EndInit();
            gbxBlockColors.ResumeLayout(false);
            gbxBlockColors.PerformLayout();
            gbxKeys.ResumeLayout(false);
            gbxKeys.PerformLayout();
            gbxDifficulties.ResumeLayout(false);
            gbxDifficulties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUncompleteLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRandomBlock).EndInit();
            GroupBox6.ResumeLayout(false);
            GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_tbrSpeed).EndInit();
            GroupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_TetrisBox1).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private TetrisBox _TetrisBox1;

        internal TetrisBox TetrisBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TetrisBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TetrisBox1 != null)
                {
                    _TetrisBox1.FullRows -= TetrisBox1_FullRows;
                    _TetrisBox1.GameOver -= TetrisBox1_GameOver;
                    _TetrisBox1.NewBlock -= TetrisBox1_NewBlock;
                    _TetrisBox1.Starting -= TetrisBox1_Starting;
                }

                _TetrisBox1 = value;
                if (_TetrisBox1 != null)
                {
                    _TetrisBox1.FullRows += TetrisBox1_FullRows;
                    _TetrisBox1.GameOver += TetrisBox1_GameOver;
                    _TetrisBox1.NewBlock += TetrisBox1_NewBlock;
                    _TetrisBox1.Starting += TetrisBox1_Starting;
                }
            }
        }

        internal GroupBox gbxBackground;
        private RadioButton _radBackgroundSolid;

        internal RadioButton radBackgroundSolid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _radBackgroundSolid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_radBackgroundSolid != null)
                {
                    _radBackgroundSolid.CheckedChanged -= radBackgroundSolid_CheckedChanged;
                }

                _radBackgroundSolid = value;
                if (_radBackgroundSolid != null)
                {
                    _radBackgroundSolid.CheckedChanged += radBackgroundSolid_CheckedChanged;
                }
            }
        }

        private LinkLabel _lnkBackgroundPicture;

        internal LinkLabel lnkBackgroundPicture
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lnkBackgroundPicture;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lnkBackgroundPicture != null)
                {
                    _lnkBackgroundPicture.LinkClicked -= lnkBackgroundPicture_LinkClicked;
                }

                _lnkBackgroundPicture = value;
                if (_lnkBackgroundPicture != null)
                {
                    _lnkBackgroundPicture.LinkClicked += lnkBackgroundPicture_LinkClicked;
                }
            }
        }

        private RadioButton _radBackgroundPicture;

        internal RadioButton radBackgroundPicture
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _radBackgroundPicture;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_radBackgroundPicture != null)
                {
                    _radBackgroundPicture.CheckedChanged -= radBackgroundSolid_CheckedChanged;
                }

                _radBackgroundPicture = value;
                if (_radBackgroundPicture != null)
                {
                    _radBackgroundPicture.CheckedChanged += radBackgroundSolid_CheckedChanged;
                }
            }
        }

        private ComboBox _cboGradientDirection;

        internal ComboBox cboGradientDirection
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboGradientDirection;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboGradientDirection != null)
                {
                    _cboGradientDirection.SelectedIndexChanged -= cboGradientDirection_SelectedIndexChanged;
                }

                _cboGradientDirection = value;
                if (_cboGradientDirection != null)
                {
                    _cboGradientDirection.SelectedIndexChanged += cboGradientDirection_SelectedIndexChanged;
                }
            }
        }

        private Panel _pnlBackgroundGradient2;

        internal Panel pnlBackgroundGradient2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBackgroundGradient2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBackgroundGradient2 != null)
                {
                    _pnlBackgroundGradient2.Click -= pnlBackgroundGradient2_Click;
                }

                _pnlBackgroundGradient2 = value;
                if (_pnlBackgroundGradient2 != null)
                {
                    _pnlBackgroundGradient2.Click += pnlBackgroundGradient2_Click;
                }
            }
        }

        internal Label Label1;
        private Panel _pnlBackgroundGradient1;

        internal Panel pnlBackgroundGradient1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBackgroundGradient1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBackgroundGradient1 != null)
                {
                    _pnlBackgroundGradient1.Click -= pnlBackgroundGradient1_Click;
                }

                _pnlBackgroundGradient1 = value;
                if (_pnlBackgroundGradient1 != null)
                {
                    _pnlBackgroundGradient1.Click += pnlBackgroundGradient1_Click;
                }
            }
        }

        private RadioButton _radBackgroundGradient;

        internal RadioButton radBackgroundGradient
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _radBackgroundGradient;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_radBackgroundGradient != null)
                {
                    _radBackgroundGradient.CheckedChanged -= radBackgroundSolid_CheckedChanged;
                }

                _radBackgroundGradient = value;
                if (_radBackgroundGradient != null)
                {
                    _radBackgroundGradient.CheckedChanged += radBackgroundSolid_CheckedChanged;
                }
            }
        }

        private Panel _pnlBackgroundSolid;

        internal Panel pnlBackgroundSolid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBackgroundSolid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBackgroundSolid != null)
                {
                    _pnlBackgroundSolid.Click -= pnlBackgroundSolid_Click;
                }

                _pnlBackgroundSolid = value;
                if (_pnlBackgroundSolid != null)
                {
                    _pnlBackgroundSolid.Click += pnlBackgroundSolid_Click;
                }
            }
        }

        internal OpenFileDialog dlgBackgroundPicture;
        internal ColorDialog dlgColor;
        internal GroupBox gbxBoardSize;
        internal Label Label4;
        private NumericUpDown _numCellSize;

        internal NumericUpDown numCellSize
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _numCellSize;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_numCellSize != null)
                {
                    _numCellSize.ValueChanged -= numCellSize_ValueChanged;
                }

                _numCellSize = value;
                if (_numCellSize != null)
                {
                    _numCellSize.ValueChanged += numCellSize_ValueChanged;
                }
            }
        }

        internal Label Label3;
        private NumericUpDown _numColumns;

        internal NumericUpDown numColumns
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _numColumns;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_numColumns != null)
                {
                    _numColumns.ValueChanged -= numColumns_ValueChanged;
                }

                _numColumns = value;
                if (_numColumns != null)
                {
                    _numColumns.ValueChanged += numColumns_ValueChanged;
                }
            }
        }

        internal Label Label2;
        private NumericUpDown _numRows;

        internal NumericUpDown numRows
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _numRows;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_numRows != null)
                {
                    _numRows.ValueChanged -= numRows_ValueChanged;
                }

                _numRows = value;
                if (_numRows != null)
                {
                    _numRows.ValueChanged += numRows_ValueChanged;
                }
            }
        }

        internal GroupBox gbxBlockColors;
        internal Label Label11;
        internal Label Label10;
        internal Label Label9;
        private Panel _pnlBlock7Color;

        internal Panel pnlBlock7Color
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBlock7Color;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBlock7Color != null)
                {
                    _pnlBlock7Color.Click -= pnlBlock1Color_Click;
                }

                _pnlBlock7Color = value;
                if (_pnlBlock7Color != null)
                {
                    _pnlBlock7Color.Click += pnlBlock1Color_Click;
                }
            }
        }

        private Panel _pnlBlock6Color;

        internal Panel pnlBlock6Color
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBlock6Color;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBlock6Color != null)
                {
                    _pnlBlock6Color.Click -= pnlBlock1Color_Click;
                }

                _pnlBlock6Color = value;
                if (_pnlBlock6Color != null)
                {
                    _pnlBlock6Color.Click += pnlBlock1Color_Click;
                }
            }
        }

        private Panel _pnlBlock5Color;

        internal Panel pnlBlock5Color
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBlock5Color;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBlock5Color != null)
                {
                    _pnlBlock5Color.Click -= pnlBlock1Color_Click;
                }

                _pnlBlock5Color = value;
                if (_pnlBlock5Color != null)
                {
                    _pnlBlock5Color.Click += pnlBlock1Color_Click;
                }
            }
        }

        internal Label Label8;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        private Panel _pnlBlock4Color;

        internal Panel pnlBlock4Color
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBlock4Color;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBlock4Color != null)
                {
                    _pnlBlock4Color.Click -= pnlBlock1Color_Click;
                }

                _pnlBlock4Color = value;
                if (_pnlBlock4Color != null)
                {
                    _pnlBlock4Color.Click += pnlBlock1Color_Click;
                }
            }
        }

        private Panel _pnlBlock3Color;

        internal Panel pnlBlock3Color
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBlock3Color;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBlock3Color != null)
                {
                    _pnlBlock3Color.Click -= pnlBlock1Color_Click;
                }

                _pnlBlock3Color = value;
                if (_pnlBlock3Color != null)
                {
                    _pnlBlock3Color.Click += pnlBlock1Color_Click;
                }
            }
        }

        private Panel _pnlBlock2Color;

        internal Panel pnlBlock2Color
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBlock2Color;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBlock2Color != null)
                {
                    _pnlBlock2Color.Click -= pnlBlock1Color_Click;
                }

                _pnlBlock2Color = value;
                if (_pnlBlock2Color != null)
                {
                    _pnlBlock2Color.Click += pnlBlock1Color_Click;
                }
            }
        }

        private Panel _pnlBlock1Color;

        internal Panel pnlBlock1Color
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlBlock1Color;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBlock1Color != null)
                {
                    _pnlBlock1Color.Click -= pnlBlock1Color_Click;
                }

                _pnlBlock1Color = value;
                if (_pnlBlock1Color != null)
                {
                    _pnlBlock1Color.Click += pnlBlock1Color_Click;
                }
            }
        }

        internal GroupBox gbxKeys;
        internal Label Label15;
        internal Label Label14;
        internal Label Label13;
        internal Label Label12;
        private ComboBox _cboKeysDrop;

        internal ComboBox cboKeysDrop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboKeysDrop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboKeysDrop != null)
                {
                    _cboKeysDrop.SelectedIndexChanged -= cboKeysDrop_SelectedIndexChanged;
                }

                _cboKeysDrop = value;
                if (_cboKeysDrop != null)
                {
                    _cboKeysDrop.SelectedIndexChanged += cboKeysDrop_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboKeysRotate;

        internal ComboBox cboKeysRotate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboKeysRotate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboKeysRotate != null)
                {
                    _cboKeysRotate.SelectedIndexChanged -= cboKeysRotate_SelectedIndexChanged;
                }

                _cboKeysRotate = value;
                if (_cboKeysRotate != null)
                {
                    _cboKeysRotate.SelectedIndexChanged += cboKeysRotate_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboKeysRight;

        internal ComboBox cboKeysRight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboKeysRight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboKeysRight != null)
                {
                    _cboKeysRight.SelectedIndexChanged -= cboKeysRight_SelectedIndexChanged;
                }

                _cboKeysRight = value;
                if (_cboKeysRight != null)
                {
                    _cboKeysRight.SelectedIndexChanged += cboKeysRight_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboKeysLeft;

        internal ComboBox cboKeysLeft
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboKeysLeft;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboKeysLeft != null)
                {
                    _cboKeysLeft.SelectedIndexChanged -= cboKeysLeft_SelectedIndexChanged;
                }

                _cboKeysLeft = value;
                if (_cboKeysLeft != null)
                {
                    _cboKeysLeft.SelectedIndexChanged += cboKeysLeft_SelectedIndexChanged;
                }
            }
        }

        internal GroupBox gbxDifficulties;
        internal NumericUpDown numRandomBlock;
        internal CheckBox chkRandomBlock;
        internal Label Label16;
        private Panel _pnlRandomBlock;

        internal Panel pnlRandomBlock
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlRandomBlock;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlRandomBlock != null)
                {
                    _pnlRandomBlock.Click -= pnlRandomBlock_Click;
                }

                _pnlRandomBlock = value;
                if (_pnlRandomBlock != null)
                {
                    _pnlRandomBlock.Click += pnlRandomBlock_Click;
                }
            }
        }

        internal Label Label17;
        internal Label Label18;
        internal NumericUpDown numUncompleteLine;
        internal CheckBox chkUncompleteLine;
        internal Label Label19;
        private Panel _pnlUncompleteLine;

        internal Panel pnlUncompleteLine
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlUncompleteLine;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlUncompleteLine != null)
                {
                    _pnlUncompleteLine.Click -= pnlUncompleteLine_Click;
                }

                _pnlUncompleteLine = value;
                if (_pnlUncompleteLine != null)
                {
                    _pnlUncompleteLine.Click += pnlUncompleteLine_Click;
                }
            }
        }

        internal GroupBox GroupBox6;
        private Button _btnResume;

        internal Button btnResume
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnResume;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnResume != null)
                {
                    _btnResume.Click -= btnResume_Click;
                }

                _btnResume = value;
                if (_btnResume != null)
                {
                    _btnResume.Click += btnResume_Click;
                }
            }
        }

        private Button _btnPause;

        internal Button btnPause
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPause;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPause != null)
                {
                    _btnPause.Click -= btnPause_Click;
                }

                _btnPause = value;
                if (_btnPause != null)
                {
                    _btnPause.Click += btnPause_Click;
                }
            }
        }

        private Button _btnStop;

        internal Button btnStop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnStop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnStop != null)
                {
                    _btnStop.Click -= btnStop_Click;
                }

                _btnStop = value;
                if (_btnStop != null)
                {
                    _btnStop.Click += btnStop_Click;
                }
            }
        }

        private Button _btnStart;

        internal Button btnStart
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnStart;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnStart != null)
                {
                    _btnStart.Click -= btnStart_Click;
                }

                _btnStart = value;
                if (_btnStart != null)
                {
                    _btnStart.Click += btnStart_Click;
                }
            }
        }

        internal Label Label22;
        internal Label Label21;
        internal Label Label20;
        private TrackBar _tbrSpeed;

        internal TrackBar tbrSpeed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbrSpeed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbrSpeed != null)
                {
                    _tbrSpeed.Scroll -= tbrSpeed_Scroll;
                    _tbrSpeed.ValueChanged -= tbrSpeed_Scroll;
                }

                _tbrSpeed = value;
                if (_tbrSpeed != null)
                {
                    _tbrSpeed.Scroll += tbrSpeed_Scroll;
                    _tbrSpeed.ValueChanged += tbrSpeed_Scroll;
                }
            }
        }

        internal GroupBox GroupBox7;
        internal ListBox lstEvents;
        internal Label Label23;
        private LinkLabel _lnkArticle;

        internal LinkLabel lnkArticle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lnkArticle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lnkArticle != null)
                {
                    _lnkArticle.LinkClicked -= lnkArticle_LinkClicked;
                }

                _lnkArticle = value;
                if (_lnkArticle != null)
                {
                    _lnkArticle.LinkClicked += lnkArticle_LinkClicked;
                }
            }
        }

        private LinkLabel _linkWiseJ;

        internal LinkLabel linkWiseJ
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _linkWiseJ;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_linkWiseJ != null)
                {
                    _linkWiseJ.LinkClicked -= linkWiseJ_LinkClicked;
                }

                _linkWiseJ = value;
                if (_linkWiseJ != null)
                {
                    _linkWiseJ.LinkClicked += linkWiseJ_LinkClicked;
                }
            }
        }
    }
}