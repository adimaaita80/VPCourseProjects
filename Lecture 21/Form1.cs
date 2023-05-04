using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iU_VP_Script_DBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.iU_VP_Script_DBDataSet.Students);

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentId.Text = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStudentName.Text = dgvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
