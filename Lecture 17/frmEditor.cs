using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_17
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtxtEditor.SelectionFont = fontDialog1.Font;
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtxtEditor.SelectionColor = colorDialog1.Color;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtEditor.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", buttons);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
