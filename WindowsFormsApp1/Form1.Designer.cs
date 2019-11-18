namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nxmResult = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonGenDefault = new System.Windows.Forms.Button();
            this.checkBoxGenAst = new System.Windows.Forms.CheckBox();
            this.checkBoxGenNum = new System.Windows.Forms.CheckBox();
            this.checkBoxHideData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "b  =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "( 0 < b < n x m )";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = " = ";
            // 
            // nxmResult
            // 
            this.nxmResult.AutoSize = true;
            this.nxmResult.Location = new System.Drawing.Point(159, 25);
            this.nxmResult.Name = "nxmResult";
            this.nxmResult.Size = new System.Drawing.Size(13, 13);
            this.nxmResult.TabIndex = 9;
            this.nxmResult.Text = "?";
            this.nxmResult.Click += new System.EventHandler(this.nxmResult_Click);
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(16, 23);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownN.TabIndex = 10;
            this.numericUpDownN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDownN_ValueChanged);
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(84, 23);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownM.TabIndex = 11;
            this.numericUpDownM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.ValueChanged += new System.EventHandler(this.numericUpDownM_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(48, 64);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownB.TabIndex = 12;
            this.numericUpDownB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 101);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 13;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonGenDefault
            // 
            this.buttonGenDefault.Location = new System.Drawing.Point(12, 130);
            this.buttonGenDefault.Name = "buttonGenDefault";
            this.buttonGenDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonGenDefault.TabIndex = 14;
            this.buttonGenDefault.Text = "Default";
            this.buttonGenDefault.UseVisualStyleBackColor = true;
            this.buttonGenDefault.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxGenAst
            // 
            this.checkBoxGenAst.AutoSize = true;
            this.checkBoxGenAst.Location = new System.Drawing.Point(107, 101);
            this.checkBoxGenAst.Name = "checkBoxGenAst";
            this.checkBoxGenAst.Size = new System.Drawing.Size(77, 17);
            this.checkBoxGenAst.TabIndex = 15;
            this.checkBoxGenAst.Text = "Generate *";
            this.checkBoxGenAst.UseVisualStyleBackColor = true;
            // 
            // checkBoxGenNum
            // 
            this.checkBoxGenNum.AutoSize = true;
            this.checkBoxGenNum.Location = new System.Drawing.Point(107, 124);
            this.checkBoxGenNum.Name = "checkBoxGenNum";
            this.checkBoxGenNum.Size = new System.Drawing.Size(80, 17);
            this.checkBoxGenNum.TabIndex = 16;
            this.checkBoxGenNum.Text = "Generate #";
            this.checkBoxGenNum.UseVisualStyleBackColor = true;
            // 
            // checkBoxHideData
            // 
            this.checkBoxHideData.AutoSize = true;
            this.checkBoxHideData.Location = new System.Drawing.Point(107, 147);
            this.checkBoxHideData.Name = "checkBoxHideData";
            this.checkBoxHideData.Size = new System.Drawing.Size(74, 17);
            this.checkBoxHideData.TabIndex = 17;
            this.checkBoxHideData.Text = "Hide Data";
            this.checkBoxHideData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 180);
            this.Controls.Add(this.checkBoxHideData);
            this.Controls.Add(this.checkBoxGenNum);
            this.Controls.Add(this.checkBoxGenAst);
            this.Controls.Add(this.buttonGenDefault);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.nxmResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nxmResult;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonGenDefault;
        private System.Windows.Forms.CheckBox checkBoxGenAst;
        private System.Windows.Forms.CheckBox checkBoxGenNum;
        private System.Windows.Forms.CheckBox checkBoxHideData;
    }
}

