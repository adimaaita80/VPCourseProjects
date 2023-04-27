using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_19
{
    public partial class frmEmployeesPanel : Form
    {
        public frmEmployeesPanel()
        {
            InitializeComponent();
        }

        private void frmEmployeesPanel_Load(object sender, EventArgs e)
        {
            Employee newEmployee1 = new Employee();
            newEmployee1.Id = "1";
            newEmployee1.Name = "Ahmad";
            newEmployee1.Telephone = "1234567890";
            newEmployee1.Job = "Manager";

            Employee newEmployee2 = new Employee();
            newEmployee2.Id = "2";
            newEmployee2.Name = "Khaled";
            newEmployee2.Telephone = "1223457890";
            newEmployee2.Job = "Worker";

            Employee newEmployee3 = new Employee();
            newEmployee3.Id = "3";
            newEmployee3.Name = "Saeed";
            newEmployee3.Telephone = "1455666044";
            newEmployee3.Job = "Programmer";

            List<Employee> employees = new List<Employee>();
            employees.Add(newEmployee1);
            employees.Add(newEmployee2);
            employees.Add(newEmployee3);

            for (int i = 0; i < 5; i++)
            {
                ucEmployeeCard newEmployeeCard = new ucEmployeeCard();
                newEmployeeCard.Location = new Point(40, i * newEmployeeCard.Height + 90);

                // You need to fill the employees data here

                this.Controls.Add(newEmployeeCard);
            }

        }
    }
}
