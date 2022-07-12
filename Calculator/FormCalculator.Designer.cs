﻿namespace Calculator
{
    partial class FormCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScoreboard = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnEqualSign = new System.Windows.Forms.Button();
            this.btnCleanEntry = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNumberSign = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.txtBoxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtScoreboard
            // 
            this.txtScoreboard.Location = new System.Drawing.Point(10, 32);
            this.txtScoreboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScoreboard.Name = "txtScoreboard";
            this.txtScoreboard.Size = new System.Drawing.Size(226, 23);
            this.txtScoreboard.TabIndex = 0;
            this.txtScoreboard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScoreboard_KeyPress);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnOne.Location = new System.Drawing.Point(10, 205);
            this.btnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(52, 45);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnTwo.Location = new System.Drawing.Point(68, 205);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(52, 45);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThree.Location = new System.Drawing.Point(126, 205);
            this.btnThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(52, 45);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFour.Location = new System.Drawing.Point(10, 155);
            this.btnFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(52, 45);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFive.Location = new System.Drawing.Point(68, 155);
            this.btnFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(52, 45);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSix.Location = new System.Drawing.Point(126, 155);
            this.btnSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(52, 45);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeven.Location = new System.Drawing.Point(10, 106);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(52, 45);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEight.Location = new System.Drawing.Point(68, 106);
            this.btnEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(52, 45);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNine.Location = new System.Drawing.Point(126, 106);
            this.btnNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(52, 45);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnZero.Location = new System.Drawing.Point(68, 254);
            this.btnZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(52, 45);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDecimalPoint.Location = new System.Drawing.Point(10, 254);
            this.btnDecimalPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(52, 45);
            this.btnDecimalPoint.TabIndex = 11;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = false;
            this.btnDecimalPoint.Click += new System.EventHandler(this.btnDecimalPoint_Click);
            // 
            // btnEqualSign
            // 
            this.btnEqualSign.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEqualSign.Location = new System.Drawing.Point(126, 254);
            this.btnEqualSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEqualSign.Name = "btnEqualSign";
            this.btnEqualSign.Size = new System.Drawing.Size(110, 45);
            this.btnEqualSign.TabIndex = 12;
            this.btnEqualSign.Text = "=";
            this.btnEqualSign.UseVisualStyleBackColor = false;
            this.btnEqualSign.Click += new System.EventHandler(this.btnEqualSign_Click);
            // 
            // btnCleanEntry
            // 
            this.btnCleanEntry.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCleanEntry.Location = new System.Drawing.Point(10, 56);
            this.btnCleanEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleanEntry.Name = "btnCleanEntry";
            this.btnCleanEntry.Size = new System.Drawing.Size(52, 45);
            this.btnCleanEntry.TabIndex = 13;
            this.btnCleanEntry.Text = "CE";
            this.btnCleanEntry.UseVisualStyleBackColor = false;
            this.btnCleanEntry.Click += new System.EventHandler(this.btnCleanEntry_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Image = global::Calculator.Properties.Resources.delete11;
            this.btnCancel.Location = new System.Drawing.Point(68, 56);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 45);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNumberSign
            // 
            this.btnNumberSign.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNumberSign.Location = new System.Drawing.Point(126, 56);
            this.btnNumberSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNumberSign.Name = "btnNumberSign";
            this.btnNumberSign.Size = new System.Drawing.Size(52, 45);
            this.btnNumberSign.TabIndex = 15;
            this.btnNumberSign.Text = "+/-";
            this.btnNumberSign.UseVisualStyleBackColor = false;
            this.btnNumberSign.Click += new System.EventHandler(this.btnNumberSign_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddition.Location = new System.Drawing.Point(184, 56);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(52, 45);
            this.btnAddition.TabIndex = 16;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnArithmeticOperation_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubtraction.Location = new System.Drawing.Point(184, 106);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(52, 45);
            this.btnSubtraction.TabIndex = 17;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.Click += new System.EventHandler(this.btnArithmeticOperation_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnMultiplication.Location = new System.Drawing.Point(184, 155);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(52, 45);
            this.btnMultiplication.TabIndex = 18;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnArithmeticOperation_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDivision.Location = new System.Drawing.Point(184, 205);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(52, 45);
            this.btnDivision.TabIndex = 19;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnArithmeticOperation_Click);
            // 
            // txtBoxValue
            // 
            this.txtBoxValue.Location = new System.Drawing.Point(144, 8);
            this.txtBoxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxValue.Name = "txtBoxValue";
            this.txtBoxValue.ReadOnly = true;
            this.txtBoxValue.Size = new System.Drawing.Size(93, 23);
            this.txtBoxValue.TabIndex = 20;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 306);
            this.Controls.Add(this.txtBoxValue);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnNumberSign);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCleanEntry);
            this.Controls.Add(this.btnEqualSign);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtScoreboard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(264, 345);
            this.MinimumSize = new System.Drawing.Size(264, 345);
            this.Name = "FormCalculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtScoreboard;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnZero;
        private Button btnDecimalPoint;
        private Button btnEqualSign;
        private Button btnCleanEntry;
        private Button btnCancel;
        private Button btnNumberSign;
        private Button btnAddition;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btnDivision;
        private TextBox txtBoxValue;
    }
}