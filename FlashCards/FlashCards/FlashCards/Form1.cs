/* Programmer: Everyone from CSCI 473/504!
 * Date: 10/2/18 - 10/5/18
 * Version: 1.0
 * 
 * Purpose: This Windows Form is meant to provide a digital counterpart to 
 *   physical flash cards that students might use while studying for exams.
 *   Because this is being done with computer software, it opens up the
 *   possibility of capturing various points of statistical data that (while
 *   implemented in Version 1.0) could help track student progress over a 
 *   series of FlashCard sessions, in the hopes of measuring higher accuracy
 *   over time, or identifying problematic questions that could then help
 *   more effectively utilize studying time.
 * **************************************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class Form1 : Form
    {
        //public static char[] OPERATORS = { '+', '-', '*', '/', '%' };
        //public static int left, right, answer;
        public static int index;
        public static char newOperator;
        public static bool displayQuestion;

        private static UInt16 totalRight;
        private static UInt16 total;

        private static List<FlashCards> questionPool;
        private static List<bool> asked;

        /*                                                        FLASH_CARDS
         *                                                      UTILITY CLASS
         * 
         * This class will encapsulate all of the necessary information about
         * each FlashCard, including the Q/A and (optional) statistical data.
         ********************************************************************/
        private class FlashCards
        {
            public string Question { get; set; }
            public string Answer { get; set; }
            public int Asked { get; set; }
            public int Correct { get; set; }
            public int Skipped { get; set; }

            public FlashCards()
            {
                Question = Answer = "";
                Asked = Correct = 0;
            }

            public FlashCards(string newQ, string newA)
            {
                Question = newQ;
                Answer = newA;
            }
        }


        /*                                                  FORM1_CONSTRUCTOR
         * 
         * Here, we work on initializing the Form, as well as gathering 
         * FlashCards from the input file. The commented out MessageBow line
         * below is only necessary as a confirmation/testing tool, to ensure
         * the input file was read.
         ********************************************************************/
        public Form1()
        {
            InitializeComponent();
            Percentage_Box.SelectionAlignment = HorizontalAlignment.Center;
            Question_Answer_Box.SelectionAlignment = HorizontalAlignment.Center;
            //newArithmeticExpression();
            index = -1;
            questionPool = new List<FlashCards>();
            totalRight = total = 0;

            using (StreamReader inFile = new StreamReader("..\\..\\TextFile1.txt"))
            {
                string slacker = inFile.ReadLine();
                while (slacker != null)
                {
                    questionPool.Add(new FlashCards(slacker.Split('#')[0], slacker.Split('#')[1]));
                    slacker = inFile.ReadLine();
                }

            }
            asked = new List<bool>();
            for (int i = 0; i < questionPool.Count; i++)
                asked.Add(false);

            //MessageBox.Show(String.Format("I've gathered {0} flash cards.", questionPool.Count));
            NextFlashCard();
        }


        /*                                          NEW_ARITHMETIC_EXPRESSION
         *                                       (OBSOLETE) FUNCTIONAL METHOD
         * 
         * This method is used to randomly generate a new arithmetic
         * expression to be presented.
         ********************************************************************/
        /*
       private void newArithmeticExpression()
       {
           Random newNumbers = new Random();
           left = (newNumbers.Next() % 9) + 1;
           right = (newNumbers.Next() % 9) + 1;
           newOperator = OPERATORS[newNumbers.Next() % OPERATORS.Count()];

           switch (newOperator)
           {
               case ('+'):
                   answer = left + right;
                   break;
               case ('-'):
                   answer = left - right;
                   break;
               case ('*'):
                   answer = left * right;
                   break;
               case ('/'):
                   answer = left / right;
                   break;
               case ('%'):
                   answer = left % right;
                   break;
           }

           Question_Answer_Box.Text = String.Format("\n\n\n{0}\t{1}\t{2}\t=\t?", left, newOperator, right);
           displayQuestion = true;
       }
       */


        /*                                                    NEXT_FLASH_CARD
         *                                                  FUNCTIONAL METHOD
         * 
         * This method is used to progress through the current FlashCard
         * session, to pick out another un-used FlashCard.
         * 
         * Note: In addition to the if-statement added to check whether the 
         *       progress bar has filled, I've upgraded the function of the
         *       message boxes to capture a Yes/No response, which can be
         *       used to substitute clicking the "Reset" button directly.
         *       
         *       This should be a quality-of-life feature (QoL) that reduces
         *       the number of button clicks necessary to achieve the same 
         *       result as before.
         ********************************************************************/
        private void NextFlashCard()
        {
            // First check to make sure we haven't already asked all the available questions
            if (total >= questionPool.Count)
            {
                var result = MessageBox.Show("You've gone through all available flashcards. Reset?", "Current Session Completion",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    ResetSession();
                else
                    return;
            }
            if (Progress_Bar.Value >= Progress_Bar.Maximum)
            {
                var result = MessageBox.Show("You've completed this flashcards session. Reset?", "Current Session Completion",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    ResetSession();
                else
                    return;
            }

            Random newIndex = new Random();
            index = (newIndex.Next() % questionPool.Count);
            while (asked[index])
            {
                index = (newIndex.Next() % questionPool.Count);
            }
            Question_Answer_Box.Text = String.Format("\n\n\n{0}", questionPool[index].Question);
            displayQuestion = true;
        }


        /*                                                      RESET_SESSION
         *                                                  FUNCTIONAL METHOD
         * 
         * This will be used to "reset" the current FlashCard session, to the
         * initial state.
         ********************************************************************/
        private void ResetSession()
        {
            for (int i = 0; i < asked.Count; i++)
                asked[i] = false;
            total = totalRight = 0;
            Progress_Bar.Value = 0;
            Percentage_Box.Text = "";
            Percentage_Box.BackColor = Color.Green;
            NextFlashCard();
        }

        // *******************************************************************
        // ********************* BUTTON EVENT HANDLERS ***********************
        // *******************************************************************


        /*                                                  SKIP_BUTTON_CLICK
         *                                               BUTTON EVENT HANDLER
         * 
         * Note: While this method currently does nothing more than select a
         *       different card, the included "Skipped" attribute of the 
         *       FlashCard class may be utilized here to keep track of how 
         *       often any partiuclar question is skipped.
         ********************************************************************/
        private void Skip_Button_Click(object sender, EventArgs e)
        {
            //newArithmeticExpression();
            NextFlashCard();
        }


        /*                                                 RESET_BUTTON_CLICK
         *                                               BUTTON EVENT HANDLER
         * 
         * Note: Because more than one part of this program may trigger the
         *       reset functionality, it was moved into a separate method
         ********************************************************************/
        private void Reset_Button_Click(object sender, EventArgs e)
        {
            ResetSession();
        }


        /*                                                     FLIP_CARD_OVER
         *                                               BUTTON EVENT HANDLER
         * 
         * This will simply "flip" the flash card over from displaying the
         * question to the answer, and vise versa.
         ********************************************************************/
        private void FlipCardOver(object sender, EventArgs e)
        {
            displayQuestion = !displayQuestion;
            if (displayQuestion)
                Question_Answer_Box.Text = String.Format("\n\n\n{0}", questionPool[index].Question);
            //Question_Answer_Box.Text = String.Format("\n\n\n{0}\t{1}\t{2}\t=\t?", left, newOperator, right);
            else
                Question_Answer_Box.Text = String.Format("\n\n\n{0}", questionPool[index].Answer);
            //Question_Answer_Box.Text = String.Format("\n\n\n{0}\t{1}\t{2}\t=\t{3}", left, newOperator, right, answer);
        }


        /*                                                     RIGHT_OR_WRONG
         *                                               BUTTON EVENT HANDLER
         *                                               
         * Note: This method is meant to cover the functionality of the two
         *       (2) unique methods attached to the Correct/Fail buttons. It
         *       was observed that the only instructional difference between 
         *       the two was incrementing "totalRight" only when the Correct
         *       button was clicked. So I included some basic error-checking,
         *       typecasted the incoming "object" as a Button, and asked if
         *       it were equal to "Correct_Button".
         *       
         *       Anytime you find yourself repeating more than 2-3 lines of 
         *       code in more than one place, consider building a separate
         *       method to reduce source code length _and_ improve debugging 
         *       practices later.
         ********************************************************************/
        private void RightOrWrong(object sender, EventArgs e)
        {
            // Error Case: Incoming null object
            if (sender == null) return;
            Button alpha = sender as Button;
            // Error Case: Failed Typecast
            if (alpha == null) return;

            // Increment totalRight, only if the "Correct_Button" was clicked
            if (alpha == Correct_Button)
                totalRight++;

            total++;
            asked[index] = true;
            Progress_Bar.PerformStep();

            Percentage_Box.Text = String.Format("{0: 0.00%}", ((float)totalRight / total));
            int newRed = (int)((((float)total - totalRight) / total) * 215);
            int newGreen = (int)(((float)totalRight / total) * 200);
            Percentage_Box.BackColor = Color.FromArgb(255, newRed + 60, newGreen, 0);
            NextFlashCard();
            //newArithmeticExpression();
        }
    }
}
