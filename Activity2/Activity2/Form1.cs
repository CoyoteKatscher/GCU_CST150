// Brian Potter
// CST-150
// 03/13/2022
// I used calculations from the following websites to complete this assignment:
// MARS_WEIGHT_CONVERSION - https://www.livescience.com/33356-weight-on-planets-mars-moon.html


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            const double MARS_WEIGHT_CONVERSION = 0.38;
            double enteredWeight; 
            double marsWeight;

            // Obtain weight from user
            // Need to convert string value received from text box entry to double to perform calculations
            enteredWeight = double.Parse(weightEntryTextBox.Text);

            // Perform calculations
            marsWeight = enteredWeight * MARS_WEIGHT_CONVERSION;

            // Need to convert double value result back to a string value for displaying result in results text box
            marsWeightTextBox.Text = marsWeight.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit program
            this.Close();
        }
    }
}
