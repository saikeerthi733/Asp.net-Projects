using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Quite arbitrarily, we'll make "true" equate to X, and false equate to "O"
        private static Nullable<bool>[,] theGrid;
        private static int outerBuffer;
        private static int innerBuffer;
        private static int initialWidth = 808;
        private static int initialHeight = 481;
        private static bool MyTurn;

        public Form1()
        {
            InitializeComponent();
            outerBuffer = 0; // was previously 40
            innerBuffer = 10;
            MyTurn = true;
            theGrid = new Nullable<bool>[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    theGrid[i, j] = null;

            // To test the updated drawing method
            //theGrid[0, 1] = true;  // X
            //theGrid[2, 1] = false; // O
        }

        private void ClearPlayingField()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    theGrid[i, j] = null;
            PlayingField.Refresh();

            if (pickingX.Checked == true)
                MyTurn = true;
            else
                MyTurn = false;

            StatsBox.Text = "";
        }

        private void WinCondition()
        {
            int temp = 0;
            bool flag = false;
            // checking for rows
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (theGrid[i, j] == null)
                    {
                        flag = true;
                        break;
                    }

                    if (theGrid[i, j] == true)
                        temp++;
                }
                if (flag)
                {
                    flag = false;
                    temp = 0;
                    continue;
                }

                if (temp == 0)
                {
                    StatsBox.Text = "O won!";
                    return;
                }
                else if (temp == 3)
                {
                    StatsBox.Text = "X won!";
                }
            }

            // checking for columns
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (theGrid[j, i] == null)
                    {
                        flag = true;
                        break;
                    }

                    if (theGrid[j, i] == true)
                        temp++;
                }
                if (flag)
                {
                    flag = false;
                    temp = 0;
                    continue;
                }

                if (temp == 0)
                {
                    StatsBox.Text = "O won!";
                    return;
                }
                else if (temp == 3)
                {
                    StatsBox.Text = "X won!";
                }
            }

            // checking the diagonals
            for (int i = 0; i < 3; i++)
            {
                if (theGrid[i, i] == null)
                {
                    flag = true;
                    break;
                }

                if (theGrid[i, i] == true)
                    temp++;
            }
            if (!flag)
            {
                if (temp == 0)
                {
                    StatsBox.Text = "O won!";
                    return;
                }
                else if (temp == 3)
                {
                    StatsBox.Text = "X won!";
                }
            }
            flag = false;

            for (int i = 0, j = 2; i < 3; i++, j--)
            {
                if (theGrid[i, j] == null)
                {
                    flag = true;
                    break;
                }

                if (theGrid[i, j] == true)
                    temp++;
            }
            if (flag)
            {
                return;
            }
            if (temp == 0)
            {
                StatsBox.Text = "O won!";
                return;
            }
            else if (temp == 3)
            {
                StatsBox.Text = "X won!";
            }
        }

        private void PlayingField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.White);
            myPen.Brush = new SolidBrush(Color.White);

            // This draws my hastag--- NO, it draws the pound symbol
            g.DrawLine(myPen, (PlayingField.Width / 3), outerBuffer, (PlayingField.Width / 3), PlayingField.Height - outerBuffer);
            g.DrawLine(myPen, (2 * PlayingField.Width / 3), outerBuffer, (2 * PlayingField.Width / 3), PlayingField.Height - outerBuffer);
            g.DrawLine(myPen, outerBuffer, (PlayingField.Height / 3), (PlayingField.Width - outerBuffer), (PlayingField.Height / 3));
            g.DrawLine(myPen, outerBuffer, (2 * PlayingField.Height / 3), (PlayingField.Width - outerBuffer), (2 * PlayingField.Height / 3));

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (theGrid[i, j] != null) // Time to draw!
                    {
                        if (theGrid[i, j] == true) // Draw the X!
                        {
                            g.DrawLine(myPen, (outerBuffer + innerBuffer) + (j * PlayingField.Width / 3),
                                          (outerBuffer + innerBuffer) + (i * PlayingField.Height / 3),
                                          ((j + 1) * PlayingField.Width / 3) - innerBuffer,
                                          ((i + 1) * PlayingField.Height / 3) - innerBuffer);
                            g.DrawLine(myPen, (outerBuffer + innerBuffer) + (j * PlayingField.Width / 3),
                                          ((i + 1) * PlayingField.Height / 3) - innerBuffer,
                                          ((j + 1) * PlayingField.Width / 3) - innerBuffer,
                                          (outerBuffer + innerBuffer) + (i * PlayingField.Height / 3));
                        }
                        else // Draw the O!
                        {
                            g.DrawEllipse(myPen, (j * PlayingField.Width / 3) + innerBuffer,
                                                 (i * PlayingField.Height / 3) + innerBuffer,
                                                 (PlayingField.Width / 3) - (innerBuffer * 2),
                                                 (PlayingField.Height / 3) - (innerBuffer * 2));
                        }
                    }
                }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PlayingField.Width = 420 + Math.Min(this.Width - initialWidth, this.Height - initialHeight);
            PlayingField.Height = 420 + Math.Min(this.Width - initialWidth, this.Height - initialHeight);
            PlayingField.Refresh();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.CompareTo("") == 0)
            {
                textBox1.ForeColor = Color.Green;
                textBox1.Text = "(XXX) XXX-XXXX";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.CompareTo("(XXX) XXX-XXXX") == 0)
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "";
            }
        }

        private void PlayingField_MouseDown(object sender, MouseEventArgs e)
        {

            /*
             * Looking back over this part of the code, I couldn't help but feel like...
             * this isn't elegant. This is crude. As an advanced-level programmer, we don't ever
             * want to settle for crude. We want elegance. We want our code to be sublime.
            // First Row
            if (e.X < (PlayingField.Width / 3) && e.Y < (PlayingField.Height / 3))
            {
                if (theGrid[0, 0] == null)
                    theGrid[0, 0] = MyTurn;
                else return;
            }
            if (e.X > (PlayingField.Width / 3) && e.X < (2 * PlayingField.Width / 3) &&
                e.Y < (PlayingField.Height / 3))
            {
                if (theGrid[0, 1] == null)
                    theGrid[0, 1] = MyTurn;
                else return;
            }
            if (e.X > (2 * PlayingField.Width / 3) && e.Y < (PlayingField.Height / 3))
            {
                if (theGrid[0, 2] == null)
                    theGrid[0, 2] = MyTurn;
                else return;
            }

            // Second Row
            if (e.X < (PlayingField.Width / 3) && e.Y > (PlayingField.Height / 3) &&
                e.Y < (2 * PlayingField.Height / 3))
            {
                if (theGrid[1, 0] == null)
                    theGrid[1, 0] = MyTurn;
                else return;
            }
            if (e.X > (PlayingField.Width / 3) && e.X < (2 * PlayingField.Width / 3) &&
                e.Y > (PlayingField.Height / 3) && e.Y < (2 * PlayingField.Height / 3))
            {
                if (theGrid[1, 1] == null)
                    theGrid[1, 1] = MyTurn;
                else return;
            }
            if (e.X > (2 * PlayingField.Width / 3) && e.Y > (PlayingField.Height / 3) &&
                e.Y < (2 * PlayingField.Height / 3))
            {
                if (theGrid[1, 2] == null)
                    theGrid[1, 2] = MyTurn;
                else return;
            }

            // Third Row
            if (e.X < (PlayingField.Width / 3) && e.Y > (2 * PlayingField.Height / 3))
            {
                if (theGrid[2, 0] == null)
                    theGrid[2, 0] = MyTurn;
                else return;
            }
            if (e.X > (PlayingField.Width / 3) && e.X < (2 * PlayingField.Width / 3) &&
                e.Y > (2 * PlayingField.Height / 3))
            {
                if (theGrid[2, 1] == null)
                    theGrid[2, 1] = MyTurn;
                else return;
            }
            if (e.X > (2 * PlayingField.Width / 3) && e.Y > (2 * PlayingField.Height / 3))
            {
                if (theGrid[2, 2] == null)
                    theGrid[2, 2] = MyTurn;
                else return;
            }
            */

            // OH
            // IT GOT FANCY
            // FANCY AF
            if (theGrid[(e.Y / (PlayingField.Height / 3)), (e.X / (PlayingField.Width / 3))] == null)
                theGrid[(e.Y / (PlayingField.Height / 3)), (e.X / (PlayingField.Width / 3))] = MyTurn;
            else
                return;

            PlayingField.Refresh();
            MyTurn = !MyTurn; // Let the other person play!
            pickingO.Enabled = false;
            pickingX.Enabled = false;
            WinCondition();
        }

        private void picking_Click(object sender, EventArgs e)
        {
            if (sender == null) // Error Case: null object
                return;

            RadioButton alpha = sender as RadioButton;
            if (alpha == null) // Error Case: typecast failed
                return;

            // Otherwise, let's get to business
            if (alpha.Text.CompareTo("X") == 0)
                MyTurn = true;
            else
                MyTurn = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearPlayingField();
            pickingO.Enabled = true;
            pickingX.Enabled = true;
        }
    }

    // STEAL THIS CODE!!
    // My Draw Graphics Extensions
    public static class GraphicsExtensions
    {
        public static void DrawCircle(this Graphics g, Pen pen,
                                      float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        public static void FillCircle(this Graphics g, Brush brush,
                                      float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
        public static void DrawCircle(this Graphics g, Pen pen,
                                      Point center, float radius)
        {
            g.DrawEllipse(pen, center.X - radius, center.Y - radius,
                          radius + radius, radius + radius);
        }

        public static void FillCircle(this Graphics g, Brush brush,
                                      Point center, float radius)
        {
            g.FillEllipse(brush, center.X - radius, center.Y - radius,
                          radius + radius, radius + radius);
        }
    }
}
