namespace MiniPaint
{
    partial class Form1
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
            this.pnlDrawingArea = new System.Windows.Forms.PictureBox();
            this.btnClearArea = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbNGon = new System.Windows.Forms.GroupBox();
            this.numericGon = new System.Windows.Forms.NumericUpDown();
            this.grbShape = new System.Windows.Forms.GroupBox();
            this.rbFill = new System.Windows.Forms.RadioButton();
            this.rbStar = new System.Windows.Forms.RadioButton();
            this.rbPolygon = new System.Windows.Forms.RadioButton();
            this.rbElips = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.grbLine = new System.Windows.Forms.GroupBox();
            this.rbLineBresenham = new System.Windows.Forms.RadioButton();
            this.rbLineDDA = new System.Windows.Forms.RadioButton();
            this.rbLineNaive = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.rbReflection = new System.Windows.Forms.RadioButton();
            this.ckTransform = new System.Windows.Forms.CheckBox();
            this.rbTranslation = new System.Windows.Forms.RadioButton();
            this.rbDilatation = new System.Windows.Forms.RadioButton();
            this.rbRotation = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBoundaryFill = new System.Windows.Forms.RadioButton();
            this.rbFloodFill = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbColorPurple = new System.Windows.Forms.RadioButton();
            this.rbColorWhite = new System.Windows.Forms.RadioButton();
            this.rbColorGray = new System.Windows.Forms.RadioButton();
            this.rbColorGreen = new System.Windows.Forms.RadioButton();
            this.rbColorBlue = new System.Windows.Forms.RadioButton();
            this.rbColorYellow = new System.Windows.Forms.RadioButton();
            this.rbColorRed = new System.Windows.Forms.RadioButton();
            this.rbColorBlack = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDrawingArea)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbNGon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGon)).BeginInit();
            this.grbShape.SuspendLayout();
            this.grbLine.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawingArea
            // 
            this.pnlDrawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawingArea.Location = new System.Drawing.Point(16, 110);
            this.pnlDrawingArea.Name = "pnlDrawingArea";
            this.pnlDrawingArea.Size = new System.Drawing.Size(922, 307);
            this.pnlDrawingArea.TabIndex = 6;
            this.pnlDrawingArea.TabStop = false;
            this.pnlDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawingArea_Paint);
            this.pnlDrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingArea_MouseDown);
            this.pnlDrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingArea_MouseMove);
            this.pnlDrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingArea_MouseUp);
            this.pnlDrawingArea.Resize += new System.EventHandler(this.pnlDrawingArea_Resize);
            // 
            // btnClearArea
            // 
            this.btnClearArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearArea.Location = new System.Drawing.Point(853, 423);
            this.btnClearArea.Name = "btnClearArea";
            this.btnClearArea.Size = new System.Drawing.Size(85, 27);
            this.btnClearArea.TabIndex = 8;
            this.btnClearArea.Text = "Clear";
            this.btnClearArea.UseVisualStyleBackColor = true;
            this.btnClearArea.Click += new System.EventHandler(this.btnClearArea_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 92);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.grbNGon);
            this.tabPage1.Controls.Add(this.grbShape);
            this.tabPage1.Controls.Add(this.grbLine);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 66);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shape";
            // 
            // grbNGon
            // 
            this.grbNGon.Controls.Add(this.numericGon);
            this.grbNGon.Location = new System.Drawing.Point(586, 6);
            this.grbNGon.Name = "grbNGon";
            this.grbNGon.Size = new System.Drawing.Size(158, 50);
            this.grbNGon.TabIndex = 3;
            this.grbNGon.TabStop = false;
            this.grbNGon.Text = "Degree of Polygon / Star";
            // 
            // numericGon
            // 
            this.numericGon.Location = new System.Drawing.Point(6, 19);
            this.numericGon.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericGon.Name = "numericGon";
            this.numericGon.Size = new System.Drawing.Size(146, 20);
            this.numericGon.TabIndex = 4;
            this.numericGon.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // grbShape
            // 
            this.grbShape.Controls.Add(this.rbFill);
            this.grbShape.Controls.Add(this.rbStar);
            this.grbShape.Controls.Add(this.rbPolygon);
            this.grbShape.Controls.Add(this.rbElips);
            this.grbShape.Controls.Add(this.rbCircle);
            this.grbShape.Controls.Add(this.rbLine);
            this.grbShape.Location = new System.Drawing.Point(6, 6);
            this.grbShape.Name = "grbShape";
            this.grbShape.Size = new System.Drawing.Size(351, 50);
            this.grbShape.TabIndex = 5;
            this.grbShape.TabStop = false;
            this.grbShape.Text = "Shapes";
            // 
            // rbFill
            // 
            this.rbFill.AutoSize = true;
            this.rbFill.Location = new System.Drawing.Point(293, 19);
            this.rbFill.Name = "rbFill";
            this.rbFill.Size = new System.Drawing.Size(37, 17);
            this.rbFill.TabIndex = 5;
            this.rbFill.TabStop = true;
            this.rbFill.Text = "Fill";
            this.rbFill.UseVisualStyleBackColor = true;
            // 
            // rbStar
            // 
            this.rbStar.AutoSize = true;
            this.rbStar.Location = new System.Drawing.Point(243, 19);
            this.rbStar.Name = "rbStar";
            this.rbStar.Size = new System.Drawing.Size(44, 17);
            this.rbStar.TabIndex = 4;
            this.rbStar.TabStop = true;
            this.rbStar.Text = "Star";
            this.rbStar.UseVisualStyleBackColor = true;
            // 
            // rbPolygon
            // 
            this.rbPolygon.AutoSize = true;
            this.rbPolygon.Location = new System.Drawing.Point(176, 19);
            this.rbPolygon.Name = "rbPolygon";
            this.rbPolygon.Size = new System.Drawing.Size(63, 17);
            this.rbPolygon.TabIndex = 3;
            this.rbPolygon.TabStop = true;
            this.rbPolygon.Text = "Polygon";
            this.rbPolygon.UseVisualStyleBackColor = true;
            // 
            // rbElips
            // 
            this.rbElips.AutoSize = true;
            this.rbElips.Location = new System.Drawing.Point(123, 19);
            this.rbElips.Name = "rbElips";
            this.rbElips.Size = new System.Drawing.Size(47, 17);
            this.rbElips.TabIndex = 2;
            this.rbElips.TabStop = true;
            this.rbElips.Text = "Elips";
            this.rbElips.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(66, 19);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(15, 19);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // grbLine
            // 
            this.grbLine.Controls.Add(this.rbLineBresenham);
            this.grbLine.Controls.Add(this.rbLineDDA);
            this.grbLine.Controls.Add(this.rbLineNaive);
            this.grbLine.Location = new System.Drawing.Point(379, 6);
            this.grbLine.Name = "grbLine";
            this.grbLine.Size = new System.Drawing.Size(201, 50);
            this.grbLine.TabIndex = 4;
            this.grbLine.TabStop = false;
            this.grbLine.Text = "Line Algorithm";
            // 
            // rbLineBresenham
            // 
            this.rbLineBresenham.AutoSize = true;
            this.rbLineBresenham.Location = new System.Drawing.Point(119, 19);
            this.rbLineBresenham.Name = "rbLineBresenham";
            this.rbLineBresenham.Size = new System.Drawing.Size(78, 17);
            this.rbLineBresenham.TabIndex = 7;
            this.rbLineBresenham.TabStop = true;
            this.rbLineBresenham.Text = "Bresenham";
            this.rbLineBresenham.UseVisualStyleBackColor = true;
            // 
            // rbLineDDA
            // 
            this.rbLineDDA.AutoSize = true;
            this.rbLineDDA.Location = new System.Drawing.Point(65, 19);
            this.rbLineDDA.Name = "rbLineDDA";
            this.rbLineDDA.Size = new System.Drawing.Size(48, 17);
            this.rbLineDDA.TabIndex = 6;
            this.rbLineDDA.TabStop = true;
            this.rbLineDDA.Text = "DDA";
            this.rbLineDDA.UseVisualStyleBackColor = true;
            // 
            // rbLineNaive
            // 
            this.rbLineNaive.AutoSize = true;
            this.rbLineNaive.Checked = true;
            this.rbLineNaive.Location = new System.Drawing.Point(6, 19);
            this.rbLineNaive.Name = "rbLineNaive";
            this.rbLineNaive.Size = new System.Drawing.Size(53, 17);
            this.rbLineNaive.TabIndex = 5;
            this.rbLineNaive.TabStop = true;
            this.rbLineNaive.Text = "Naive";
            this.rbLineNaive.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnTransform);
            this.tabPage2.Controls.Add(this.btnOption);
            this.tabPage2.Controls.Add(this.rbReflection);
            this.tabPage2.Controls.Add(this.ckTransform);
            this.tabPage2.Controls.Add(this.rbTranslation);
            this.tabPage2.Controls.Add(this.rbDilatation);
            this.tabPage2.Controls.Add(this.rbRotation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 66);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transformation";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(423, 24);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(85, 27);
            this.btnTransform.TabIndex = 12;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(332, 24);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(85, 27);
            this.btnOption.TabIndex = 11;
            this.btnOption.Text = "Options";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // rbReflection
            // 
            this.rbReflection.AutoSize = true;
            this.rbReflection.Location = new System.Drawing.Point(243, 34);
            this.rbReflection.Name = "rbReflection";
            this.rbReflection.Size = new System.Drawing.Size(73, 17);
            this.rbReflection.TabIndex = 2;
            this.rbReflection.TabStop = true;
            this.rbReflection.Text = "Reflection";
            this.rbReflection.UseVisualStyleBackColor = true;
            // 
            // ckTransform
            // 
            this.ckTransform.AutoSize = true;
            this.ckTransform.Location = new System.Drawing.Point(14, 10);
            this.ckTransform.Name = "ckTransform";
            this.ckTransform.Size = new System.Drawing.Size(112, 17);
            this.ckTransform.TabIndex = 9;
            this.ckTransform.Text = "Transform Method";
            this.ckTransform.UseVisualStyleBackColor = true;
            this.ckTransform.CheckedChanged += new System.EventHandler(this.ckTransform_CheckedChanged);
            // 
            // rbTranslation
            // 
            this.rbTranslation.AutoSize = true;
            this.rbTranslation.Checked = true;
            this.rbTranslation.Location = new System.Drawing.Point(14, 34);
            this.rbTranslation.Name = "rbTranslation";
            this.rbTranslation.Size = new System.Drawing.Size(77, 17);
            this.rbTranslation.TabIndex = 0;
            this.rbTranslation.TabStop = true;
            this.rbTranslation.Text = "Translation";
            this.rbTranslation.UseVisualStyleBackColor = true;
            // 
            // rbDilatation
            // 
            this.rbDilatation.AutoSize = true;
            this.rbDilatation.Location = new System.Drawing.Point(168, 34);
            this.rbDilatation.Name = "rbDilatation";
            this.rbDilatation.Size = new System.Drawing.Size(69, 17);
            this.rbDilatation.TabIndex = 3;
            this.rbDilatation.TabStop = true;
            this.rbDilatation.Text = "Dilatation";
            this.rbDilatation.UseVisualStyleBackColor = true;
            // 
            // rbRotation
            // 
            this.rbRotation.AutoSize = true;
            this.rbRotation.Location = new System.Drawing.Point(97, 34);
            this.rbRotation.Name = "rbRotation";
            this.rbRotation.Size = new System.Drawing.Size(65, 17);
            this.rbRotation.TabIndex = 1;
            this.rbRotation.TabStop = true;
            this.rbRotation.Text = "Rotation";
            this.rbRotation.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(922, 66);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Coloring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBoundaryFill);
            this.groupBox2.Controls.Add(this.rbFloodFill);
            this.groupBox2.Location = new System.Drawing.Point(363, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 59);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Method";
            // 
            // rbBoundaryFill
            // 
            this.rbBoundaryFill.AutoSize = true;
            this.rbBoundaryFill.Location = new System.Drawing.Point(6, 36);
            this.rbBoundaryFill.Name = "rbBoundaryFill";
            this.rbBoundaryFill.Size = new System.Drawing.Size(85, 17);
            this.rbBoundaryFill.TabIndex = 9;
            this.rbBoundaryFill.Text = "Boundary Fill";
            this.rbBoundaryFill.UseVisualStyleBackColor = true;
            // 
            // rbFloodFill
            // 
            this.rbFloodFill.AutoSize = true;
            this.rbFloodFill.Checked = true;
            this.rbFloodFill.Location = new System.Drawing.Point(6, 18);
            this.rbFloodFill.Name = "rbFloodFill";
            this.rbFloodFill.Size = new System.Drawing.Size(66, 17);
            this.rbFloodFill.TabIndex = 8;
            this.rbFloodFill.TabStop = true;
            this.rbFloodFill.Text = "Flood Fill";
            this.rbFloodFill.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbColorPurple);
            this.groupBox1.Controls.Add(this.rbColorWhite);
            this.groupBox1.Controls.Add(this.rbColorGray);
            this.groupBox1.Controls.Add(this.rbColorGreen);
            this.groupBox1.Controls.Add(this.rbColorBlue);
            this.groupBox1.Controls.Add(this.rbColorYellow);
            this.groupBox1.Controls.Add(this.rbColorRed);
            this.groupBox1.Controls.Add(this.rbColorBlack);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // rbColorPurple
            // 
            this.rbColorPurple.AutoSize = true;
            this.rbColorPurple.Location = new System.Drawing.Point(131, 37);
            this.rbColorPurple.Name = "rbColorPurple";
            this.rbColorPurple.Size = new System.Drawing.Size(55, 17);
            this.rbColorPurple.TabIndex = 7;
            this.rbColorPurple.Text = "Purple";
            this.rbColorPurple.UseVisualStyleBackColor = true;
            this.rbColorPurple.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // rbColorWhite
            // 
            this.rbColorWhite.AutoSize = true;
            this.rbColorWhite.Location = new System.Drawing.Point(73, 37);
            this.rbColorWhite.Name = "rbColorWhite";
            this.rbColorWhite.Size = new System.Drawing.Size(53, 17);
            this.rbColorWhite.TabIndex = 6;
            this.rbColorWhite.Text = "White";
            this.rbColorWhite.UseVisualStyleBackColor = true;
            this.rbColorWhite.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // rbColorGray
            // 
            this.rbColorGray.AutoSize = true;
            this.rbColorGray.Checked = true;
            this.rbColorGray.Location = new System.Drawing.Point(15, 37);
            this.rbColorGray.Name = "rbColorGray";
            this.rbColorGray.Size = new System.Drawing.Size(47, 17);
            this.rbColorGray.TabIndex = 5;
            this.rbColorGray.TabStop = true;
            this.rbColorGray.Text = "Gray";
            this.rbColorGray.UseVisualStyleBackColor = true;
            this.rbColorGray.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // rbColorGreen
            // 
            this.rbColorGreen.AutoSize = true;
            this.rbColorGreen.Location = new System.Drawing.Point(247, 19);
            this.rbColorGreen.Name = "rbColorGreen";
            this.rbColorGreen.Size = new System.Drawing.Size(54, 17);
            this.rbColorGreen.TabIndex = 4;
            this.rbColorGreen.Text = "Green";
            this.rbColorGreen.UseVisualStyleBackColor = true;
            this.rbColorGreen.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // rbColorBlue
            // 
            this.rbColorBlue.AutoSize = true;
            this.rbColorBlue.Location = new System.Drawing.Point(189, 19);
            this.rbColorBlue.Name = "rbColorBlue";
            this.rbColorBlue.Size = new System.Drawing.Size(46, 17);
            this.rbColorBlue.TabIndex = 3;
            this.rbColorBlue.Text = "Blue";
            this.rbColorBlue.UseVisualStyleBackColor = true;
            this.rbColorBlue.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // rbColorYellow
            // 
            this.rbColorYellow.AutoSize = true;
            this.rbColorYellow.Location = new System.Drawing.Point(131, 19);
            this.rbColorYellow.Name = "rbColorYellow";
            this.rbColorYellow.Size = new System.Drawing.Size(56, 17);
            this.rbColorYellow.TabIndex = 2;
            this.rbColorYellow.Text = "Yellow";
            this.rbColorYellow.UseVisualStyleBackColor = true;
            this.rbColorYellow.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // rbColorRed
            // 
            this.rbColorRed.AutoSize = true;
            this.rbColorRed.Location = new System.Drawing.Point(73, 19);
            this.rbColorRed.Name = "rbColorRed";
            this.rbColorRed.Size = new System.Drawing.Size(45, 17);
            this.rbColorRed.TabIndex = 1;
            this.rbColorRed.Text = "Red";
            this.rbColorRed.UseVisualStyleBackColor = true;
            this.rbColorRed.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // rbColorBlack
            // 
            this.rbColorBlack.AutoSize = true;
            this.rbColorBlack.Location = new System.Drawing.Point(15, 19);
            this.rbColorBlack.Name = "rbColorBlack";
            this.rbColorBlack.Size = new System.Drawing.Size(52, 17);
            this.rbColorBlack.TabIndex = 0;
            this.rbColorBlack.Text = "Black";
            this.rbColorBlack.UseVisualStyleBackColor = true;
            this.rbColorBlack.CheckedChanged += new System.EventHandler(this.rbColor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClearArea);
            this.Controls.Add(this.pnlDrawingArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pnlDrawingArea)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbNGon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericGon)).EndInit();
            this.grbShape.ResumeLayout(false);
            this.grbShape.PerformLayout();
            this.grbLine.ResumeLayout(false);
            this.grbLine.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pnlDrawingArea;
        private System.Windows.Forms.Button btnClearArea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grbNGon;
        private System.Windows.Forms.NumericUpDown numericGon;
        private System.Windows.Forms.GroupBox grbShape;
        private System.Windows.Forms.RadioButton rbStar;
        private System.Windows.Forms.RadioButton rbPolygon;
        private System.Windows.Forms.RadioButton rbElips;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.GroupBox grbLine;
        private System.Windows.Forms.RadioButton rbLineBresenham;
        private System.Windows.Forms.RadioButton rbLineDDA;
        private System.Windows.Forms.RadioButton rbLineNaive;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.RadioButton rbReflection;
        private System.Windows.Forms.CheckBox ckTransform;
        private System.Windows.Forms.RadioButton rbTranslation;
        private System.Windows.Forms.RadioButton rbDilatation;
        private System.Windows.Forms.RadioButton rbRotation;
        private System.Windows.Forms.RadioButton rbFill;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBoundaryFill;
        private System.Windows.Forms.RadioButton rbFloodFill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbColorPurple;
        private System.Windows.Forms.RadioButton rbColorWhite;
        private System.Windows.Forms.RadioButton rbColorGray;
        private System.Windows.Forms.RadioButton rbColorGreen;
        private System.Windows.Forms.RadioButton rbColorBlue;
        private System.Windows.Forms.RadioButton rbColorYellow;
        private System.Windows.Forms.RadioButton rbColorRed;
        private System.Windows.Forms.RadioButton rbColorBlack;
    }
}

