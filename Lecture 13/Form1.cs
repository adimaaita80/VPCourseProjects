using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Do not show any characters on the textbox
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Do not show any characters on the textbox
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check the user's input

            string name;
            int age;

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Please enter valid data in all fields");
            }
            else
            {
                name = txtName.Text;
                age = int.Parse(txtAge.Text);
                MessageBox.Show("Name: " + name + "\n" + "Age: " + age.ToString());
            }
            
        }
    }
}
