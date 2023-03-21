using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPrintHello_Click(object sender, EventArgs e)
        {
            // This is an event handler for the click event

            string myName = txtName.Text;

            MessageBox.Show("Welcome " + myName);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // This is an event hanlder which is fired whenever a letter is typed inside txtName textbox

            lblLetterCount.Text = txtName.Text.Length.ToString();
        }
    }
}
