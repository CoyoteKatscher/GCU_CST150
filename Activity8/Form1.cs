// Brian Potter
// CST-150
// 03/31/2022
// Only sources used for this program is the text book for designing methods and
// the given calculations in the Activity 8 assesment description.
// Rest of the code is my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8
{
    public partial class Activity8 : Form
    {
        public Activity8()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double fatGrams = 0;
            double fatCalories = 0;

            double carbGrams = 0;
            double carbCalories = 0;

            // Process user input for Fat Consumed in a Day
            // Nested if used for error checking
            // If no errors then user input is sent to FatCalories method which returns the calculated value
            if (double.TryParse(fatConsumedTextBox.Text, out fatGrams))
            {
                if (fatGrams >= 0)
                    fatCalories = FatCalories(fatGrams);
                else
                    MessageBox.Show("Enter non-negative value for grams of fat consumed");
            }
            else
                MessageBox.Show("Enter valid value for grams of fat consumed");

            // Process user input for Carbohydrates Consumed in a Day
            // Nested if used for error checking
            // If no errors then user input is sent to CarbCalories method which returns the calculated value
            if (double.TryParse(carbConsumedTextBox.Text, out carbGrams))
            {
                if (carbGrams >= 0)
                    carbCalories = CarbCalories(carbGrams);
                else
                    MessageBox.Show("Enter non-negative value for grams of carbohydrates consumed");
            }
            else
                MessageBox.Show("Enter valid value for grams of carbohydrates consumed");

            // Created additional method for displaying results for additional practice.
            DisplayResults(fatCalories, carbCalories);            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Replaced user input boxes with empty string to make it appear data had been cleared out
            fatConsumedTextBox.Text = "";
            carbConsumedTextBox.Text = "";

            // Reset results labels with initial values
            fatCaloriesLabel.Text = "Calories from Fat";
            carbCaloriesLabel.Text = "Calories from Carbohydrates";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double FatCalories (double fatG)
        {
            // Activity 8 assessment description provided formula of Calories from Fat = Fat Grams x 9
            return fatG * 9;            
        }

        private double CarbCalories (double carbG)
        {
            // Activity 8 assessment description provided formula of Calories from carbs = Carbs Grams x 4
            return carbG * 4;            
        }

        private void DisplayResults (double fatCalTotal, double carbCalTotal)
        {
            // Created DisplayResults for additional method practice since two required methods had return 
            // values and DisplayResults is a perfect 'void' method

            // Change label text to display results
            fatCaloriesLabel.Text = "Total calories from fat is " + fatCalTotal;
            carbCaloriesLabel.Text = "Total calories from carbohydrates is " + carbCalTotal;        
        }
    }
}
