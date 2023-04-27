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
    public partial class frmUserControlDemo : Form
    {
        public frmUserControlDemo()
        {
            InitializeComponent();
        }

        private void frmUserControlDemo_Load(object sender, EventArgs e)
        {
            ucEmployeeCard1.EmpId = "1";
        }
    }
}
