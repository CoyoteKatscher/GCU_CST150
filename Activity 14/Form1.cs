// Brian Potter
// CST-150
// 04/16/2022
// Sources assisting with logic in clearEntries() && adding check box items to sandwichMadeLabel
// Is it possible to append text to a string or label text programmatically? (n.d.). Retrieved April 16, 2022, from https://social.msdn.microsoft.com/Forums/en-US/5cba9f62-2bb5-498c-be21-56d9a6e54800/is-it-possible-to-append-text-to-a-string-or-label-text-programmatically?forum=aspwebforms 
// How to clear radio buttons and checkboxes by using a menu item ? (n.d.). Retrieved April 16, 2022, from https://social.msdn.microsoft.com/Forums/sqlserver/en-US/d0976688-e366-4861-ade2-799717600303/how-to-clear-radio-buttons-and-checkboxes-by-using-a-menu-item-?forum=vbgeneral 
// The code is of my own work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Activity14 : Form
    {
        public Activity14()
        {
            InitializeComponent();            
        }

        private void clearEntries()
        {
            // Clears all of the different selections

            // Clears List Box Selection
            meatListBox.SelectedIndex = -1;

            // Resets all radio button options to not be checked
            whiteSubRollRadioBtn.Checked = false;
            wheatSubRollRadioBtn.Checked = false;
            sourdoughRadioBtn.Checked = false;

            // Resets all check box options to not be checked
            cheeseChkBx.Checked = false;
            lettuceChkBx.Checked = false;
            tomatoChkBx.Checked = false;
            picklesChxBx.Checked = false;
            mayoChkBx.Checked = false;
            mustardChkBx.Checked = false;

            // Clears the text from the label that lists the selected sandwich
            sandwichMadeLabel.Text = " ";
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            string selectedMeat ="";
            string selectedBread = "";
            bool validEntry = true;

            // Error Check: Verify user has selected at least one item from the List Box
            if (meatListBox.SelectedIndex != -1)
                selectedMeat = meatListBox.SelectedItem.ToString();
            else
            {
                MessageBox.Show("Please Select a Meat");
                clearEntries();
                validEntry = false;
            }

            // Error Check: If user selected at least one item from the List Box then
            // the program verifies user has selected one of the Radio Button items.
            // If a Radio Button has been selected the value of the selected item is stored
            // in selectedBread. 
            // If none of the Radio Buttons have been selected then an error message is displayed
            if (validEntry)
            { 
                if (whiteSubRollRadioBtn.Checked)
                    selectedBread = "White Sub Roll";
                if (wheatSubRollRadioBtn.Checked)
                    selectedBread = "Wheat Sub Roll";
                if (sourdoughRadioBtn.Checked)
                    selectedBread = "Sourdough Bread";
                if (!whiteSubRollRadioBtn.Checked &&
                    !wheatSubRollRadioBtn.Checked &&
                    !sourdoughRadioBtn.Checked)
                {
                    MessageBox.Show("Please Select a Bread");
                    clearEntries();
                    validEntry = false;
                }
            }

            // Error Check: If user selected one item from the List Box and one of
            // the Radio Buttons then the user can select optional items.
            // The sandwhichMadeLabel text area is populated with the sandwhich
            // made by the user
            if (validEntry)
            {
                sandwichMadeLabel.Text = selectedMeat + " on " +
                                         selectedBread + " with \n";
                if (cheeseChkBx.Checked)
                    sandwichMadeLabel.Text += "Cheese\n";
                if (lettuceChkBx.Checked)
                    sandwichMadeLabel.Text += "Lettuce\n";
                if (tomatoChkBx.Checked)
                    sandwichMadeLabel.Text += "Tomato\n";
                if (picklesChxBx.Checked)
                    sandwichMadeLabel.Text += "Pickles\n";
                if (mayoChkBx.Checked)
                    sandwichMadeLabel.Text += "Mayo\n";
                if (mustardChkBx.Checked)
                    sandwichMadeLabel.Text += "Mustard\n";
                if (!cheeseChkBx.Checked && !lettuceChkBx.Checked &&
                    !tomatoChkBx.Checked && !picklesChxBx.Checked &&
                    !mayoChkBx.Checked && !mustardChkBx.Checked)
                    sandwichMadeLabel.Text += "No Toppings\n";
            }
            else
                clearEntries();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // All options are reset
            clearEntries();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
