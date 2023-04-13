using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";
            string hobbies = "";
            string employmentType = "";

            if(rbtnMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            // Reading the values of check boxes
            if (chkbxGaming.Checked == true)
                hobbies += chkbxGaming.Text + "\n";
            if(chkbxHiking.Checked == true) 
                hobbies += chkbxHiking.Text + "\n";
            if(chkbxReading.Checked == true) 
                hobbies+= chkbxReading.Text + "\n";
            if (chkbxSwimming.Checked == true) 
                hobbies += chkbxSwimming.Text;

            if (rbtnFulltime.Checked == true)
                employmentType = "Full-time";
            if (rbtnParttime.Checked == true)
                employmentType = "Part-time";

            MessageBox.Show("Gender: " + gender + "\n" 
                + "Hobbies: " + hobbies + "\n" + "Employment Type: " + employmentType);
        }

    }
}
