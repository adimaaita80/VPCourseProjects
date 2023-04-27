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
    public partial class ucEmployeeCard : UserControl
    {
        public string EmpId { get; set; }

        public ucEmployeeCard()
        {
            InitializeComponent();
        }

        private void ucEmployeeCard_Load(object sender, EventArgs e)
        {

        }
    }
}
