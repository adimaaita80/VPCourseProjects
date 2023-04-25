using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialogImages.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialogImages.FileName = "";

            openFileDialogImages.ShowDialog();
            string fileName = openFileDialogImages.FileName;
            picbxUser.ImageLocation = fileName;

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.Name = txtName.Text;
            newUser.DateOfBirth = dtpDOB.Value;
            newUser.ImageLocation = openFileDialogImages.FileName;

            MessageBox.Show(newUser.UserInfo());
        }
    }
}
