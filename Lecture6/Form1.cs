using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStudentId.Text = "AB0001";

            cbxCountries.Items.Add("Jordan");
            cbxCountries.Items.Add("Syria");
            cbxCountries.Items.Add("Egypt");

            dtpDateOfBirth.Value = DateTime.Now.AddYears(-18);
        }
    }
}
