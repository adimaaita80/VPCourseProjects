using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_8
{
    public partial class frmTaxCalculator : Form
    {
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        // This is the event handler of the button click event
        private void btnCalculateTax_Click(object sender, EventArgs e)
        {

            try
            {
                int amount = int.Parse(txtAmount.Text);
                double taxRate = double.Parse(txtTaxRate.Text);

                double finalTax = amount * taxRate;

                txtFinalTax.Text = finalTax.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
