using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Julian Baker
 * Date:February 7, 2026
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE

            // INPUT
            int num = Int32.Parse(XInputTextBox.Text);

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            int squaredValue = Square(num);
            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            int cubedValue = Cube(num);
            // OUTPUT
            // set the output to visible
            XOutputLabel.Text = "Squared: " + squaredValue.ToString() + " Cubed: " + cubedValue.ToString();
            XOutputLabel.Visible = true;
            // turn the Go button off
            XGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            return num * num;
        }

        public int Cube(int num)
        {
            return num * num * num;
        }

        private void XResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
            XInputTextBox.Text = string.Empty;
            XOutputLabel.Text = string.Empty;
            XGoButton.Enabled = true;
        }

    }
}
