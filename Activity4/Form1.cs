// Brian Potter
// CST-150
// 03/17/2022
// This is my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Activity4 : Form
    {
        public Activity4()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int seconds;
            int convertedValue;
            // Using tryParse() to validate user input and catch any invalid entry
            if (int.TryParse(userInputTextBox.Text, out seconds))
            {
                // Using if/else structure to step through the possibilities of minutes/hours/days
                // 60 seconds in a minute (min value) and 3600 seconds in 60 minutes (max value)
                if ((seconds >= 60) && (seconds < 3600))
                {
                    convertedValue = seconds / 60;
                    MessageBox.Show("You entered " + convertedValue.ToString() + " minutes");
                }
                // 3600 seconds in 1 hour (min value) and 86400 secounds in 24 hours (max value)
                else if ((seconds >= 3600) && (seconds < 86400))
                {
                    convertedValue = seconds / 3600;
                    MessageBox.Show("You entered " + convertedValue.ToString() + " hours");
                }
                // Anything greater than 86400 seconds is calculated to be days
                else if (seconds >= 86400)
                {
                    convertedValue = seconds / 86400;
                    MessageBox.Show("You entered " + convertedValue.ToString() + " days");
                }
                // Error checking for negative values since time cannot be negative
                else if (seconds < 0)
                     MessageBox.Show("Invalid Entry! Enter positive numbers only");
                // If none of the above if/else scenarios are valid then the user must have entered a value between 0 and 60 seconds
                else
                MessageBox.Show("You entered " + seconds.ToString() + " seconds");
            }
            // Error checking for invalid input. This is the message that gets displayed if the TryParse() function fails
            else
                MessageBox.Show("Invalid Entry! Please enter a positive non-decimal number");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears out the text in the text box for user input
            userInputTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the application
            this.Close();
        }
    }
}
