namespace WindowsFormsApplication1
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
            this.buttonOneDigit = new System.Windows.Forms.Button();
            this.buttonTwoDigit = new System.Windows.Forms.Button();
            this.buttonThreeDigit = new System.Windows.Forms.Button();
            this.buttonFourDigit = new System.Windows.Forms.Button();
            this.buttonFiveDigit = new System.Windows.Forms.Button();
            this.buttonSixDigit = new System.Windows.Forms.Button();
            this.buttonSevenDigit = new System.Windows.Forms.Button();
            this.buttonEightDigit = new System.Windows.Forms.Button();
            this.buttonNineDigit = new System.Windows.Forms.Button();
            this.buttonZeroDigit = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRandomNum = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.ScreenDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOneDigit
            // 
            this.buttonOneDigit.Location = new System.Drawing.Point(12, 58);
            this.buttonOneDigit.Name = "buttonOneDigit";
            this.buttonOneDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonOneDigit.TabIndex = 0;
            this.buttonOneDigit.Text = "1";
            this.buttonOneDigit.UseVisualStyleBackColor = true;
            this.buttonOneDigit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTwoDigit
            // 
            this.buttonTwoDigit.Location = new System.Drawing.Point(72, 58);
            this.buttonTwoDigit.Name = "buttonTwoDigit";
            this.buttonTwoDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonTwoDigit.TabIndex = 1;
            this.buttonTwoDigit.Text = "2";
            this.buttonTwoDigit.UseVisualStyleBackColor = true;
            this.buttonTwoDigit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonThreeDigit
            // 
            this.buttonThreeDigit.Location = new System.Drawing.Point(132, 58);
            this.buttonThreeDigit.Name = "buttonThreeDigit";
            this.buttonThreeDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonThreeDigit.TabIndex = 2;
            this.buttonThreeDigit.Text = "3";
            this.buttonThreeDigit.UseVisualStyleBackColor = true;
            this.buttonThreeDigit.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonFourDigit
            // 
            this.buttonFourDigit.Location = new System.Drawing.Point(12, 110);
            this.buttonFourDigit.Name = "buttonFourDigit";
            this.buttonFourDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonFourDigit.TabIndex = 3;
            this.buttonFourDigit.Text = "4";
            this.buttonFourDigit.UseVisualStyleBackColor = true;
            this.buttonFourDigit.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonFiveDigit
            // 
            this.buttonFiveDigit.Location = new System.Drawing.Point(72, 110);
            this.buttonFiveDigit.Name = "buttonFiveDigit";
            this.buttonFiveDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonFiveDigit.TabIndex = 4;
            this.buttonFiveDigit.Text = "5";
            this.buttonFiveDigit.UseVisualStyleBackColor = true;
            this.buttonFiveDigit.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSixDigit
            // 
            this.buttonSixDigit.Location = new System.Drawing.Point(132, 110);
            this.buttonSixDigit.Name = "buttonSixDigit";
            this.buttonSixDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonSixDigit.TabIndex = 5;
            this.buttonSixDigit.Text = "6";
            this.buttonSixDigit.UseVisualStyleBackColor = true;
            this.buttonSixDigit.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonSevenDigit
            // 
            this.buttonSevenDigit.Location = new System.Drawing.Point(12, 162);
            this.buttonSevenDigit.Name = "buttonSevenDigit";
            this.buttonSevenDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonSevenDigit.TabIndex = 6;
            this.buttonSevenDigit.Text = "7";
            this.buttonSevenDigit.UseVisualStyleBackColor = true;
            this.buttonSevenDigit.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonEightDigit
            // 
            this.buttonEightDigit.Location = new System.Drawing.Point(72, 162);
            this.buttonEightDigit.Name = "buttonEightDigit";
            this.buttonEightDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonEightDigit.TabIndex = 7;
            this.buttonEightDigit.Text = "8";
            this.buttonEightDigit.UseVisualStyleBackColor = true;
            this.buttonEightDigit.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonNineDigit
            // 
            this.buttonNineDigit.Location = new System.Drawing.Point(132, 162);
            this.buttonNineDigit.Name = "buttonNineDigit";
            this.buttonNineDigit.Size = new System.Drawing.Size(54, 46);
            this.buttonNineDigit.TabIndex = 8;
            this.buttonNineDigit.Text = "9";
            this.buttonNineDigit.UseVisualStyleBackColor = true;
            this.buttonNineDigit.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonZeroDigit
            // 
            this.buttonZeroDigit.Location = new System.Drawing.Point(72, 214);
            this.buttonZeroDigit.Name = "buttonZeroDigit";
            this.buttonZeroDigit.Size = new System.Drawing.Size(114, 46);
            this.buttonZeroDigit.TabIndex = 10;
            this.buttonZeroDigit.Text = "0";
            this.buttonZeroDigit.UseVisualStyleBackColor = true;
            this.buttonZeroDigit.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(206, 110);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(66, 46);
            this.buttonMinus.TabIndex = 11;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.button12_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(206, 162);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(66, 46);
            this.buttonDivide.TabIndex = 12;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(206, 58);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(66, 46);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.button14_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(206, 214);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(66, 46);
            this.buttonMultiply.TabIndex = 14;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 214);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(54, 46);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button16_Click);
            // 
            // buttonRandomNum
            // 
            this.buttonRandomNum.Location = new System.Drawing.Point(206, 269);
            this.buttonRandomNum.Name = "buttonRandomNum";
            this.buttonRandomNum.Size = new System.Drawing.Size(66, 46);
            this.buttonRandomNum.TabIndex = 16;
            this.buttonRandomNum.Text = "Random Number";
            this.buttonRandomNum.UseVisualStyleBackColor = true;
            this.buttonRandomNum.Click += new System.EventHandler(this.button17_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.Location = new System.Drawing.Point(12, 269);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(174, 46);
            this.buttonEquals.TabIndex = 17;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // ScreenDisplay
            // 
            this.ScreenDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ScreenDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScreenDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenDisplay.Location = new System.Drawing.Point(12, 12);
            this.ScreenDisplay.Name = "ScreenDisplay";
            this.ScreenDisplay.ReadOnly = true;
            this.ScreenDisplay.Size = new System.Drawing.Size(260, 38);
            this.ScreenDisplay.TabIndex = 18;
            this.ScreenDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.ScreenDisplay);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonRandomNum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonZeroDigit);
            this.Controls.Add(this.buttonNineDigit);
            this.Controls.Add(this.buttonEightDigit);
            this.Controls.Add(this.buttonSevenDigit);
            this.Controls.Add(this.buttonSixDigit);
            this.Controls.Add(this.buttonFiveDigit);
            this.Controls.Add(this.buttonFourDigit);
            this.Controls.Add(this.buttonThreeDigit);
            this.Controls.Add(this.buttonTwoDigit);
            this.Controls.Add(this.buttonOneDigit);
            this.Name = "Form1";
            this.Text = "GUI Calculator by Chris Boseak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOneDigit;
        private System.Windows.Forms.Button buttonTwoDigit;
        private System.Windows.Forms.Button buttonThreeDigit;
        private System.Windows.Forms.Button buttonFourDigit;
        private System.Windows.Forms.Button buttonFiveDigit;
        private System.Windows.Forms.Button buttonSixDigit;
        private System.Windows.Forms.Button buttonSevenDigit;
        private System.Windows.Forms.Button buttonEightDigit;
        private System.Windows.Forms.Button buttonNineDigit;
        private System.Windows.Forms.Button buttonZeroDigit;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRandomNum;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.TextBox ScreenDisplay;
    }
}

