namespace MyCalculator
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
            this.MyOutputField = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Decimal_Button = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.PosNeg_Button = new System.Windows.Forms.Button();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.CurrentExpression = new System.Windows.Forms.RichTextBox();
            this.BackSpace_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.ClearEntry_Button = new System.Windows.Forms.Button();
            this.Subtraction_Button = new System.Windows.Forms.Button();
            this.Multiplication_Button = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyOutputField
            // 
            this.MyOutputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyOutputField.Location = new System.Drawing.Point(12, 49);
            this.MyOutputField.Name = "MyOutputField";
            this.MyOutputField.ReadOnly = true;
            this.MyOutputField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyOutputField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MyOutputField.Size = new System.Drawing.Size(358, 59);
            this.MyOutputField.TabIndex = 0;
            this.MyOutputField.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(64, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(116, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(116, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(64, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 42);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(116, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 42);
            this.button7.TabIndex = 9;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(64, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(12, 258);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 42);
            this.button9.TabIndex = 7;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // Decimal_Button
            // 
            this.Decimal_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Decimal_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal_Button.Location = new System.Drawing.Point(116, 306);
            this.Decimal_Button.Name = "Decimal_Button";
            this.Decimal_Button.Size = new System.Drawing.Size(46, 42);
            this.Decimal_Button.TabIndex = 12;
            this.Decimal_Button.Text = ".";
            this.Decimal_Button.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(64, 306);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 42);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.PushingANumKey);
            // 
            // PosNeg_Button
            // 
            this.PosNeg_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PosNeg_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosNeg_Button.Location = new System.Drawing.Point(12, 306);
            this.PosNeg_Button.Name = "PosNeg_Button";
            this.PosNeg_Button.Size = new System.Drawing.Size(46, 42);
            this.PosNeg_Button.TabIndex = 10;
            this.PosNeg_Button.UseVisualStyleBackColor = false;
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_Button.Location = new System.Drawing.Point(168, 306);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(46, 42);
            this.Calculate_Button.TabIndex = 13;
            this.Calculate_Button.Text = "=";
            this.Calculate_Button.UseVisualStyleBackColor = false;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Operation);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(168, 258);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(46, 42);
            this.Add_Button.TabIndex = 14;
            this.Add_Button.Text = "+";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Binary_Operation);
            // 
            // CurrentExpression
            // 
            this.CurrentExpression.Location = new System.Drawing.Point(12, 22);
            this.CurrentExpression.Name = "CurrentExpression";
            this.CurrentExpression.ReadOnly = true;
            this.CurrentExpression.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentExpression.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CurrentExpression.Size = new System.Drawing.Size(358, 32);
            this.CurrentExpression.TabIndex = 15;
            this.CurrentExpression.Text = "";
            // 
            // BackSpace_Button
            // 
            this.BackSpace_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackSpace_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpace_Button.Location = new System.Drawing.Point(116, 114);
            this.BackSpace_Button.Name = "BackSpace_Button";
            this.BackSpace_Button.Size = new System.Drawing.Size(46, 42);
            this.BackSpace_Button.TabIndex = 18;
            this.BackSpace_Button.Text = "DEL";
            this.BackSpace_Button.UseVisualStyleBackColor = false;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.Location = new System.Drawing.Point(64, 114);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(46, 42);
            this.Clear_Button.TabIndex = 17;
            this.Clear_Button.Text = "C";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Operation);
            // 
            // ClearEntry_Button
            // 
            this.ClearEntry_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearEntry_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntry_Button.Location = new System.Drawing.Point(12, 114);
            this.ClearEntry_Button.Name = "ClearEntry_Button";
            this.ClearEntry_Button.Size = new System.Drawing.Size(46, 42);
            this.ClearEntry_Button.TabIndex = 16;
            this.ClearEntry_Button.Text = "CE";
            this.ClearEntry_Button.UseVisualStyleBackColor = false;
            this.ClearEntry_Button.Click += new System.EventHandler(this.ClearEntity_Operation);
            // 
            // Subtraction_Button
            // 
            this.Subtraction_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Subtraction_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction_Button.Location = new System.Drawing.Point(168, 209);
            this.Subtraction_Button.Name = "Subtraction_Button";
            this.Subtraction_Button.Size = new System.Drawing.Size(46, 42);
            this.Subtraction_Button.TabIndex = 19;
            this.Subtraction_Button.Text = "-";
            this.Subtraction_Button.UseVisualStyleBackColor = false;
            this.Subtraction_Button.Click += new System.EventHandler(this.Binary_Operation);
            // 
            // Multiplication_Button
            // 
            this.Multiplication_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Multiplication_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication_Button.Location = new System.Drawing.Point(168, 161);
            this.Multiplication_Button.Name = "Multiplication_Button";
            this.Multiplication_Button.Size = new System.Drawing.Size(46, 42);
            this.Multiplication_Button.TabIndex = 20;
            this.Multiplication_Button.Text = "X";
            this.Multiplication_Button.UseVisualStyleBackColor = false;
            this.Multiplication_Button.Click += new System.EventHandler(this.Binary_Operation);
            // 
            // Division_Button
            // 
            this.Division_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Division_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division_Button.Location = new System.Drawing.Point(168, 114);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(46, 42);
            this.Division_Button.TabIndex = 21;
            this.Division_Button.UseVisualStyleBackColor = false;
            this.Division_Button.Click += new System.EventHandler(this.Binary_Operation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.Division_Button);
            this.Controls.Add(this.Multiplication_Button);
            this.Controls.Add(this.Subtraction_Button);
            this.Controls.Add(this.BackSpace_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.ClearEntry_Button);
            this.Controls.Add(this.CurrentExpression);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Calculate_Button);
            this.Controls.Add(this.Decimal_Button);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.PosNeg_Button);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyOutputField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MyOutputField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Decimal_Button;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button PosNeg_Button;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.RichTextBox CurrentExpression;
        private System.Windows.Forms.Button BackSpace_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button ClearEntry_Button;
        private System.Windows.Forms.Button Subtraction_Button;
        private System.Windows.Forms.Button Multiplication_Button;
        private System.Windows.Forms.Button Division_Button;
    }
}

