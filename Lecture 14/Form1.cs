using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lbxCities.Items.Add(txtNewItem.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxCities.Items.Add("Irbid");
            lbxCities.Items.Add("Aqaba");

            lbxCities.Items.Remove("Irbid");
            lbxCities.Items.RemoveAt(0);
        }

        private void btnAddCBXItem_Click(object sender, EventArgs e)
        {
            cbxCountries.Items.Add(txtNewCBXItems.Text);
        }

        private void lbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxCities.SelectedItem != null)
            
                txtSelectedListBoxItem.Text = lbxCities.SelectedItem.ToString();
           
                
        }

        private void cbxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedComboBoxItem.Text = cbxCountries.SelectedItem.ToString();
        }

        private void btnDeleteListBoxItem_Click(object sender, EventArgs e)
        {
            try
            {
                lbxCities.Items.Remove(lbxCities.SelectedItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
