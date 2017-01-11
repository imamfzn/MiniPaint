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
            this.pnlDrawingArea = new System.Windows.Forms.Panel();
            this.grbLine = new System.Windows.Forms.GroupBox();
            this.rbLineBresenham = new System.Windows.Forms.RadioButton();
            this.rbLineDDA = new System.Windows.Forms.RadioButton();
            this.rbLineNaive = new System.Windows.Forms.RadioButton();
            this.grbShape = new System.Windows.Forms.GroupBox();
            this.rbStar = new System.Windows.Forms.RadioButton();
            this.rbPolygon = new System.Windows.Forms.RadioButton();
            this.rbElips = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.btnClearArea = new System.Windows.Forms.Button();
            this.numericGon = new System.Windows.Forms.NumericUpDown();
            this.grbNGon = new System.Windows.Forms.GroupBox();
            this.grbLine.SuspendLayout();
            this.grbShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGon)).BeginInit();
            this.grbNGon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawingArea
            // 
            this.pnlDrawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawingArea.AutoSize = true;
            this.pnlDrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawingArea.Location = new System.Drawing.Point(35, 68);
            this.pnlDrawingArea.Name = "pnlDrawingArea";
            this.pnlDrawingArea.Size = new System.Drawing.Size(668, 305);
            this.pnlDrawingArea.TabIndex = 0;
            this.pnlDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawingArea_Paint);
            this.pnlDrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingArea_MouseDown);
            this.pnlDrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingArea_MouseMove);
            this.pnlDrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingArea_MouseUp);
            this.pnlDrawingArea.Resize += new System.EventHandler(this.pnlDrawingArea_Resize);
            // 
            // grbLine
            // 
            this.grbLine.Controls.Add(this.rbLineBresenham);
            this.grbLine.Controls.Add(this.rbLineDDA);
            this.grbLine.Controls.Add(this.rbLineNaive);
            this.grbLine.Location = new System.Drawing.Point(338, 12);
            this.grbLine.Name = "grbLine";
            this.grbLine.Size = new System.Drawing.Size(201, 50);
            this.grbLine.TabIndex = 1;
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
            // grbShape
            // 
            this.grbShape.Controls.Add(this.rbStar);
            this.grbShape.Controls.Add(this.rbPolygon);
            this.grbShape.Controls.Add(this.rbElips);
            this.grbShape.Controls.Add(this.rbCircle);
            this.grbShape.Controls.Add(this.rbLine);
            this.grbShape.Location = new System.Drawing.Point(35, 12);
            this.grbShape.Name = "grbShape";
            this.grbShape.Size = new System.Drawing.Size(297, 50);
            this.grbShape.TabIndex = 2;
            this.grbShape.TabStop = false;
            this.grbShape.Text = "Shapes";
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
            // btnClearArea
            // 
            this.btnClearArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearArea.Location = new System.Drawing.Point(618, 379);
            this.btnClearArea.Name = "btnClearArea";
            this.btnClearArea.Size = new System.Drawing.Size(85, 27);
            this.btnClearArea.TabIndex = 3;
            this.btnClearArea.Text = "Clear";
            this.btnClearArea.UseVisualStyleBackColor = true;
            this.btnClearArea.Click += new System.EventHandler(this.btnClearArea_Click);
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
            // grbNGon
            // 
            this.grbNGon.Controls.Add(this.numericGon);
            this.grbNGon.Location = new System.Drawing.Point(545, 12);
            this.grbNGon.Name = "grbNGon";
            this.grbNGon.Size = new System.Drawing.Size(158, 50);
            this.grbNGon.TabIndex = 0;
            this.grbNGon.TabStop = false;
            this.grbNGon.Text = "Degree of Polygon / Star";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 422);
            this.Controls.Add(this.btnClearArea);
            this.Controls.Add(this.grbNGon);
            this.Controls.Add(this.grbShape);
            this.Controls.Add(this.grbLine);
            this.Controls.Add(this.pnlDrawingArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbLine.ResumeLayout(false);
            this.grbLine.PerformLayout();
            this.grbShape.ResumeLayout(false);
            this.grbShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGon)).EndInit();
            this.grbNGon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawingArea;
        private System.Windows.Forms.GroupBox grbLine;
        private System.Windows.Forms.RadioButton rbLineBresenham;
        private System.Windows.Forms.RadioButton rbLineDDA;
        private System.Windows.Forms.RadioButton rbLineNaive;
        private System.Windows.Forms.GroupBox grbShape;
        private System.Windows.Forms.RadioButton rbStar;
        private System.Windows.Forms.RadioButton rbPolygon;
        private System.Windows.Forms.RadioButton rbElips;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Button btnClearArea;
        private System.Windows.Forms.NumericUpDown numericGon;
        private System.Windows.Forms.GroupBox grbNGon;
    }
}

