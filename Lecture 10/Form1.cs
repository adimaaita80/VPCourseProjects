using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateControls_Click(object sender, EventArgs e)
        {
            int numberOfControls = int.Parse(txtNumberOfControls.Text);

            // Let's create a loop to create the correct number of buttons
            for(int i=0; i<numberOfControls; i++)
            {
                // Let's write code to create a single button dynamically
                Button newButton = new Button();
                newButton.Name = "DButton" + (i+1);
                newButton.Text = "DButton" + (i+1);
                newButton.Size = new Size(120, 40);
                newButton.Location = new Point(0, (i*50));

                pnlDynamicControls.Controls.Add(newButton);
            }

            
        }
    }
}
