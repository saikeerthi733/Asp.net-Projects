namespace TicTacToe
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
            this.PlayingField = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatsBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pickingX = new System.Windows.Forms.RadioButton();
            this.pickingO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.WhosPlaying = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayingField)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayingField
            // 
            this.PlayingField.BackColor = System.Drawing.Color.Black;
            this.PlayingField.Location = new System.Drawing.Point(360, 12);
            this.PlayingField.Name = "PlayingField";
            this.PlayingField.Size = new System.Drawing.Size(420, 420);
            this.PlayingField.TabIndex = 0;
            this.PlayingField.TabStop = false;
            this.PlayingField.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayingField_Paint);
            this.PlayingField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayingField_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 375);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistics";
            // 
            // StatsBox
            // 
            this.StatsBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsBox.Location = new System.Drawing.Point(17, 41);
            this.StatsBox.Name = "StatsBox";
            this.StatsBox.Size = new System.Drawing.Size(259, 96);
            this.StatsBox.TabIndex = 4;
            this.StatsBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Your Shape";
            // 
            // pickingX
            // 
            this.pickingX.AutoSize = true;
            this.pickingX.Checked = true;
            this.pickingX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickingX.Location = new System.Drawing.Point(24, 19);
            this.pickingX.Name = "pickingX";
            this.pickingX.Size = new System.Drawing.Size(45, 29);
            this.pickingX.TabIndex = 7;
            this.pickingX.TabStop = true;
            this.pickingX.Text = "X";
            this.pickingX.UseVisualStyleBackColor = true;
            this.pickingX.Click += new System.EventHandler(this.picking_Click);
            // 
            // pickingO
            // 
            this.pickingO.AutoSize = true;
            this.pickingO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickingO.Location = new System.Drawing.Point(132, 19);
            this.pickingO.Name = "pickingO";
            this.pickingO.Size = new System.Drawing.Size(47, 29);
            this.pickingO.TabIndex = 8;
            this.pickingO.Text = "O";
            this.pickingO.UseVisualStyleBackColor = true;
            this.pickingO.Click += new System.EventHandler(this.picking_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickingX);
            this.groupBox1.Controls.Add(this.pickingO);
            this.groupBox1.Location = new System.Drawing.Point(23, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset Stats";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // WhosPlaying
            // 
            this.WhosPlaying.AutoSize = true;
            this.WhosPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhosPlaying.Location = new System.Drawing.Point(197, 13);
            this.WhosPlaying.Name = "WhosPlaying";
            this.WhosPlaying.Size = new System.Drawing.Size(0, 24);
            this.WhosPlaying.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 449);
            this.Controls.Add(this.WhosPlaying);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PlayingField);
            this.Name = "Form1";
            this.Text = ".NET\'s Tic Tac Toe";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PlayingField)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayingField;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox StatsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton pickingX;
        private System.Windows.Forms.RadioButton pickingO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label WhosPlaying;
    }
}

