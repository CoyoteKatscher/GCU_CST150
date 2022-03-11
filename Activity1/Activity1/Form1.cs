using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Obligatory "Hello World" first program
        private void buttonHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            messageTextBox.Text = "Hello World!";
        }

        private void helloClassButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Class!");
            messageTextBox.Text = "Hello Class!";
        }
    }
}
