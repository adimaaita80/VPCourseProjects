using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(int.Parse(txtEmployeeId.Text), txtEmployeeName.Text, dtpDateOfBirth.Value);

            //newEmployee.Id = int.Parse(txtEmployeeId.Text);
            //newEmployee.Name = txtEmployeeName.Text;
            //newEmployee.DateOfBirth = dtpDateOfBirth.Value;

            MessageBox.Show(newEmployee.EmployeeInfo());
        }

        private void btnCreateTextBox_Click(object sender, EventArgs e)
        {
            TextBox newTextBox = new TextBox();

            newTextBox.Name = "newTextBox";
            newTextBox.Text = "Dynamic Text Box";
            newTextBox.Location = new Point(0, 0);
            newTextBox.Size = new Size(100, 40);
            panel1.Controls.Add(newTextBox);
        }
    }
}
