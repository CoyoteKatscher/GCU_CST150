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
    public partial class DisplayInventory : Form
    {
        public DisplayInventory()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
