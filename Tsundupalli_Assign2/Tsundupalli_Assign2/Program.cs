/*****************************************************
 * Assignment: 2                                     *
 * Due Date: Thursday, 27th Sep                      *
 *                                                   *
 * Name:  Sai keerthi Tsundupalli(Z1836733)          *
 * Partner Name: Komal Thakkar (Z1834925))           *
 *                                                   *
 ****************************************************/

using System;
using System.Windows.Forms;
using System.IO;

namespace Tsundupalli_Assign2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ReadStudentInputFile();
            ReadCourseInputFile();
            ReadMajorInputFile();
            Application.Run(new Form1());
        }

        /******** Reading input files ********/
        #region
        public static void ReadStudentInputFile()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\2188_a2_input01.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] tokens = line.Split(',');
                    Student s = new Student(Convert.ToUInt32(tokens[0]), tokens[1], tokens[2], tokens[3], float.Parse(tokens[5]), (AcademicYear)Enum.Parse(typeof(AcademicYear), tokens[4]));
                    Student.StudentPool.Add(s);
                    line = sr.ReadLine();
                }
                Student.StudentPool.Sort();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadKey();
            }
        }
        public static void ReadCourseInputFile()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\2188_a2_input02.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] tokens = line.Split(',');

                    Course c = new Course();
                    for (int i = 0; i < tokens.Length; i++)
                    {
                        c.DeptCode = tokens[0];
                        c.CourseNumber = Convert.ToUInt16(tokens[1]);
                        c.SectionNumber = tokens[2];
                        c.CreditHours = Convert.ToUInt16(tokens[3]);
                        c.MaxCapacity = Convert.ToUInt16((tokens[4]));

                    }
                    Course.CoursePool.Add(c);
                    line = sr.ReadLine();
                }
                Course.CoursePool.Sort();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static void ReadMajorInputFile()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\2188_a2_input03.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Course.Major.Add(line);
                    line = sr.ReadLine();
                }
                Course.CoursePool.Sort();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        #endregion
    }
}
