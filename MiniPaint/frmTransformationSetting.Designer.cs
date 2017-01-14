namespace MiniPaint
{
    partial class frmTransformationSetting
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
            this.grbTranslation = new System.Windows.Forms.GroupBox();
            this.numDx = new System.Windows.Forms.NumericUpDown();
            this.numDy = new System.Windows.Forms.NumericUpDown();
            this.lblDx = new System.Windows.Forms.Label();
            this.lblDy = new System.Windows.Forms.Label();
            this.grbRotation = new System.Windows.Forms.GroupBox();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.grbDilatation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numKFactor = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numConst = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numGrad = new System.Windows.Forms.NumericUpDown();
            this.rbRefLine2 = new System.Windows.Forms.RadioButton();
            this.rbRefLine1 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbTranslation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDy)).BeginInit();
            this.grbRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            this.grbDilatation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKFactor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrad)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTranslation
            // 
            this.grbTranslation.Controls.Add(this.numDx);
            this.grbTranslation.Controls.Add(this.numDy);
            this.grbTranslation.Controls.Add(this.lblDx);
            this.grbTranslation.Controls.Add(this.lblDy);
            this.grbTranslation.Location = new System.Drawing.Point(12, 12);
            this.grbTranslation.Name = "grbTranslation";
            this.grbTranslation.Size = new System.Drawing.Size(239, 56);
            this.grbTranslation.TabIndex = 13;
            this.grbTranslation.TabStop = false;
            this.grbTranslation.Text = "Translation";
            // 
            // numDx
            // 
            this.numDx.Location = new System.Drawing.Point(31, 19);
            this.numDx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDx.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numDx.Name = "numDx";
            this.numDx.Size = new System.Drawing.Size(77, 20);
            this.numDx.TabIndex = 4;
            // 
            // numDy
            // 
            this.numDy.Location = new System.Drawing.Point(144, 19);
            this.numDy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDy.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numDy.Name = "numDy";
            this.numDy.Size = new System.Drawing.Size(77, 20);
            this.numDy.TabIndex = 5;
            // 
            // lblDx
            // 
            this.lblDx.AutoSize = true;
            this.lblDx.Location = new System.Drawing.Point(7, 21);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(18, 13);
            this.lblDx.TabIndex = 6;
            this.lblDx.Text = "dx";
            // 
            // lblDy
            // 
            this.lblDy.AutoSize = true;
            this.lblDy.Location = new System.Drawing.Point(120, 21);
            this.lblDy.Name = "lblDy";
            this.lblDy.Size = new System.Drawing.Size(18, 13);
            this.lblDy.TabIndex = 7;
            this.lblDy.Text = "dy";
            // 
            // grbRotation
            // 
            this.grbRotation.Controls.Add(this.numAlpha);
            this.grbRotation.Controls.Add(this.lblAlpha);
            this.grbRotation.Location = new System.Drawing.Point(12, 74);
            this.grbRotation.Name = "grbRotation";
            this.grbRotation.Size = new System.Drawing.Size(239, 56);
            this.grbRotation.TabIndex = 14;
            this.grbRotation.TabStop = false;
            this.grbRotation.Text = "Rotation";
            // 
            // numAlpha
            // 
            this.numAlpha.Location = new System.Drawing.Point(59, 21);
            this.numAlpha.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAlpha.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(77, 20);
            this.numAlpha.TabIndex = 8;
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(11, 23);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(42, 13);
            this.lblAlpha.TabIndex = 9;
            this.lblAlpha.Text = "Degree";
            // 
            // grbDilatation
            // 
            this.grbDilatation.Controls.Add(this.label1);
            this.grbDilatation.Controls.Add(this.numKFactor);
            this.grbDilatation.Location = new System.Drawing.Point(12, 136);
            this.grbDilatation.Name = "grbDilatation";
            this.grbDilatation.Size = new System.Drawing.Size(239, 58);
            this.grbDilatation.TabIndex = 15;
            this.grbDilatation.TabStop = false;
            this.grbDilatation.Text = "Dilatation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "K-Factor";
            // 
            // numKFactor
            // 
            this.numKFactor.Location = new System.Drawing.Point(60, 24);
            this.numKFactor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKFactor.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numKFactor.Name = "numKFactor";
            this.numKFactor.Size = new System.Drawing.Size(50, 20);
            this.numKFactor.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numConst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numGrad);
            this.groupBox1.Controls.Add(this.rbRefLine2);
            this.groupBox1.Controls.Add(this.rbRefLine1);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 96);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reflection";
            // 
            // numConst
            // 
            this.numConst.Location = new System.Drawing.Point(148, 50);
            this.numConst.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numConst.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numConst.Name = "numConst";
            this.numConst.Size = new System.Drawing.Size(73, 20);
            this.numConst.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "m";
            // 
            // numGrad
            // 
            this.numGrad.Location = new System.Drawing.Point(35, 50);
            this.numGrad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGrad.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numGrad.Name = "numGrad";
            this.numGrad.Size = new System.Drawing.Size(73, 20);
            this.numGrad.TabIndex = 12;
            // 
            // rbRefLine2
            // 
            this.rbRefLine2.AutoSize = true;
            this.rbRefLine2.Location = new System.Drawing.Point(91, 19);
            this.rbRefLine2.Name = "rbRefLine2";
            this.rbRefLine2.Size = new System.Drawing.Size(48, 17);
            this.rbRefLine2.TabIndex = 3;
            this.rbRefLine2.TabStop = true;
            this.rbRefLine2.Text = "x = c";
            this.rbRefLine2.UseVisualStyleBackColor = true;
            // 
            // rbRefLine1
            // 
            this.rbRefLine1.AutoSize = true;
            this.rbRefLine1.Location = new System.Drawing.Point(12, 19);
            this.rbRefLine1.Name = "rbRefLine1";
            this.rbRefLine1.Size = new System.Drawing.Size(73, 17);
            this.rbRefLine1.TabIndex = 2;
            this.rbRefLine1.TabStop = true;
            this.rbRefLine1.Text = "y = mx + c";
            this.rbRefLine1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(95, 302);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTransformationSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 347);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbDilatation);
            this.Controls.Add(this.grbRotation);
            this.Controls.Add(this.grbTranslation);
            this.Name = "frmTransformationSetting";
            this.Text = "Transformation Setting";
            this.grbTranslation.ResumeLayout(false);
            this.grbTranslation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDy)).EndInit();
            this.grbRotation.ResumeLayout(false);
            this.grbRotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            this.grbDilatation.ResumeLayout(false);
            this.grbDilatation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKFactor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTranslation;
        private System.Windows.Forms.NumericUpDown numDx;
        private System.Windows.Forms.NumericUpDown numDy;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblDy;
        private System.Windows.Forms.GroupBox grbRotation;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.GroupBox grbDilatation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numKFactor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numConst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGrad;
        private System.Windows.Forms.RadioButton rbRefLine2;
        private System.Windows.Forms.RadioButton rbRefLine1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}