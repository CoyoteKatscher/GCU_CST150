// Brian Potter
// CST-150
// 03/26/2022
// I used calculations for EARTH_TO_MARS_CONVERSION based on the Activity 2 Example
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

namespace Activiy_6
{
    public partial class Activity6 : Form
    {
        public Activity6()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Earth weight to Mars weight conversion constant
            const double EARTH_TO_MARS_CONVERSION = 0.377;
            double enteredWeight;
            double marsWeight;

            // Using TryParse for error handling
            if (double.TryParse(earthWeightEntryTextBox.Text, out enteredWeight))
            {
                // Weight conversion calculation and result displayed in text box
                // Formatted output in text box to 3 decimal places (n3)
                marsWeight = enteredWeight * EARTH_TO_MARS_CONVERSION;
                marsWeightTextBox.Text = marsWeight.ToString("n3");
            }
            else
            {
                // Error handling - Display message telling user to enter a valid weight
                // Clear entries from text boxes so fields are reset
                MessageBox.Show("Enter a valid weight");
                earthWeightEntryTextBox.Text = "";
                marsWeightTextBox.Text = "";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear out text in all text boxes using an empty string value
            earthWeightEntryTextBox.Text = "";
            marsWeightTextBox.Text = "";
        }
    }
}
