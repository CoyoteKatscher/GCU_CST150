// Brian Potter
// CST-150
// 03/27/2022
// I used the following sources to assist with understanding how to do this assignment:
// Knowledge of the Leibniz Formula used for calculating PI:
// Wikimedia Foundation. (2022, March 19). Leibniz formula for π. Wikipedia. Retrieved March 27, 2022, from https://en.wikipedia.org/wiki/Leibniz_formula_for_%CF%80 
// Logic for calculating PI using Leibniz Formula:
// YouTube. (2014). YouTube. Retrieved March 27, 2022, from https://www.youtube.com/watch?v=uwI6PHVmfwQ. 
// Knowledge of changing the text label in the GUI form:
// C# winforms change label based on running process. Stack Overflow. Retrieved March 27, 2022, from https://stackoverflow.com/questions/51062514/c-sharp-winforms-change-label-based-on-running-process 
// The rest of the code is my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Activity7 : Form
    {
        public Activity7()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            const double NUMERATOR = 4;
            double denominator = 3;
            int numTerms;
            double valueOfPI = 4;
            
            // Error checking - step 1: Verify user input is of type int
            if (int.TryParse(numTermsTextBox.Text, out numTerms))
            {
                // Error checking - step 2: Verify user input is a positive number
                if (numTerms >= 0)
                {
                    // Per Activity specifications, use for loop to do calculations
                    // counter (count) starts at 2 to make sure first itieration is even
                    for (int count = 2; count <= numTerms; count++)
                    {
                        // If counter is even the fraction value is subtracted from calculated PI value
                        if (count % 2 == 0)
                        {
                            valueOfPI -= NUMERATOR / denominator;
                            denominator = denominator + 2;
                        }
                        // If counter is odd the fraction value is added to calculated PI value
                        else
                        {
                            valueOfPI += NUMERATOR / denominator;
                            denominator = denominator + 2;
                        }
                    }
                    // Once all itierations complete, update text in GUI to reflect the number of terms used and the calculated value of PI
                    resultsLabel.Text = "Approximate value of pi after " + numTerms.ToString() + " terms = " + valueOfPI.ToString();
                }
                else
                // Error checking - step 2: Let user know only non-negative values accepted
                // Clear user input value and reset text label to default
                {
                    MessageBox.Show("Enter a non-negative value");
                    numTermsTextBox.Text = "";
                    resultsLabel.Text = "Approximate value of pi after <terms> terms = <PI>";
                }    
            }
            else
            // Error checking - step 1: Let user know only integer values accepted
            // Clear user input value and reset text label to default
            {
                MessageBox.Show("Please enter a valid non-decimal numerical value for terms");
                numTermsTextBox.Text = "";
                resultsLabel.Text = "Approximate value of pi after <terms> terms = <PI>";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Replace user input in text box with empty string making it appear value is cleared
            numTermsTextBox.Text = "";
            // Reset text lable to default to further make it appear the clear button "resets" the program
            resultsLabel.Text = "Approximate value of pi after <terms> terms = <PI>";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
