namespace MyCalcApp
{
    partial class MainForm
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
            btnCE = new Compornents.MyCalcButton();
            btnCA = new Compornents.MyCalcButton();
            btnEqual = new Compornents.MyCalcButton();
            btnAdd = new Compornents.MyCalcButton();
            btnSubstract = new Compornents.MyCalcButton();
            btnMultiply = new Compornents.MyCalcButton();
            btnDivide = new Compornents.MyCalcButton();
            btnDigit = new Compornents.MyCalcButton();
            btn0 = new Compornents.MyCalcButton();
            btn3 = new Compornents.MyCalcButton();
            btn2 = new Compornents.MyCalcButton();
            btn1 = new Compornents.MyCalcButton();
            btn6 = new Compornents.MyCalcButton();
            btn4 = new Compornents.MyCalcButton();
            btn9 = new Compornents.MyCalcButton();
            btn8 = new Compornents.MyCalcButton();
            btn5 = new Compornents.MyCalcButton();
            lblDisplay = new Label();
            btn7 = new Compornents.MyCalcButton();
            SuspendLayout();
            // 
            // btnCE
            // 
            btnCE.CommandType1 = Categories.MyCategory.EnumCommandType1.ClearEntry;
            btnCE.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btnCE.Display = "CE";
            btnCE.Font = new Font("Yu Gothic UI", 12F);
            btnCE.Location = new Point(192, 59);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(80, 60);
            btnCE.TabIndex = 23;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnCA
            // 
            btnCA.CommandType1 = Categories.MyCategory.EnumCommandType1.ClearAll;
            btnCA.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btnCA.Display = "CA";
            btnCA.Font = new Font("Yu Gothic UI", 12F);
            btnCA.Location = new Point(21, 59);
            btnCA.Name = "btnCA";
            btnCA.Size = new Size(166, 60);
            btnCA.TabIndex = 22;
            btnCA.Text = "CA";
            btnCA.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.CommandType1 = Categories.MyCategory.EnumCommandType1.Equal;
            btnEqual.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btnEqual.Display = "＝";
            btnEqual.Location = new Point(279, 347);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(80, 60);
            btnEqual.TabIndex = 39;
            btnEqual.Text = "＝";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.CommandType1 = Categories.MyCategory.EnumCommandType1.Calc;
            btnAdd.CommandType2 = Categories.MyCategory.EnumCommandType2.Add;
            btnAdd.Display = "＋";
            btnAdd.Font = new Font("Yu Gothic UI", 12F);
            btnAdd.Location = new Point(279, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 60);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "＋";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubstract
            // 
            btnSubstract.CommandType1 = Categories.MyCategory.EnumCommandType1.Calc;
            btnSubstract.CommandType2 = Categories.MyCategory.EnumCommandType2.Substract;
            btnSubstract.Display = "ー";
            btnSubstract.Font = new Font("Yu Gothic UI", 12F);
            btnSubstract.Location = new Point(279, 203);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(80, 60);
            btnSubstract.TabIndex = 32;
            btnSubstract.Text = "ー";
            btnSubstract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.CommandType1 = Categories.MyCategory.EnumCommandType1.Calc;
            btnMultiply.CommandType2 = Categories.MyCategory.EnumCommandType2.Multiply;
            btnMultiply.Display = "×";
            btnMultiply.Font = new Font("Yu Gothic UI", 12F);
            btnMultiply.Location = new Point(279, 131);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(80, 60);
            btnMultiply.TabIndex = 28;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.CommandType1 = Categories.MyCategory.EnumCommandType1.Calc;
            btnDivide.CommandType2 = Categories.MyCategory.EnumCommandType2.Divide;
            btnDivide.Display = "÷";
            btnDivide.Font = new Font("Yu Gothic UI", 12F);
            btnDivide.Location = new Point(281, 59);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(80, 60);
            btnDivide.TabIndex = 24;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnDigit
            // 
            btnDigit.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btnDigit.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btnDigit.Display = ".";
            btnDigit.Font = new Font("Yu Gothic UI", 12F);
            btnDigit.Location = new Point(193, 347);
            btnDigit.Name = "btnDigit";
            btnDigit.Size = new Size(80, 60);
            btnDigit.TabIndex = 38;
            btnDigit.Text = ".";
            btnDigit.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn0.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn0.Display = "0";
            btn0.Font = new Font("Yu Gothic UI", 12F);
            btn0.Location = new Point(21, 347);
            btn0.Name = "btn0";
            btn0.Size = new Size(166, 60);
            btn0.TabIndex = 37;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn3.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn3.Display = "3";
            btn3.Font = new Font("Yu Gothic UI", 12F);
            btn3.Location = new Point(193, 275);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 60);
            btn3.TabIndex = 35;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn2.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn2.Display = "2";
            btn2.Font = new Font("Yu Gothic UI", 12F);
            btn2.Location = new Point(107, 275);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 60);
            btn2.TabIndex = 34;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn1.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn1.Display = "1";
            btn1.Font = new Font("Yu Gothic UI", 12F);
            btn1.Location = new Point(21, 275);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 60);
            btn1.TabIndex = 33;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn6.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn6.Display = "6";
            btn6.Font = new Font("Yu Gothic UI", 12F);
            btn6.Location = new Point(192, 203);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 60);
            btn6.TabIndex = 31;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn4.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn4.Display = "4";
            btn4.Font = new Font("Yu Gothic UI", 12F);
            btn4.Location = new Point(21, 203);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 60);
            btn4.TabIndex = 29;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn9.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn9.Display = "9";
            btn9.Font = new Font("Yu Gothic UI", 12F);
            btn9.Location = new Point(193, 131);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 60);
            btn9.TabIndex = 27;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn8.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn8.Display = "8";
            btn8.Font = new Font("Yu Gothic UI", 12F);
            btn8.Location = new Point(107, 131);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 60);
            btn8.TabIndex = 26;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn5.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn5.Display = "5";
            btn5.Font = new Font("Yu Gothic UI", 12F);
            btn5.Location = new Point(107, 203);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 60);
            btn5.TabIndex = 30;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            lblDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblDisplay.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblDisplay.Location = new Point(21, 9);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(340, 40);
            lblDisplay.TabIndex = 21;
            lblDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn7
            // 
            btn7.CommandType1 = Categories.MyCategory.EnumCommandType1.Num;
            btn7.CommandType2 = Categories.MyCategory.EnumCommandType2.Other;
            btn7.Display = "7";
            btn7.Font = new Font("Yu Gothic UI", 12F);
            btn7.Location = new Point(21, 131);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 60);
            btn7.TabIndex = 25;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(384, 441);
            Controls.Add(btnCE);
            Controls.Add(btnCA);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btnSubstract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnDigit);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(lblDisplay);
            Controls.Add(btn7);
            Name = "MainForm";
            Text = "電卓";
            ResumeLayout(false);
        }

        #endregion

        private Compornents.MyCalcButton btnCE;
        private Compornents.MyCalcButton btnCA;
        private Compornents.MyCalcButton btnEqual;
        private Compornents.MyCalcButton btnAdd;
        private Compornents.MyCalcButton btnSubstract;
        private Compornents.MyCalcButton btnMultiply;
        private Compornents.MyCalcButton btnDivide;
        private Compornents.MyCalcButton btnDigit;
        private Compornents.MyCalcButton btn0;
        private Compornents.MyCalcButton btn3;
        private Compornents.MyCalcButton btn2;
        private Compornents.MyCalcButton btn1;
        private Compornents.MyCalcButton btn6;
        private Compornents.MyCalcButton btn4;
        private Compornents.MyCalcButton btn9;
        private Compornents.MyCalcButton btn8;
        private Compornents.MyCalcButton btn5;
        private Label lblDisplay;
        private Compornents.MyCalcButton btn7;
    }
}
