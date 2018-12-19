namespace Tsundupalli_Assign2
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
            this.PrintCourseRoaster_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplySearch_Button = new System.Windows.Forms.Button();
            this.DropStudent_Button = new System.Windows.Forms.Button();
            this.AddStudent_Button = new System.Windows.Forms.Button();
            this.AddCourse_Button = new System.Windows.Forms.Button();
            this.Output_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.LastFirstName_Label = new System.Windows.Forms.Label();
            this.LastFirstName_TextBox = new System.Windows.Forms.TextBox();
            this.CourseNumber_TextBox = new System.Windows.Forms.TextBox();
            this.DepartmentCode_Label = new System.Windows.Forms.Label();
            this.ZID_TextBox = new System.Windows.Forms.TextBox();
            this.ZID_Label = new System.Windows.Forms.Label();
            this.AcademicYear_Label = new System.Windows.Forms.Label();
            this.Major_Label = new System.Windows.Forms.Label();
            this.AcademicYear_ComboBox = new System.Windows.Forms.ComboBox();
            this.CourseNumber_Label = new System.Windows.Forms.Label();
            this.Capacity_Label = new System.Windows.Forms.Label();
            this.SectionNumber_Label = new System.Windows.Forms.Label();
            this.SectionNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Capacity_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SearchStudent_TextBox = new System.Windows.Forms.TextBox();
            this.SearchStudent_Label = new System.Windows.Forms.Label();
            this.CourseSearch_TextBox = new System.Windows.Forms.TextBox();
            this.FilterCourses_Label = new System.Windows.Forms.Label();
            this.StudentList_Label = new System.Windows.Forms.Label();
            this.CourseList_Label = new System.Windows.Forms.Label();
            this.StudentPool_ListBox = new System.Windows.Forms.ListBox();
            this.CoursePool_ListBox = new System.Windows.Forms.ListBox();
            this.EnrollStudent_Button = new System.Windows.Forms.Button();
            this.Major_ComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentCode_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintCourseRoaster_Button
            // 
            this.PrintCourseRoaster_Button.Location = new System.Drawing.Point(12, 65);
            this.PrintCourseRoaster_Button.Name = "PrintCourseRoaster_Button";
            this.PrintCourseRoaster_Button.Size = new System.Drawing.Size(190, 44);
            this.PrintCourseRoaster_Button.TabIndex = 0;
            this.PrintCourseRoaster_Button.Text = "Print Course Roaster";
            this.PrintCourseRoaster_Button.UseVisualStyleBackColor = true;
            this.PrintCourseRoaster_Button.Click += new System.EventHandler(this.PrintCourseRoaster_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIU Enrollment Management System";
            // 
            // ApplySearch_Button
            // 
            this.ApplySearch_Button.Location = new System.Drawing.Point(12, 218);
            this.ApplySearch_Button.Name = "ApplySearch_Button";
            this.ApplySearch_Button.Size = new System.Drawing.Size(190, 44);
            this.ApplySearch_Button.TabIndex = 5;
            this.ApplySearch_Button.Text = "Apply Search Criteria";
            this.ApplySearch_Button.UseVisualStyleBackColor = true;
            this.ApplySearch_Button.Click += new System.EventHandler(this.ApplySearch_Button_Click);
            // 
            // DropStudent_Button
            // 
            this.DropStudent_Button.Location = new System.Drawing.Point(12, 167);
            this.DropStudent_Button.Name = "DropStudent_Button";
            this.DropStudent_Button.Size = new System.Drawing.Size(190, 44);
            this.DropStudent_Button.TabIndex = 2;
            this.DropStudent_Button.Text = "Drop Student";
            this.DropStudent_Button.UseVisualStyleBackColor = true;
            this.DropStudent_Button.Click += new System.EventHandler(this.Student_EnrollDrop_Button_Click);
            // 
            // AddStudent_Button
            // 
            this.AddStudent_Button.Location = new System.Drawing.Point(12, 396);
            this.AddStudent_Button.Name = "AddStudent_Button";
            this.AddStudent_Button.Size = new System.Drawing.Size(124, 34);
            this.AddStudent_Button.TabIndex = 10;
            this.AddStudent_Button.Text = "Add Student";
            this.AddStudent_Button.UseVisualStyleBackColor = true;
            this.AddStudent_Button.Click += new System.EventHandler(this.AddStudent_Button_Click);
            // 
            // AddCourse_Button
            // 
            this.AddCourse_Button.Location = new System.Drawing.Point(12, 594);
            this.AddCourse_Button.Name = "AddCourse_Button";
            this.AddCourse_Button.Size = new System.Drawing.Size(124, 34);
            this.AddCourse_Button.TabIndex = 15;
            this.AddCourse_Button.Text = "Add Course";
            this.AddCourse_Button.UseVisualStyleBackColor = true;
            this.AddCourse_Button.Click += new System.EventHandler(this.AddCourse_Button_Click);
            // 
            // Output_RichTextBox
            // 
            this.Output_RichTextBox.ForeColor = System.Drawing.Color.Red;
            this.Output_RichTextBox.Location = new System.Drawing.Point(12, 637);
            this.Output_RichTextBox.Name = "Output_RichTextBox";
            this.Output_RichTextBox.Size = new System.Drawing.Size(1078, 174);
            this.Output_RichTextBox.TabIndex = 18;
            this.Output_RichTextBox.Text = "";
            // 
            // LastFirstName_Label
            // 
            this.LastFirstName_Label.AutoSize = true;
            this.LastFirstName_Label.Location = new System.Drawing.Point(9, 282);
            this.LastFirstName_Label.Name = "LastFirstName_Label";
            this.LastFirstName_Label.Size = new System.Drawing.Size(152, 17);
            this.LastFirstName_Label.TabIndex = 10;
            this.LastFirstName_Label.Text = "Last Name, First Name";
            // 
            // LastFirstName_TextBox
            // 
            this.LastFirstName_TextBox.Location = new System.Drawing.Point(12, 302);
            this.LastFirstName_TextBox.Multiline = true;
            this.LastFirstName_TextBox.Name = "LastFirstName_TextBox";
            this.LastFirstName_TextBox.Size = new System.Drawing.Size(190, 36);
            this.LastFirstName_TextBox.TabIndex = 6;
            // 
            // CourseNumber_TextBox
            // 
            this.CourseNumber_TextBox.Location = new System.Drawing.Point(243, 482);
            this.CourseNumber_TextBox.Multiline = true;
            this.CourseNumber_TextBox.Name = "CourseNumber_TextBox";
            this.CourseNumber_TextBox.Size = new System.Drawing.Size(190, 36);
            this.CourseNumber_TextBox.TabIndex = 12;
            // 
            // DepartmentCode_Label
            // 
            this.DepartmentCode_Label.AutoSize = true;
            this.DepartmentCode_Label.Location = new System.Drawing.Point(9, 460);
            this.DepartmentCode_Label.Name = "DepartmentCode_Label";
            this.DepartmentCode_Label.Size = new System.Drawing.Size(119, 17);
            this.DepartmentCode_Label.TabIndex = 12;
            this.DepartmentCode_Label.Text = "Department Code";
            // 
            // ZID_TextBox
            // 
            this.ZID_TextBox.Location = new System.Drawing.Point(243, 302);
            this.ZID_TextBox.Multiline = true;
            this.ZID_TextBox.Name = "ZID_TextBox";
            this.ZID_TextBox.Size = new System.Drawing.Size(190, 36);
            this.ZID_TextBox.TabIndex = 7;
            // 
            // ZID_Label
            // 
            this.ZID_Label.AutoSize = true;
            this.ZID_Label.Location = new System.Drawing.Point(240, 282);
            this.ZID_Label.Name = "ZID_Label";
            this.ZID_Label.Size = new System.Drawing.Size(35, 17);
            this.ZID_Label.TabIndex = 14;
            this.ZID_Label.Text = "Z-ID";
            // 
            // AcademicYear_Label
            // 
            this.AcademicYear_Label.AutoSize = true;
            this.AcademicYear_Label.Location = new System.Drawing.Point(240, 343);
            this.AcademicYear_Label.Name = "AcademicYear_Label";
            this.AcademicYear_Label.Size = new System.Drawing.Size(103, 17);
            this.AcademicYear_Label.TabIndex = 18;
            this.AcademicYear_Label.Text = "Academic Year";
            // 
            // Major_Label
            // 
            this.Major_Label.AutoSize = true;
            this.Major_Label.Location = new System.Drawing.Point(9, 343);
            this.Major_Label.Name = "Major_Label";
            this.Major_Label.Size = new System.Drawing.Size(43, 17);
            this.Major_Label.TabIndex = 16;
            this.Major_Label.Text = "Major";
            // 
            // AcademicYear_ComboBox
            // 
            this.AcademicYear_ComboBox.FormattingEnabled = true;
            this.AcademicYear_ComboBox.IntegralHeight = false;
            this.AcademicYear_ComboBox.ItemHeight = 16;
            this.AcademicYear_ComboBox.Location = new System.Drawing.Point(243, 363);
            this.AcademicYear_ComboBox.Name = "AcademicYear_ComboBox";
            this.AcademicYear_ComboBox.Size = new System.Drawing.Size(190, 24);
            this.AcademicYear_ComboBox.TabIndex = 9;
            // 
            // CourseNumber_Label
            // 
            this.CourseNumber_Label.AutoSize = true;
            this.CourseNumber_Label.Location = new System.Drawing.Point(240, 460);
            this.CourseNumber_Label.Name = "CourseNumber_Label";
            this.CourseNumber_Label.Size = new System.Drawing.Size(107, 17);
            this.CourseNumber_Label.TabIndex = 23;
            this.CourseNumber_Label.Text = "Course Number";
            // 
            // Capacity_Label
            // 
            this.Capacity_Label.AutoSize = true;
            this.Capacity_Label.Location = new System.Drawing.Point(240, 529);
            this.Capacity_Label.Name = "Capacity_Label";
            this.Capacity_Label.Size = new System.Drawing.Size(62, 17);
            this.Capacity_Label.TabIndex = 27;
            this.Capacity_Label.Text = "Capacity";
            // 
            // SectionNumber_Label
            // 
            this.SectionNumber_Label.AutoSize = true;
            this.SectionNumber_Label.Location = new System.Drawing.Point(9, 529);
            this.SectionNumber_Label.Name = "SectionNumber_Label";
            this.SectionNumber_Label.Size = new System.Drawing.Size(109, 17);
            this.SectionNumber_Label.TabIndex = 24;
            this.SectionNumber_Label.Text = "Section Number";
            // 
            // SectionNumber_TextBox
            // 
            this.SectionNumber_TextBox.Location = new System.Drawing.Point(12, 550);
            this.SectionNumber_TextBox.MinimumSize = new System.Drawing.Size(4, 36);
            this.SectionNumber_TextBox.Multiline = true;
            this.SectionNumber_TextBox.Name = "SectionNumber_TextBox";
            this.SectionNumber_TextBox.Size = new System.Drawing.Size(190, 36);
            this.SectionNumber_TextBox.TabIndex = 13;
            // 
            // Capacity_NumericUpDown
            // 
            this.Capacity_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Capacity_NumericUpDown.Location = new System.Drawing.Point(243, 550);
            this.Capacity_NumericUpDown.Name = "Capacity_NumericUpDown";
            this.Capacity_NumericUpDown.Size = new System.Drawing.Size(190, 36);
            this.Capacity_NumericUpDown.TabIndex = 14;
            // 
            // SearchStudent_TextBox
            // 
            this.SearchStudent_TextBox.Location = new System.Drawing.Point(243, 85);
            this.SearchStudent_TextBox.Multiline = true;
            this.SearchStudent_TextBox.Name = "SearchStudent_TextBox";
            this.SearchStudent_TextBox.Size = new System.Drawing.Size(190, 36);
            this.SearchStudent_TextBox.TabIndex = 3;
            // 
            // SearchStudent_Label
            // 
            this.SearchStudent_Label.AutoSize = true;
            this.SearchStudent_Label.Location = new System.Drawing.Point(240, 65);
            this.SearchStudent_Label.Name = "SearchStudent_Label";
            this.SearchStudent_Label.Size = new System.Drawing.Size(174, 17);
            this.SearchStudent_Label.TabIndex = 30;
            this.SearchStudent_Label.Text = "Search Student ( by Z-ID )";
            // 
            // CourseSearch_TextBox
            // 
            this.CourseSearch_TextBox.Location = new System.Drawing.Point(243, 144);
            this.CourseSearch_TextBox.Multiline = true;
            this.CourseSearch_TextBox.Name = "CourseSearch_TextBox";
            this.CourseSearch_TextBox.Size = new System.Drawing.Size(190, 36);
            this.CourseSearch_TextBox.TabIndex = 4;
            // 
            // FilterCourses_Label
            // 
            this.FilterCourses_Label.AutoSize = true;
            this.FilterCourses_Label.Location = new System.Drawing.Point(240, 124);
            this.FilterCourses_Label.Name = "FilterCourses_Label";
            this.FilterCourses_Label.Size = new System.Drawing.Size(166, 17);
            this.FilterCourses_Label.TabIndex = 32;
            this.FilterCourses_Label.Text = "Filter Courses ( by Dept )";
            // 
            // StudentList_Label
            // 
            this.StudentList_Label.AutoSize = true;
            this.StudentList_Label.Location = new System.Drawing.Point(531, 65);
            this.StudentList_Label.Name = "StudentList_Label";
            this.StudentList_Label.Size = new System.Drawing.Size(83, 17);
            this.StudentList_Label.TabIndex = 34;
            this.StudentList_Label.Text = "Student List";
            // 
            // CourseList_Label
            // 
            this.CourseList_Label.AutoSize = true;
            this.CourseList_Label.Location = new System.Drawing.Point(824, 65);
            this.CourseList_Label.Name = "CourseList_Label";
            this.CourseList_Label.Size = new System.Drawing.Size(79, 17);
            this.CourseList_Label.TabIndex = 35;
            this.CourseList_Label.Text = "Course List";
            // 
            // StudentPool_ListBox
            // 
            this.StudentPool_ListBox.FormattingEnabled = true;
            this.StudentPool_ListBox.ItemHeight = 16;
            this.StudentPool_ListBox.Location = new System.Drawing.Point(534, 85);
            this.StudentPool_ListBox.Name = "StudentPool_ListBox";
            this.StudentPool_ListBox.Size = new System.Drawing.Size(263, 452);
            this.StudentPool_ListBox.TabIndex = 16;
            this.StudentPool_ListBox.SelectedIndexChanged += new System.EventHandler(this.StudentPool_ListBox_SelectedIndexChanged);
            // 
            // CoursePool_ListBox
            // 
            this.CoursePool_ListBox.FormattingEnabled = true;
            this.CoursePool_ListBox.ItemHeight = 16;
            this.CoursePool_ListBox.Location = new System.Drawing.Point(827, 85);
            this.CoursePool_ListBox.Name = "CoursePool_ListBox";
            this.CoursePool_ListBox.Size = new System.Drawing.Size(263, 452);
            this.CoursePool_ListBox.TabIndex = 17;
            // 
            // EnrollStudent_Button
            // 
            this.EnrollStudent_Button.Location = new System.Drawing.Point(12, 115);
            this.EnrollStudent_Button.Name = "EnrollStudent_Button";
            this.EnrollStudent_Button.Size = new System.Drawing.Size(190, 44);
            this.EnrollStudent_Button.TabIndex = 1;
            this.EnrollStudent_Button.Text = "Enroll Student";
            this.EnrollStudent_Button.UseVisualStyleBackColor = true;
            this.EnrollStudent_Button.Click += new System.EventHandler(this.Student_EnrollDrop_Button_Click);
            // 
            // Major_ComboBox
            // 
            this.Major_ComboBox.FormattingEnabled = true;
            this.Major_ComboBox.ItemHeight = 16;
            this.Major_ComboBox.Location = new System.Drawing.Point(12, 363);
            this.Major_ComboBox.Name = "Major_ComboBox";
            this.Major_ComboBox.Size = new System.Drawing.Size(190, 24);
            this.Major_ComboBox.TabIndex = 8;
            // 
            // DepartmentCode_TextBox
            // 
            this.DepartmentCode_TextBox.Location = new System.Drawing.Point(12, 482);
            this.DepartmentCode_TextBox.Multiline = true;
            this.DepartmentCode_TextBox.Name = "DepartmentCode_TextBox";
            this.DepartmentCode_TextBox.Size = new System.Drawing.Size(190, 36);
            this.DepartmentCode_TextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 823);
            this.Controls.Add(this.DepartmentCode_TextBox);
            this.Controls.Add(this.Major_ComboBox);
            this.Controls.Add(this.EnrollStudent_Button);
            this.Controls.Add(this.CoursePool_ListBox);
            this.Controls.Add(this.StudentPool_ListBox);
            this.Controls.Add(this.CourseList_Label);
            this.Controls.Add(this.StudentList_Label);
            this.Controls.Add(this.CourseSearch_TextBox);
            this.Controls.Add(this.FilterCourses_Label);
            this.Controls.Add(this.SearchStudent_TextBox);
            this.Controls.Add(this.SearchStudent_Label);
            this.Controls.Add(this.Capacity_NumericUpDown);
            this.Controls.Add(this.SectionNumber_TextBox);
            this.Controls.Add(this.Capacity_Label);
            this.Controls.Add(this.SectionNumber_Label);
            this.Controls.Add(this.CourseNumber_Label);
            this.Controls.Add(this.AcademicYear_ComboBox);
            this.Controls.Add(this.AcademicYear_Label);
            this.Controls.Add(this.Major_Label);
            this.Controls.Add(this.ZID_TextBox);
            this.Controls.Add(this.ZID_Label);
            this.Controls.Add(this.CourseNumber_TextBox);
            this.Controls.Add(this.DepartmentCode_Label);
            this.Controls.Add(this.LastFirstName_TextBox);
            this.Controls.Add(this.LastFirstName_Label);
            this.Controls.Add(this.Output_RichTextBox);
            this.Controls.Add(this.AddCourse_Button);
            this.Controls.Add(this.AddStudent_Button);
            this.Controls.Add(this.DropStudent_Button);
            this.Controls.Add(this.ApplySearch_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintCourseRoaster_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Capacity_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintCourseRoaster_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApplySearch_Button;
        private System.Windows.Forms.Button DropStudent_Button;
        private System.Windows.Forms.Button AddStudent_Button;
        private System.Windows.Forms.Button AddCourse_Button;
        private System.Windows.Forms.RichTextBox Output_RichTextBox;
        private System.Windows.Forms.Label LastFirstName_Label;
        private System.Windows.Forms.TextBox LastFirstName_TextBox;
        private System.Windows.Forms.TextBox CourseNumber_TextBox;
        private System.Windows.Forms.Label DepartmentCode_Label;
        private System.Windows.Forms.TextBox ZID_TextBox;
        private System.Windows.Forms.Label ZID_Label;
        private System.Windows.Forms.Label AcademicYear_Label;
        private System.Windows.Forms.Label Major_Label;
        private System.Windows.Forms.ComboBox AcademicYear_ComboBox;
        private System.Windows.Forms.Label CourseNumber_Label;
        private System.Windows.Forms.Label Capacity_Label;
        private System.Windows.Forms.Label SectionNumber_Label;
        private System.Windows.Forms.TextBox SectionNumber_TextBox;
        private System.Windows.Forms.NumericUpDown Capacity_NumericUpDown;
        private System.Windows.Forms.TextBox SearchStudent_TextBox;
        private System.Windows.Forms.Label SearchStudent_Label;
        private System.Windows.Forms.TextBox CourseSearch_TextBox;
        private System.Windows.Forms.Label FilterCourses_Label;
        private System.Windows.Forms.Label StudentList_Label;
        private System.Windows.Forms.Label CourseList_Label;
        private System.Windows.Forms.ListBox StudentPool_ListBox;
        private System.Windows.Forms.ListBox CoursePool_ListBox;
        private System.Windows.Forms.Button EnrollStudent_Button;
        private System.Windows.Forms.ComboBox Major_ComboBox;
        private System.Windows.Forms.TextBox DepartmentCode_TextBox;
    }
}

