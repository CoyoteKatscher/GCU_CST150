// Brian Potter
// CST-150
// 04/24/2022
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

namespace Milestone_3
{
    public partial class MilestonePrj : Form
    {
        // Radio Inventory List        
        List<Radio> radioInventory = new List<Radio> ();
        public MilestonePrj()
        {
            InitializeComponent();
        }

        private void AddRadioInventory ()
        {
            // Pull user entered text and assign to a new Radio class member
            Radio radioItem = new Radio ();            

            radioItem.serialNumber = snTextBox.Text;
            radioItem.modelNumber = modelTextBox.Text;
            radioItem.description = descTextBox.Text;
            radioItem.mdcID = mdcTextBox.Text;

            if (int.TryParse(trunkedIDTextBox.Text, out int trkID))
                radioItem.trunkedID = trkID;
            else
                MessageBox.Show("Enter a valid ID");

            if (int.TryParse(convIDTextBox.Text, out int cnvID))
                radioItem.conventionalID = cnvID;
            else
                MessageBox.Show("Enter a valid ID");

            if (rwcCkBx.Checked)
                radioItem.systemRWC = true;
            
            if (trwcCkBx.Checked)
                radioItem.systemTRWC = true;

            if (mcwsCkBx.Checked)
                radioItem.systemMCWS = true;

            if (naricsCkBx.Checked)
                radioItem.systemNARICS = true;

            radioInventory.Add (radioItem);
        }

        private void ClearInventoryForm()
        {
            // Clear text out of all text boxes
            snTextBox.Text = "";
            trunkedIDTextBox.Text = "";
            convIDTextBox.Text = "";
            modelTextBox.Text = "";
            descTextBox.Text = "";
            mdcTextBox.Text = "";

            // Set all checkboxes to false to clear out any check marks
            rwcCkBx.Checked = false;
            trwcCkBx.Checked = false;
            mcwsCkBx.Checked = false;
            naricsCkBx.Checked = false;
        }

        public void SearchInventory (string sn, string mdc)
        {
            int foundLoc = -1;
            bool found = false;
            int index = 0;
            
            // Perform search and flag if search term found
            while (!found && index < radioInventory.Count())
            {
                if (radioInventory[index].serialNumber == sn || 
                    radioInventory[index].mdcID == mdc)
                {
                    found = true;
                    foundLoc = index;
                }
                index++;
            }

            if (found)
                DisplayInventoryItems(foundLoc);
            else
                MessageBox.Show("No Matching Radio Inventory Found");            
        }

        private void DisplayInventoryItems (int index)
        {
            // Send inventory data to Display Inventory Form
            DisplayInventory display = new DisplayInventory();

            display.recordTextBox.Text = index.ToString();
            display.snTextBox.Text = radioInventory[index].serialNumber.ToString();
            display.modelTextBox.Text = radioInventory[index].modelNumber.ToString();
            display.descTextBox.Text = radioInventory[index].description.ToString();
            display.mdcTextBox.Text = radioInventory[index].mdcID.ToString();
            display.trunkedTextBox.Text = radioInventory[index].trunkedID.ToString();
            display.convTextBox.Text = radioInventory[index].conventionalID.ToString();
            display.systemsLabel.Text = "";
            if (radioInventory[index].systemRWC == true)
                display.systemsLabel.Text += "RWC \n";
            if (radioInventory[index].systemTRWC == true)
                display.systemsLabel.Text += "TRWC \n";
            if (radioInventory[index].systemMCWS == true)
                display.systemsLabel.Text += "MCWS \n";
            if (radioInventory[index].systemNARICS == true)
                display.systemsLabel.Text += "NARICS \n";
            
            display.ShowDialog();
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            // Add a blank radio - aka "Replenish" inventory
            Radio newRadio = new Radio();

            radioInventory.Add (newRadio);            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Add new radio to inventory and clear screen for additional entries
            AddRadioInventory();  
            ClearInventoryForm();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Gather search terms from main screen and send to search method
            string serialNumSearch;
            string mdcIDSearch;
            
            serialNumSearch = snTextBox.Text;
            mdcIDSearch = mdcTextBox.Text;

            SearchInventory(serialNumSearch, mdcIDSearch);
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Loop through all inventory items and display on the Display Inventory form
            ClearInventoryForm();
            
            DisplayInventory display = new DisplayInventory();

            for (int i=0; i<radioInventory.Count; i++)
            {
                DisplayInventoryItems(i);                
            }

            MessageBox.Show("End of inventory");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the inventory entry form
            ClearInventoryForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
