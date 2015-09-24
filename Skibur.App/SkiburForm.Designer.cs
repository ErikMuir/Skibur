namespace Skibur.App
{
    partial class SkiburForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkiburForm));
            this.tblBack = new System.Windows.Forms.TableLayoutPanel();
            this.lblBack = new System.Windows.Forms.Label();
            this.tblRight = new System.Windows.Forms.TableLayoutPanel();
            this.lblRight = new System.Windows.Forms.Label();
            this.tblDown = new System.Windows.Forms.TableLayoutPanel();
            this.lblDown = new System.Windows.Forms.Label();
            this.tblUp = new System.Windows.Forms.TableLayoutPanel();
            this.lblUp = new System.Windows.Forms.Label();
            this.tblFront = new System.Windows.Forms.TableLayoutPanel();
            this.lblFront = new System.Windows.Forms.Label();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblLeft = new System.Windows.Forms.Label();
            this.btnR1Turn = new System.Windows.Forms.Button();
            this.btnR2Turn = new System.Windows.Forms.Button();
            this.btnR3Turn = new System.Windows.Forms.Button();
            this.btnU3Turn = new System.Windows.Forms.Button();
            this.btnU2Turn = new System.Windows.Forms.Button();
            this.btnU1Turn = new System.Windows.Forms.Button();
            this.btnL3Turn = new System.Windows.Forms.Button();
            this.btnL2Turn = new System.Windows.Forms.Button();
            this.btnL1Turn = new System.Windows.Forms.Button();
            this.btnD3Turn = new System.Windows.Forms.Button();
            this.btnD2Turn = new System.Windows.Forms.Button();
            this.btnD1Turn = new System.Windows.Forms.Button();
            this.btnB3Turn = new System.Windows.Forms.Button();
            this.btnB2Turn = new System.Windows.Forms.Button();
            this.btnB1Turn = new System.Windows.Forms.Button();
            this.btnF3Turn = new System.Windows.Forms.Button();
            this.btnF2Turn = new System.Windows.Forms.Button();
            this.btnF1Turn = new System.Windows.Forms.Button();
            this.btnX1Rotate = new System.Windows.Forms.Button();
            this.btnY1Rotate = new System.Windows.Forms.Button();
            this.btnZ1Rotate = new System.Windows.Forms.Button();
            this.btnZ3Rotate = new System.Windows.Forms.Button();
            this.btnY3Rotate = new System.Windows.Forms.Button();
            this.btnX3Rotate = new System.Windows.Forms.Button();
            this.btnZ2Rotate = new System.Windows.Forms.Button();
            this.btnY2Rotate = new System.Windows.Forms.Button();
            this.btnX2Rotate = new System.Windows.Forms.Button();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lblRotations = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTurnCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.btnScramble = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.tblBack.SuspendLayout();
            this.tblRight.SuspendLayout();
            this.tblDown.SuspendLayout();
            this.tblUp.SuspendLayout();
            this.tblFront.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBack
            // 
            this.tblBack.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblBack.ColumnCount = 3;
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBack.Controls.Add(this.lblBack, 1, 1);
            this.tblBack.Location = new System.Drawing.Point(506, 247);
            this.tblBack.Margin = new System.Windows.Forms.Padding(2);
            this.tblBack.Name = "tblBack";
            this.tblBack.RowCount = 3;
            this.tblBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBack.Size = new System.Drawing.Size(150, 162);
            this.tblBack.TabIndex = 11;
            this.tblBack.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblBack_CellPaint);
            // 
            // lblBack
            // 
            this.lblBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(54, 58);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(42, 46);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "B";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblRight
            // 
            this.tblRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblRight.ColumnCount = 3;
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRight.Controls.Add(this.lblRight, 1, 1);
            this.tblRight.Location = new System.Drawing.Point(352, 247);
            this.tblRight.Margin = new System.Windows.Forms.Padding(2);
            this.tblRight.Name = "tblRight";
            this.tblRight.RowCount = 3;
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRight.Size = new System.Drawing.Size(150, 162);
            this.tblRight.TabIndex = 10;
            this.tblRight.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblRight_CellPaint);
            // 
            // lblRight
            // 
            this.lblRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRight.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(54, 58);
            this.lblRight.Margin = new System.Windows.Forms.Padding(2);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(42, 46);
            this.lblRight.TabIndex = 1;
            this.lblRight.Text = "R";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblDown
            // 
            this.tblDown.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblDown.ColumnCount = 3;
            this.tblDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDown.Controls.Add(this.lblDown, 1, 1);
            this.tblDown.Location = new System.Drawing.Point(198, 415);
            this.tblDown.Margin = new System.Windows.Forms.Padding(2);
            this.tblDown.Name = "tblDown";
            this.tblDown.RowCount = 3;
            this.tblDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDown.Size = new System.Drawing.Size(150, 162);
            this.tblDown.TabIndex = 9;
            this.tblDown.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblDown_CellPaint);
            // 
            // lblDown
            // 
            this.lblDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDown.AutoSize = true;
            this.lblDown.BackColor = System.Drawing.Color.Transparent;
            this.lblDown.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.Location = new System.Drawing.Point(54, 58);
            this.lblDown.Margin = new System.Windows.Forms.Padding(2);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(42, 46);
            this.lblDown.TabIndex = 1;
            this.lblDown.Text = "D";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblUp
            // 
            this.tblUp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblUp.ColumnCount = 3;
            this.tblUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUp.Controls.Add(this.lblUp, 1, 1);
            this.tblUp.Location = new System.Drawing.Point(198, 80);
            this.tblUp.Margin = new System.Windows.Forms.Padding(2);
            this.tblUp.Name = "tblUp";
            this.tblUp.RowCount = 3;
            this.tblUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblUp.Size = new System.Drawing.Size(150, 162);
            this.tblUp.TabIndex = 8;
            this.tblUp.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblUp_CellPaint);
            // 
            // lblUp
            // 
            this.lblUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUp.AutoSize = true;
            this.lblUp.BackColor = System.Drawing.Color.Transparent;
            this.lblUp.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.Location = new System.Drawing.Point(54, 58);
            this.lblUp.Margin = new System.Windows.Forms.Padding(2);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(42, 46);
            this.lblUp.TabIndex = 0;
            this.lblUp.Text = "U";
            this.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblFront
            // 
            this.tblFront.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblFront.ColumnCount = 3;
            this.tblFront.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFront.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFront.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFront.Controls.Add(this.lblFront, 1, 1);
            this.tblFront.Location = new System.Drawing.Point(198, 247);
            this.tblFront.Margin = new System.Windows.Forms.Padding(2);
            this.tblFront.Name = "tblFront";
            this.tblFront.RowCount = 3;
            this.tblFront.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFront.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFront.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFront.Size = new System.Drawing.Size(150, 162);
            this.tblFront.TabIndex = 7;
            this.tblFront.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblFront_CellPaint);
            // 
            // lblFront
            // 
            this.lblFront.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFront.AutoSize = true;
            this.lblFront.BackColor = System.Drawing.Color.Transparent;
            this.lblFront.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFront.Location = new System.Drawing.Point(54, 58);
            this.lblFront.Margin = new System.Windows.Forms.Padding(2);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(42, 46);
            this.lblFront.TabIndex = 1;
            this.lblFront.Text = "F";
            this.lblFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblLeft
            // 
            this.tblLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblLeft.ColumnCount = 3;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLeft.Controls.Add(this.lblLeft, 1, 1);
            this.tblLeft.Location = new System.Drawing.Point(43, 247);
            this.tblLeft.Margin = new System.Windows.Forms.Padding(2);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 3;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLeft.Size = new System.Drawing.Size(150, 162);
            this.tblLeft.TabIndex = 6;
            this.tblLeft.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tblLeft_CellPaint);
            // 
            // lblLeft
            // 
            this.lblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.Location = new System.Drawing.Point(54, 58);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(2);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(42, 46);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "L";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnR1Turn
            // 
            this.btnR1Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR1Turn.Location = new System.Drawing.Point(739, 151);
            this.btnR1Turn.Name = "btnR1Turn";
            this.btnR1Turn.Size = new System.Drawing.Size(34, 37);
            this.btnR1Turn.TabIndex = 3;
            this.btnR1Turn.Text = "R";
            this.btnR1Turn.UseVisualStyleBackColor = true;
            this.btnR1Turn.Click += new System.EventHandler(this.btnR1Turn_Click);
            // 
            // btnR2Turn
            // 
            this.btnR2Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR2Turn.Location = new System.Drawing.Point(818, 151);
            this.btnR2Turn.Name = "btnR2Turn";
            this.btnR2Turn.Size = new System.Drawing.Size(34, 37);
            this.btnR2Turn.TabIndex = 5;
            this.btnR2Turn.Text = "R2";
            this.btnR2Turn.UseVisualStyleBackColor = true;
            this.btnR2Turn.Click += new System.EventHandler(this.btnR2Turn_Click);
            // 
            // btnR3Turn
            // 
            this.btnR3Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR3Turn.Location = new System.Drawing.Point(778, 151);
            this.btnR3Turn.Name = "btnR3Turn";
            this.btnR3Turn.Size = new System.Drawing.Size(34, 37);
            this.btnR3Turn.TabIndex = 4;
            this.btnR3Turn.Text = "R\'";
            this.btnR3Turn.UseVisualStyleBackColor = true;
            this.btnR3Turn.Click += new System.EventHandler(this.btnR3Turn_Click);
            // 
            // btnU3Turn
            // 
            this.btnU3Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU3Turn.Location = new System.Drawing.Point(778, 194);
            this.btnU3Turn.Name = "btnU3Turn";
            this.btnU3Turn.Size = new System.Drawing.Size(34, 37);
            this.btnU3Turn.TabIndex = 7;
            this.btnU3Turn.Text = "U\'";
            this.btnU3Turn.UseVisualStyleBackColor = true;
            this.btnU3Turn.Click += new System.EventHandler(this.btnU3Turn_Click);
            // 
            // btnU2Turn
            // 
            this.btnU2Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU2Turn.Location = new System.Drawing.Point(818, 194);
            this.btnU2Turn.Name = "btnU2Turn";
            this.btnU2Turn.Size = new System.Drawing.Size(34, 37);
            this.btnU2Turn.TabIndex = 8;
            this.btnU2Turn.Text = "U2";
            this.btnU2Turn.UseVisualStyleBackColor = true;
            this.btnU2Turn.Click += new System.EventHandler(this.btnU2Turn_Click);
            // 
            // btnU1Turn
            // 
            this.btnU1Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU1Turn.Location = new System.Drawing.Point(739, 194);
            this.btnU1Turn.Name = "btnU1Turn";
            this.btnU1Turn.Size = new System.Drawing.Size(34, 37);
            this.btnU1Turn.TabIndex = 6;
            this.btnU1Turn.Text = "U";
            this.btnU1Turn.UseVisualStyleBackColor = true;
            this.btnU1Turn.Click += new System.EventHandler(this.btnU1Turn_Click);
            // 
            // btnL3Turn
            // 
            this.btnL3Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL3Turn.Location = new System.Drawing.Point(778, 107);
            this.btnL3Turn.Name = "btnL3Turn";
            this.btnL3Turn.Size = new System.Drawing.Size(34, 37);
            this.btnL3Turn.TabIndex = 1;
            this.btnL3Turn.Text = "L\'";
            this.btnL3Turn.UseVisualStyleBackColor = true;
            this.btnL3Turn.Click += new System.EventHandler(this.btnL3Turn_Click);
            // 
            // btnL2Turn
            // 
            this.btnL2Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL2Turn.Location = new System.Drawing.Point(818, 107);
            this.btnL2Turn.Name = "btnL2Turn";
            this.btnL2Turn.Size = new System.Drawing.Size(34, 37);
            this.btnL2Turn.TabIndex = 2;
            this.btnL2Turn.Text = "L2";
            this.btnL2Turn.UseVisualStyleBackColor = true;
            this.btnL2Turn.Click += new System.EventHandler(this.btnL2Turn_Click);
            // 
            // btnL1Turn
            // 
            this.btnL1Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL1Turn.Location = new System.Drawing.Point(739, 107);
            this.btnL1Turn.Name = "btnL1Turn";
            this.btnL1Turn.Size = new System.Drawing.Size(34, 37);
            this.btnL1Turn.TabIndex = 0;
            this.btnL1Turn.Text = "L";
            this.btnL1Turn.UseVisualStyleBackColor = true;
            this.btnL1Turn.Click += new System.EventHandler(this.btnL1Turn_Click);
            // 
            // btnD3Turn
            // 
            this.btnD3Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD3Turn.Location = new System.Drawing.Point(778, 238);
            this.btnD3Turn.Name = "btnD3Turn";
            this.btnD3Turn.Size = new System.Drawing.Size(34, 37);
            this.btnD3Turn.TabIndex = 10;
            this.btnD3Turn.Text = "D\'";
            this.btnD3Turn.UseVisualStyleBackColor = true;
            this.btnD3Turn.Click += new System.EventHandler(this.btnD3Turn_Click);
            // 
            // btnD2Turn
            // 
            this.btnD2Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD2Turn.Location = new System.Drawing.Point(818, 238);
            this.btnD2Turn.Name = "btnD2Turn";
            this.btnD2Turn.Size = new System.Drawing.Size(34, 37);
            this.btnD2Turn.TabIndex = 11;
            this.btnD2Turn.Text = "D2";
            this.btnD2Turn.UseVisualStyleBackColor = true;
            this.btnD2Turn.Click += new System.EventHandler(this.btnD2Turn_Click);
            // 
            // btnD1Turn
            // 
            this.btnD1Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD1Turn.Location = new System.Drawing.Point(739, 238);
            this.btnD1Turn.Name = "btnD1Turn";
            this.btnD1Turn.Size = new System.Drawing.Size(34, 37);
            this.btnD1Turn.TabIndex = 9;
            this.btnD1Turn.Text = "D";
            this.btnD1Turn.UseVisualStyleBackColor = true;
            this.btnD1Turn.Click += new System.EventHandler(this.btnD1Turn_Click);
            // 
            // btnB3Turn
            // 
            this.btnB3Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB3Turn.Location = new System.Drawing.Point(778, 327);
            this.btnB3Turn.Name = "btnB3Turn";
            this.btnB3Turn.Size = new System.Drawing.Size(34, 37);
            this.btnB3Turn.TabIndex = 16;
            this.btnB3Turn.Text = "B\'";
            this.btnB3Turn.UseVisualStyleBackColor = true;
            this.btnB3Turn.Click += new System.EventHandler(this.btnB3Turn_Click);
            // 
            // btnB2Turn
            // 
            this.btnB2Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB2Turn.Location = new System.Drawing.Point(818, 327);
            this.btnB2Turn.Name = "btnB2Turn";
            this.btnB2Turn.Size = new System.Drawing.Size(34, 37);
            this.btnB2Turn.TabIndex = 17;
            this.btnB2Turn.Text = "B2";
            this.btnB2Turn.UseVisualStyleBackColor = true;
            this.btnB2Turn.Click += new System.EventHandler(this.btnB2Turn_Click);
            // 
            // btnB1Turn
            // 
            this.btnB1Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB1Turn.Location = new System.Drawing.Point(739, 327);
            this.btnB1Turn.Name = "btnB1Turn";
            this.btnB1Turn.Size = new System.Drawing.Size(34, 37);
            this.btnB1Turn.TabIndex = 15;
            this.btnB1Turn.Text = "B";
            this.btnB1Turn.UseVisualStyleBackColor = true;
            this.btnB1Turn.Click += new System.EventHandler(this.btnB1Turn_Click);
            // 
            // btnF3Turn
            // 
            this.btnF3Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF3Turn.Location = new System.Drawing.Point(778, 283);
            this.btnF3Turn.Name = "btnF3Turn";
            this.btnF3Turn.Size = new System.Drawing.Size(34, 37);
            this.btnF3Turn.TabIndex = 13;
            this.btnF3Turn.Text = "F\'";
            this.btnF3Turn.UseVisualStyleBackColor = true;
            this.btnF3Turn.Click += new System.EventHandler(this.btnF3Turn_Click);
            // 
            // btnF2Turn
            // 
            this.btnF2Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF2Turn.Location = new System.Drawing.Point(818, 283);
            this.btnF2Turn.Name = "btnF2Turn";
            this.btnF2Turn.Size = new System.Drawing.Size(34, 37);
            this.btnF2Turn.TabIndex = 14;
            this.btnF2Turn.Text = "F2";
            this.btnF2Turn.UseVisualStyleBackColor = true;
            this.btnF2Turn.Click += new System.EventHandler(this.btnF2Turn_Click);
            // 
            // btnF1Turn
            // 
            this.btnF1Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF1Turn.Location = new System.Drawing.Point(739, 283);
            this.btnF1Turn.Name = "btnF1Turn";
            this.btnF1Turn.Size = new System.Drawing.Size(34, 37);
            this.btnF1Turn.TabIndex = 12;
            this.btnF1Turn.Text = "F";
            this.btnF1Turn.UseVisualStyleBackColor = true;
            this.btnF1Turn.Click += new System.EventHandler(this.btnF1Turn_Click);
            // 
            // btnX1Rotate
            // 
            this.btnX1Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX1Rotate.Location = new System.Drawing.Point(739, 442);
            this.btnX1Rotate.Name = "btnX1Rotate";
            this.btnX1Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnX1Rotate.TabIndex = 18;
            this.btnX1Rotate.Text = "X";
            this.btnX1Rotate.UseVisualStyleBackColor = true;
            this.btnX1Rotate.Click += new System.EventHandler(this.btnX1Rotate_Click);
            // 
            // btnY1Rotate
            // 
            this.btnY1Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY1Rotate.Location = new System.Drawing.Point(739, 486);
            this.btnY1Rotate.Name = "btnY1Rotate";
            this.btnY1Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnY1Rotate.TabIndex = 21;
            this.btnY1Rotate.Text = "Y";
            this.btnY1Rotate.UseVisualStyleBackColor = true;
            this.btnY1Rotate.Click += new System.EventHandler(this.btnY1Rotate_Click);
            // 
            // btnZ1Rotate
            // 
            this.btnZ1Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ1Rotate.Location = new System.Drawing.Point(739, 529);
            this.btnZ1Rotate.Name = "btnZ1Rotate";
            this.btnZ1Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnZ1Rotate.TabIndex = 24;
            this.btnZ1Rotate.Text = "Z";
            this.btnZ1Rotate.UseVisualStyleBackColor = true;
            this.btnZ1Rotate.Click += new System.EventHandler(this.btnZ1Rotate_Click);
            // 
            // btnZ3Rotate
            // 
            this.btnZ3Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ3Rotate.Location = new System.Drawing.Point(778, 529);
            this.btnZ3Rotate.Name = "btnZ3Rotate";
            this.btnZ3Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnZ3Rotate.TabIndex = 25;
            this.btnZ3Rotate.Text = "Z\'";
            this.btnZ3Rotate.UseVisualStyleBackColor = true;
            this.btnZ3Rotate.Click += new System.EventHandler(this.btnZ3Rotate_Click);
            // 
            // btnY3Rotate
            // 
            this.btnY3Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY3Rotate.Location = new System.Drawing.Point(778, 486);
            this.btnY3Rotate.Name = "btnY3Rotate";
            this.btnY3Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnY3Rotate.TabIndex = 22;
            this.btnY3Rotate.Text = "Y\'";
            this.btnY3Rotate.UseVisualStyleBackColor = true;
            this.btnY3Rotate.Click += new System.EventHandler(this.btnY3Rotate_Click);
            // 
            // btnX3Rotate
            // 
            this.btnX3Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX3Rotate.Location = new System.Drawing.Point(778, 442);
            this.btnX3Rotate.Name = "btnX3Rotate";
            this.btnX3Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnX3Rotate.TabIndex = 19;
            this.btnX3Rotate.Text = "X\'";
            this.btnX3Rotate.UseVisualStyleBackColor = true;
            this.btnX3Rotate.Click += new System.EventHandler(this.btnX3Rotate_Click);
            // 
            // btnZ2Rotate
            // 
            this.btnZ2Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ2Rotate.Location = new System.Drawing.Point(818, 529);
            this.btnZ2Rotate.Name = "btnZ2Rotate";
            this.btnZ2Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnZ2Rotate.TabIndex = 26;
            this.btnZ2Rotate.Text = "Z2";
            this.btnZ2Rotate.UseVisualStyleBackColor = true;
            this.btnZ2Rotate.Click += new System.EventHandler(this.btnZ2Rotate_Click);
            // 
            // btnY2Rotate
            // 
            this.btnY2Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY2Rotate.Location = new System.Drawing.Point(818, 486);
            this.btnY2Rotate.Name = "btnY2Rotate";
            this.btnY2Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnY2Rotate.TabIndex = 23;
            this.btnY2Rotate.Text = "Y2";
            this.btnY2Rotate.UseVisualStyleBackColor = true;
            this.btnY2Rotate.Click += new System.EventHandler(this.btnY2Rotate_Click);
            // 
            // btnX2Rotate
            // 
            this.btnX2Rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX2Rotate.Location = new System.Drawing.Point(818, 442);
            this.btnX2Rotate.Name = "btnX2Rotate";
            this.btnX2Rotate.Size = new System.Drawing.Size(34, 37);
            this.btnX2Rotate.TabIndex = 20;
            this.btnX2Rotate.Text = "X2";
            this.btnX2Rotate.UseVisualStyleBackColor = true;
            this.btnX2Rotate.Click += new System.EventHandler(this.btnX2Rotate_Click);
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurns.Location = new System.Drawing.Point(734, 80);
            this.lblTurns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(56, 22);
            this.lblTurns.TabIndex = 46;
            this.lblTurns.Text = "TURNS";
            // 
            // lblRotations
            // 
            this.lblRotations.AutoSize = true;
            this.lblRotations.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotations.Location = new System.Drawing.Point(734, 415);
            this.lblRotations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotations.Name = "lblRotations";
            this.lblRotations.Size = new System.Drawing.Size(86, 22);
            this.lblRotations.TabIndex = 47;
            this.lblRotations.Text = "ROTATIONS";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.statusStrip1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblElapsedTime,
            this.lblTurnCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(895, 50);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 49;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.ForeColor = System.Drawing.Color.White;
            this.lblElapsedTime.Margin = new System.Windows.Forms.Padding(10, 3, 25, 2);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(110, 45);
            this.lblElapsedTime.Text = "Elapsed Time:";
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTurnCount
            // 
            this.lblTurnCount.ForeColor = System.Drawing.Color.White;
            this.lblTurnCount.Name = "lblTurnCount";
            this.lblTurnCount.Size = new System.Drawing.Size(91, 45);
            this.lblTurnCount.Text = "Turn Count:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.toolStripSeparator2,
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator3,
            this.btnScramble,
            this.btnReset,
            this.toolStripSeparator4,
            this.btnHelp});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(895, 50);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::Skibur.App.Properties.Resources.WorldLocal;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(45, 45);
            this.btnNew.Text = "New";
            this.btnNew.ToolTipText = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = false;
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::Skibur.App.Properties.Resources.Open_6529;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(45, 45);
            this.btnOpen.Text = "Open";
            this.btnOpen.ToolTipText = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Skibur.App.Properties.Resources.Save_6530;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.AutoSize = false;
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAs.Image = global::Skibur.App.Properties.Resources.SaveFileDialogControl_703;
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(45, 45);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.AutoSize = false;
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::Skibur.App.Properties.Resources.Undo_16x;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(45, 45);
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.AutoSize = false;
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::Skibur.App.Properties.Resources.Redo_16x;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(45, 45);
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnScramble
            // 
            this.btnScramble.AutoSize = false;
            this.btnScramble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScramble.Image = global::Skibur.App.Properties.Resources.GridLight;
            this.btnScramble.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScramble.Name = "btnScramble";
            this.btnScramble.Size = new System.Drawing.Size(45, 45);
            this.btnScramble.Text = "Scramble";
            this.btnScramble.Click += new System.EventHandler(this.btnScramble_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = false;
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReset.Image = global::Skibur.App.Properties.Resources.Restart_6322;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 45);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = false;
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::Skibur.App.Properties.Resources.Help_6522;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 45);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // SkiburForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 656);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblRotations);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.btnZ2Rotate);
            this.Controls.Add(this.btnY2Rotate);
            this.Controls.Add(this.btnX2Rotate);
            this.Controls.Add(this.btnZ3Rotate);
            this.Controls.Add(this.btnY3Rotate);
            this.Controls.Add(this.btnX3Rotate);
            this.Controls.Add(this.btnZ1Rotate);
            this.Controls.Add(this.btnY1Rotate);
            this.Controls.Add(this.btnX1Rotate);
            this.Controls.Add(this.btnD3Turn);
            this.Controls.Add(this.btnD2Turn);
            this.Controls.Add(this.btnD1Turn);
            this.Controls.Add(this.btnB3Turn);
            this.Controls.Add(this.btnB2Turn);
            this.Controls.Add(this.btnB1Turn);
            this.Controls.Add(this.btnF3Turn);
            this.Controls.Add(this.btnF2Turn);
            this.Controls.Add(this.btnF1Turn);
            this.Controls.Add(this.btnL3Turn);
            this.Controls.Add(this.btnL2Turn);
            this.Controls.Add(this.btnL1Turn);
            this.Controls.Add(this.btnU3Turn);
            this.Controls.Add(this.btnU2Turn);
            this.Controls.Add(this.btnU1Turn);
            this.Controls.Add(this.btnR3Turn);
            this.Controls.Add(this.btnR2Turn);
            this.Controls.Add(this.btnR1Turn);
            this.Controls.Add(this.tblBack);
            this.Controls.Add(this.tblRight);
            this.Controls.Add(this.tblDown);
            this.Controls.Add(this.tblUp);
            this.Controls.Add(this.tblFront);
            this.Controls.Add(this.tblLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SkiburForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skibur Cube";
            this.tblBack.ResumeLayout(false);
            this.tblBack.PerformLayout();
            this.tblRight.ResumeLayout(false);
            this.tblRight.PerformLayout();
            this.tblDown.ResumeLayout(false);
            this.tblDown.PerformLayout();
            this.tblUp.ResumeLayout(false);
            this.tblUp.PerformLayout();
            this.tblFront.ResumeLayout(false);
            this.tblFront.PerformLayout();
            this.tblLeft.ResumeLayout(false);
            this.tblLeft.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBack;
        private System.Windows.Forms.TableLayoutPanel tblRight;
        private System.Windows.Forms.TableLayoutPanel tblDown;
        private System.Windows.Forms.TableLayoutPanel tblUp;
        private System.Windows.Forms.TableLayoutPanel tblFront;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private System.Windows.Forms.Button btnR1Turn;
        private System.Windows.Forms.Button btnR2Turn;
        private System.Windows.Forms.Button btnR3Turn;
        private System.Windows.Forms.Button btnU3Turn;
        private System.Windows.Forms.Button btnU2Turn;
        private System.Windows.Forms.Button btnU1Turn;
        private System.Windows.Forms.Button btnL3Turn;
        private System.Windows.Forms.Button btnL2Turn;
        private System.Windows.Forms.Button btnL1Turn;
        private System.Windows.Forms.Button btnD3Turn;
        private System.Windows.Forms.Button btnD2Turn;
        private System.Windows.Forms.Button btnD1Turn;
        private System.Windows.Forms.Button btnB3Turn;
        private System.Windows.Forms.Button btnB2Turn;
        private System.Windows.Forms.Button btnB1Turn;
        private System.Windows.Forms.Button btnF3Turn;
        private System.Windows.Forms.Button btnF2Turn;
        private System.Windows.Forms.Button btnF1Turn;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblFront;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Button btnX1Rotate;
        private System.Windows.Forms.Button btnY1Rotate;
        private System.Windows.Forms.Button btnZ1Rotate;
        private System.Windows.Forms.Button btnZ3Rotate;
        private System.Windows.Forms.Button btnY3Rotate;
        private System.Windows.Forms.Button btnX3Rotate;
        private System.Windows.Forms.Button btnZ2Rotate;
        private System.Windows.Forms.Button btnY2Rotate;
        private System.Windows.Forms.Button btnX2Rotate;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lblRotations;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblElapsedTime;
        private System.Windows.Forms.ToolStripStatusLabel lblTurnCount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnScramble;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnHelp;
    }
}

