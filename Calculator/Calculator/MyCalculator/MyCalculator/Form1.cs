/* Programmer: A Bunch of People
 * Start Date: 9/18/18
 * Version 1.0: 9/21/18
 * 
 * Purpose: The intention with this .NET Form is to practice some basics of 
 *          GUI design, get familiar with the Form [Design] view in Visual
 *          Studios, for the purpose of building a "dark themed" calculator.
 * **************************************************************************/

 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        private Nullable<long> leftOp, rightOp;
        private string lastOperator;

        public Form1()
        {
            InitializeComponent();
            Text = ".NET's Dark Themed Calculator";
            PosNeg_Button.Text = "\u00B1";
            Division_Button.Text = "\u00F7";
            leftOp = rightOp = null;
            lastOperator = "";
        }


        /*                                                        PARSE_INPUT
         * Returns: A "string" representing the current numeric input value,
         *          with the comma characters stripped out.
         *          
         * NOTE: This method is necessary for string -> long typecasts,
         *       because of the design requirement that output numbers
         *       include commas.
         * ******************************************************************/
        private string Parse_Input()
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < MyOutputField.Text.Length; i++)
            {
                if (MyOutputField.Text[i] != ',')
                    temp.Append(MyOutputField.Text[i]);
            }
            return temp.ToString();
        }


        /*                                                  PUSHING_A_NUM_KEY
         * This is my event handler for when numeric buttons are pushed. An 
         * important feature here is how there isn't an individual method for
         * each button. Instead, I'm treating them as a group or class of 
         * buttons, distinguished only by the value they represent.
         * ******************************************************************/
        private void PushingANumKey(object sender, EventArgs e)
        {
            // Error Checking: incoming null object
            if (sender == null) return; // Not sure how this would happen...
            // else
            Button alpha = sender as Button;

            // Error Check: failed typecast
            if (alpha == null) return;

            // Here, we're gonna need some commas
            if (MyOutputField.Text.Length >= 3)
            {
                string temp = Parse_Input();
                if (temp.Length < 19)
                {
                    temp += alpha.Text;
                }
                else
                {
                    return;
                }

                MyOutputField.Text = String.Format("{0: 0,0}", Convert.ToInt64(temp.ToString()));
            }
            else
            {
                MyOutputField.AppendText(alpha.Text);
            }
        }


        /*                                                    BINARY_OPERATOR
         * This is my event handler for when binary arithmetic operators are
         * pushed. You may notice this is a different implementation from 
         * where we left off in class, as I quickly realized after clas that 
         * the "cut 'n paste" band-aid solution we designed there could be
         * generalized.
         * ******************************************************************/
        private void Binary_Operation(object sender, EventArgs e)
        {
            if (sender == null) return;

            if (MyOutputField.Text.Length == 0) return;

            Button alpha = sender as Button;

            if (alpha == null) return; // Typecast failed

            string temp = Parse_Input();
            // We have our number inside of a string
            if (leftOp == null)
                leftOp = Convert.ToInt64(temp);
            else
            {
                rightOp = Convert.ToInt64(temp);
                if (lastOperator.CompareTo("+") == 0)
                {
                    leftOp += rightOp;
                }
                if (lastOperator.CompareTo("-") == 0)
                {
                    leftOp -= rightOp;
                }
                if (lastOperator.CompareTo("X") == 0)
                {
                    leftOp *= rightOp;
                }
                if (lastOperator.CompareTo("\u00F7") == 0)
                {
                    leftOp /=  rightOp;
                }
            }
            StringBuilder buffer = new StringBuilder(CurrentExpression.Text);
            buffer.Insert(0, String.Format("{0} {1} ", alpha.Text, MyOutputField.Text));
            CurrentExpression.Text = buffer.ToString(); ;

            lastOperator = alpha.Text;
            MyOutputField.Text = "";
        }


        /*                                                  CALCULATE_OPERATION
         * This is my event handler for when the calculate button (=) is
         * pushed. This needs to consider the situation where the last
         * operand has been typed in but not included in the current
         * expression. This is accomplished by the "Binary_Operation" event
         * handler setting the "lastOperator" variable.
         * ******************************************************************/
        private void Calculate_Operation(object sender, EventArgs e)
        {
            if (MyOutputField.Text.Length > 0)
            {
                string temp = Parse_Input();
                switch (lastOperator)
                {
                    case ("+"):
                        leftOp += Convert.ToInt64(temp);
                        break;
                    case ("-"):
                        leftOp -= Convert.ToInt64(temp);
                        break;
                    case ("X"):
                        leftOp *= Convert.ToInt64(temp);
                        break;
                    case ("/"):
                        leftOp /= Convert.ToInt64(temp);
                        break;
                    case (""): // This probbaly shouldn't happen
                        MessageBox.Show(String.Format("Cannot resolve '{0}'", lastOperator), "Failed Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            MyOutputField.Text = leftOp.ToString();
            CurrentExpression.Text = "";
            leftOp = rightOp = null;
            lastOperator = "";
        }


        /*                                              CLEAR_ENTITY_OPERATION
         * This is my event handler for when the "soft reset" or clear entity
         * button is pushed. The intention is to wipe out the current input 
         * field, but not the current expression being evaluated.
         * ******************************************************************/

        private void ClearEntity_Operation(object sender, EventArgs e)
        {
            MyOutputField.Text = "";
        }


        /*                                                     CLEAR_OPERATION
         * This is my event handler for when the "hard reset" or clear button
         * is pushed. The intention is to wipe everything out and start from
         * "State Zero".
         * ******************************************************************/

        private void Clear_Operation(object sender, EventArgs e)
        {
            MyOutputField.Text = "";
            CurrentExpression.Text = "";
            leftOp = rightOp = null;
            lastOperator = "";
        }
    }
}
