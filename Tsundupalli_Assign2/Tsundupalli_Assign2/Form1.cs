/*****************************************************
 * Assignment: 2                                     *
 * Due Date: Thursday, 27th Sep                      *
 *                                                   *
 * Name: Saikeerthi Tsundupalli(Z1836733)             *
 * Partner Name:Komal Thakkar (Z1834925)             *
 *                                                   *
 ****************************************************/

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace Tsundupalli_Assign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set values to Student and Course Listboxes
            UpdateFormFields();
            //Set values to Major Combobox
            foreach (string m in Course.Major)
                Major_ComboBox.Items.Add(m);
            //Set values to Academic Year Combobox
            foreach (AcademicYear a in Enum.GetValues(typeof(AcademicYear)))
                AcademicYear_ComboBox.Items.Add(a);
        }

        /******** UpdateFormFields reloads the list boxes with all the data ********/
        private void UpdateFormFields()
        {
            StudentPool_ListBox.Items.Clear();
            CoursePool_ListBox.Items.Clear();
            foreach (Student s in Student.StudentPool)
                StudentPool_ListBox.Items.Add("z"+ s.ZID + " -- " + s.LastName + ", " + s.FirstName);
            foreach (Course c in Course.CoursePool)
                CoursePool_ListBox.Items.Add(c);
        }


        /******** OutputField_ShowMessage function takes message to show in MessageBox and the type of the message to change the text color ********/
        private void OutputField_ShowMessage(string text, int? type)
        {
            if (type == 1)
            {
                Output_RichTextBox.ForeColor = System.Drawing.Color.Green;
            }
            else if (type == 0)
            {
                Output_RichTextBox.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Output_RichTextBox.ForeColor = System.Drawing.Color.Black;
            }
            Output_RichTextBox.Text = text;
        }


        /******** PrintCourseRoaster_Button_Click shows the course details for the selected course from the Course listbox ********/
        private void PrintCourseRoaster_Button_Click(object sender, EventArgs e)
        {
            int UserInput = CoursePool_ListBox.SelectedIndex;
            string OutputMsg = "";

            if (UserInput != -1)
            {
                Course obj = Course.CoursePool[UserInput];
                OutputMsg = "Course: " + obj.ToString();
                OutputMsg += "\n---------------------------------------------------------------------";
                if (Convert.ToInt16(obj.NumOfCurrentlyEnrolled) == 0)
                {
                    OutputMsg += "\nThere isn't anyone enrolled into " + obj.DeptCode + " " + obj.CourseNumber + "-" + obj.SectionNumber + ".";
                }
                else
                {
                    foreach (int rec in obj.CurrentlyEnrolled)
                    {
                        Student s = Student.StudentPool.Find(x => x.ZID == rec);
                        OutputMsg += "\n" + s.ToString();
                    }
                }

                OutputField_ShowMessage(OutputMsg, null);
            }
            else
            {
                OutputField_ShowMessage("Please select a Course from the list.", 0);
            }
        }


        /******** Student_EnrollDrop_Button_Click performs the enrollment or drop for selected the Student and the Course from the Listboxes ********/
        private void Student_EnrollDrop_Button_Click(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            int Selected_Student = StudentPool_ListBox.SelectedIndex;
            int Selected_Course = CoursePool_ListBox.SelectedIndex;
            string OutputMsg = "";
            int MsgType = 0;

            if (Selected_Student != -1 && Selected_Course != -1)
            {
                Course newCourse = Course.CoursePool[Selected_Course];
                Student student = Student.StudentPool[Selected_Student];

                if (ClickedButton.Name == "EnrollStudent_Button")
                {
                    if (newCourse.NumOfCurrentlyEnrolled + 1 > newCourse.MaxCapacity)
                    {
                        OutputMsg = "Error: " + newCourse.DeptCode + " " + newCourse.CourseNumber + "-" + newCourse.SectionNumber + " is full. No seat available.";
                    }
                    else if (newCourse.CurrentlyEnrolled.Contains(Convert.ToInt32(student.ZID)))
                    {
                        OutputMsg = "Error: Z" + student.ZID + " is already enrolled into this course.";
                    }
                    else if (newCourse.CreditHours + newCourse.NumOfCurrentlyEnrolled > 18)
                    {
                        OutputMsg = "Error: Z" + student.ZID + " has already enrolled for 18 credits.";
                    }
                    else
                    {
                        student.NumOfCreditHoursEnrolled = (ushort)(newCourse.NumOfCurrentlyEnrolled + newCourse.CreditHours);
                        newCourse.NumOfCurrentlyEnrolled = (ushort)((int)(newCourse.NumOfCurrentlyEnrolled) + 1);
                        newCourse.CurrentlyEnrolled.Add(Convert.ToInt32(student.ZID));
                        MsgType = 1;
                        OutputMsg = "Z" + student.ZID + " has successfully been enrolled into " + newCourse.ToString();
                    }
                }
                else if (ClickedButton.Name == "DropStudent_Button")
                {
                    if (!newCourse.CurrentlyEnrolled.Contains(Convert.ToInt32(student.ZID)))
                    {
                        OutputMsg = "Z" + student.ZID + " is not enrolled in the selected course.";
                    }
                    else
                    {
                        student.NumOfCreditHoursEnrolled = (ushort)(student.NumOfCreditHoursEnrolled - newCourse.CreditHours);
                        newCourse.NumOfCurrentlyEnrolled = (ushort)((int)(newCourse.NumOfCurrentlyEnrolled) - 1);
                        newCourse.CurrentlyEnrolled.Remove(Convert.ToInt32(student.ZID));
                        MsgType = 1;
                        OutputMsg = "Z" + student.ZID + " has successfully been dropped into " + newCourse.ToString();
                    }
                }
                UpdateFormFields();
            }
            else
            {
                OutputMsg = "Please select a Student and a Course from the list.";
            }
            OutputField_ShowMessage(OutputMsg, MsgType);
        }


        /******** AddStudent_Button_Click validates User Input and adds Student to the Student Pool and updates the Student Listbox  ********/
        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            string NameInput = LastFirstName_TextBox.Text;
            string Zid = ZID_TextBox.Text.ToLower();
            int Major = Major_ComboBox.SelectedIndex;
            int AcYear = AcademicYear_ComboBox.SelectedIndex;
            string OutputMsg = "";
            int MsgType = 0;
            bool Is_Valid = true;

            string[] Splitted_Words = NameInput.Split(',');
            string LastName = Splitted_Words[0];
            string FirstName = Splitted_Words.Length == 2 ? Splitted_Words[1] : "";

            Zid = Zid.Contains('z') ? Zid.Replace('z', ' ').Trim() : Zid;

            if (LastName == "" || Zid == "" || Major == -1 || AcYear == -1)
            {
                Is_Valid = false;
                OutputMsg = "Please fill all the information.";
            }
            else if (FirstName == "")
            {
                Is_Valid = false;
                OutputMsg = "Please enter the last name and first name seperated with comma.";
            }
            else if (!Regex.IsMatch(Zid, @"^[0-9]*$") || Zid.Length != 7)
            {
                Is_Valid = false;
                OutputMsg = "Please enter the valid Z-ID. Z-ID must be of exactly seven numbers.";
            }
            else if (Student.StudentPool.Find(x => x.ZID.ToString() == Zid) != null)
            {
                Is_Valid = false;
                OutputMsg = "Z"+ Zid + " already exists.";
            }
            if(Is_Valid)
            {
                Student student = new Student(Convert.ToUInt32(Zid), LastName, FirstName, Course.Major[Major], (float)0.000, (AcademicYear)AcYear);
                Student.StudentPool.Add(student);

                StudentPool_ListBox.Items.Clear();
                foreach (Student s in Student.StudentPool)
                    StudentPool_ListBox.Items.Add(s.ZID + " -- " + s.LastName + ", " + s.FirstName);
                OutputMsg = "Z" + Zid + " added successfully.";
                MsgType = 1;
            }
            OutputField_ShowMessage(OutputMsg, MsgType);
        }


        /******** AddCourse_Button_Click validates User Input and adds Course to the Course Pool and updates the Course Listbox  ********/
        private void AddCourse_Button_Click(object sender, EventArgs e)
        {
            string Dept_Code = DepartmentCode_TextBox.Text;
            string Course_Number = CourseNumber_TextBox.Text;
            string Section_Number = SectionNumber_TextBox.Text;
            int Max_Capacity = Convert.ToInt32(Capacity_NumericUpDown.Value.ToString());

            string OutputMsg = "";
            int MsgType = 0;
            bool Is_Valid = true;

            if (Dept_Code == "" || Course_Number == "" || Section_Number == "")
            {
                Is_Valid = false;
                OutputMsg = "Please fill all the information.";
            }
            else if (!(Regex.IsMatch(Dept_Code, @"^[a-zA-Z0-9]*$") && Dept_Code.Length == 4))
            {
                Is_Valid = false;
                OutputMsg = "The Department Code must be exactly four alphanumeric characters.";
            }
            else if (!(Regex.IsMatch(Course_Number, @"^[0-9]*$") && Course_Number.Length == 3))
            {
                Is_Valid = false;
                OutputMsg = "The Course number must be exactly three digits.";
            }
            else if (!(Regex.IsMatch(Section_Number, @"^[a-zA-Z0-9]*$") && Section_Number.Length == 4))
            {
                Is_Valid = false;
                OutputMsg = "The Section Number must be exactly four alphanumeric characters.";
            }
            else if (Max_Capacity == 0)
            {
                Is_Valid = false;
                OutputMsg = "The capacity must be > 0.";
            }
            else if (Course.CoursePool.Find(x => (x.DeptCode == Dept_Code && x.CourseNumber.ToString() == Course_Number && x.SectionNumber == Section_Number)) != null)
            {
                Is_Valid = false;
                OutputMsg = "This course already exists.";
            }
            if (Is_Valid)
            {
                Course course = new Course(Dept_Code, Convert.ToUInt32(Course_Number), Section_Number, Convert.ToUInt16(Max_Capacity));
                Course.CoursePool.Add(course);

                CoursePool_ListBox.Items.Clear();
                foreach (Course c in Course.CoursePool)
                    CoursePool_ListBox.Items.Add(c);
                OutputMsg = course.ToString() + " course has been added successfully.";
                MsgType = 1;
            }
            OutputField_ShowMessage(OutputMsg, MsgType);
        }


        /******** StudentPool_ListBox_SelectedIndexChanged shows the Student details and the courses enrolled  ********/
        private void StudentPool_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UserInput = StudentPool_ListBox.SelectedIndex;
            string OutputMsg = "";

            if (UserInput != -1)
            {
                Student obj = Student.StudentPool[UserInput];
                OutputMsg = "Student: " + obj.ToString();
                OutputMsg += "\n---------------------------------------------------------------------";
                if (Convert.ToInt16(obj.NumOfCreditHoursEnrolled) == 0)
                {
                    OutputMsg += "\nThe student isn't anyone enrolled into  any course ";
                }
                else
                {
                    foreach (Course c in Course.CoursePool)
                    {
                        if (c.CurrentlyEnrolled.Contains(Convert.ToInt32(obj.ZID)))
                        {
                            OutputMsg += "\n" + c.DeptCode + " " + c.CourseNumber + "-" + c.SectionNumber + " " + c.NumOfCurrentlyEnrolled + "/" + c.MaxCapacity;
                        }
                    }
                }
                OutputField_ShowMessage(OutputMsg, null);
            }
            else
            {
                OutputField_ShowMessage("Please select a Course from the list.", 0);
            }
        }


        /******** ApplySearch_Button_Click looks for the details of the entered Student Zid and the Course Department ID in the Pools  ********/
        private void ApplySearch_Button_Click(object sender, EventArgs e)
        {
            string StudentSearch = SearchStudent_TextBox.Text.ToLower();
            string CourseSearch = CourseSearch_TextBox.Text;
            var courses = Course.CoursePool;
            var students = Student.StudentPool;
            StudentSearch = StudentSearch.Contains('z') ? StudentSearch.Replace('z', ' ').Trim() : StudentSearch;

            if (StudentSearch != "")
            {
                students = Student.StudentPool.Where(x => x.ZID.ToString().StartsWith(StudentSearch)).ToList();
            }
            if (CourseSearch != "")
            {
                courses = Course.CoursePool.FindAll(x => (x.DeptCode == CourseSearch));
            }

            StudentPool_ListBox.Items.Clear();
            CoursePool_ListBox.Items.Clear();
            foreach (Student s in students)
                StudentPool_ListBox.Items.Add("z" + s.ZID + " -- " + s.LastName + ", " + s.FirstName);
            foreach (Course c in courses)
                CoursePool_ListBox.Items.Add(c);
        }
    }
}
