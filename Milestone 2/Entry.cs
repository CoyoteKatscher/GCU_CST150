using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone1
{
    struct Radio
    {
        public string modelNumber;
        public string serialNumber;
        public string description;
        public int trunkedID;
        public int conventionalID;
        public string mdcID;
        public bool systemRWC;
        public bool systemTRWC;
        public bool systemMCWS;
        public bool systemNARICS;
    }
    public partial class EntryMenu : Form
    {
        public EntryMenu()
        {
            InitializeComponent();
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            Radio radioEntry;
            int radioTrunkID;
            int radioConventionalID;

            radioEntry = new Radio();

            // Add string values to string members of Radio class
            radioEntry.modelNumber = modelNumTextBox.Text;
            radioEntry.serialNumber = serialNumberTextBox.Text;
            radioEntry.description = radioDescriptionTextBox.Text;
            radioEntry.mdcID = mdcCodeTextBox.Text;

            // Validate user input for int members of Radio class
            // if valid add values to members of Radio class else display error message
            if (int.TryParse(trunkedRadioIDTextBox.Text, out radioTrunkID))
                radioEntry.trunkedID = radioTrunkID;
            else
                MessageBox.Show("Enter valid Trunked Radio ID");

            if (int.TryParse(conventionalRadioIDTextBox.Text, out radioConventionalID))
                radioEntry.conventionalID = radioConventionalID;
            else
                MessageBox.Show("Enter valid Conventional Radio ID");

            // Check each check box to see if it is checked.
            // If checked, make member of Radio class set to true
            // Else check box is not checked, make member of Radio class set to false
            if (rwcCheckBox.Checked)
                radioEntry.systemRWC = true;
            else
                radioEntry.systemRWC = false;

            if (trwcCheckBox.Checked)
                radioEntry.systemTRWC = true;
            else
                radioEntry.systemTRWC = false;

            if (mcwsCheckBox.Checked)
                radioEntry.systemMCWS = true;
            else
                radioEntry.systemMCWS = false;

            if (naricsCheckBox.Checked)
                radioEntry.systemNARICS = true;
            else
                radioEntry.systemNARICS = false;

            // Test to verify members of Radio are populated
            MessageBox.Show("Serial Number:   " + radioEntry.serialNumber + "\n" +
                            "Model Number:    " + radioEntry.modelNumber + "\n" +
                            "Description:     " + radioEntry.description + "\n" +
                            "Trunked ID:      " + radioEntry.trunkedID + "\n" +
                            "Conventional ID: " + radioEntry.conventionalID + "\n" +
                            "MDC ID:          " + radioEntry.mdcID + "\n" +
                            "RWC System:      " + radioEntry.systemRWC + "\n" +
                            "TRWC System:     " + radioEntry.systemTRWC + "\n" +
                            "MCWS System:     " + radioEntry.systemMCWS + "\n" +
                            "NARICS System:   " + radioEntry.systemNARICS + "\n");

        }
    }
}
