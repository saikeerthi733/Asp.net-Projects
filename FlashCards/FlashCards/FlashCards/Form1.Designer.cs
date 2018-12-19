namespace FlashCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Question_Answer_Box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Skip_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Progress_Bar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Correct_Button = new System.Windows.Forms.Button();
            this.Fail_Button = new System.Windows.Forms.Button();
            this.Percentage_Box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Question_Answer_Box
            // 
            this.Question_Answer_Box.BackColor = System.Drawing.Color.Black;
            this.Question_Answer_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Question_Answer_Box.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question_Answer_Box.ForeColor = System.Drawing.SystemColors.Window;
            this.Question_Answer_Box.Location = new System.Drawing.Point(16, 30);
            this.Question_Answer_Box.Name = "Question_Answer_Box";
            this.Question_Answer_Box.ReadOnly = true;
            this.Question_Answer_Box.Size = new System.Drawing.Size(448, 241);
            this.Question_Answer_Box.TabIndex = 0;
            this.Question_Answer_Box.Text = "";
            this.Question_Answer_Box.Click += new System.EventHandler(this.FlipCardOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on the card to flip it over";
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.Color.Black;
            this.Reset_Button.ForeColor = System.Drawing.Color.White;
            this.Reset_Button.Location = new System.Drawing.Point(641, 248);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 23);
            this.Reset_Button.TabIndex = 3;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Skip_Button
            // 
            this.Skip_Button.BackColor = System.Drawing.Color.Black;
            this.Skip_Button.ForeColor = System.Drawing.Color.White;
            this.Skip_Button.Location = new System.Drawing.Point(479, 248);
            this.Skip_Button.Name = "Skip_Button";
            this.Skip_Button.Size = new System.Drawing.Size(75, 23);
            this.Skip_Button.TabIndex = 4;
            this.Skip_Button.Text = "Skip";
            this.Skip_Button.UseVisualStyleBackColor = false;
            this.Skip_Button.Click += new System.EventHandler(this.Skip_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(487, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Percentage of Correct Responses";
            // 
            // Progress_Bar
            // 
            this.Progress_Bar.BackColor = System.Drawing.Color.Black;
            this.Progress_Bar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Progress_Bar.Location = new System.Drawing.Point(490, 105);
            this.Progress_Bar.Maximum = 200;
            this.Progress_Bar.Name = "Progress_Bar";
            this.Progress_Bar.Size = new System.Drawing.Size(157, 23);
            this.Progress_Bar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(487, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Progress Bar";
            // 
            // Correct_Button
            // 
            this.Correct_Button.Image = ((System.Drawing.Image)(resources.GetObject("Correct_Button.Image")));
            this.Correct_Button.Location = new System.Drawing.Point(490, 149);
            this.Correct_Button.Name = "Correct_Button";
            this.Correct_Button.Size = new System.Drawing.Size(64, 64);
            this.Correct_Button.TabIndex = 10;
            this.Correct_Button.UseVisualStyleBackColor = true;
            this.Correct_Button.Click += new System.EventHandler(this.RightOrWrong);
            // 
            // Fail_Button
            // 
            this.Fail_Button.Image = ((System.Drawing.Image)(resources.GetObject("Fail_Button.Image")));
            this.Fail_Button.Location = new System.Drawing.Point(583, 149);
            this.Fail_Button.Name = "Fail_Button";
            this.Fail_Button.Size = new System.Drawing.Size(64, 64);
            this.Fail_Button.TabIndex = 11;
            this.Fail_Button.UseVisualStyleBackColor = true;
            this.Fail_Button.Click += new System.EventHandler(this.RightOrWrong);
            // 
            // Percentage_Box
            // 
            this.Percentage_Box.BackColor = System.Drawing.Color.Black;
            this.Percentage_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Percentage_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage_Box.ForeColor = System.Drawing.SystemColors.Window;
            this.Percentage_Box.Location = new System.Drawing.Point(490, 33);
            this.Percentage_Box.Name = "Percentage_Box";
            this.Percentage_Box.Size = new System.Drawing.Size(157, 40);
            this.Percentage_Box.TabIndex = 12;
            this.Percentage_Box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 286);
            this.Controls.Add(this.Percentage_Box);
            this.Controls.Add(this.Fail_Button);
            this.Controls.Add(this.Correct_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Progress_Bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Skip_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question_Answer_Box);
            this.Name = "Form1";
            this.Text = ".NET\'s Dark Themed FlashCards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Question_Answer_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Skip_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Progress_Bar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Correct_Button;
        private System.Windows.Forms.Button Fail_Button;
        private System.Windows.Forms.RichTextBox Percentage_Box;
    }
}

