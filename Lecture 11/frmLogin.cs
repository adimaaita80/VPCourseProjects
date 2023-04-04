using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_11
{
    public partial class frmLogin : Form
    {

        private User user1;
        private User user2;
        private List<User> users;

        public frmLogin()
        {
            InitializeComponent(); 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            user1 = new User();
            user1.UserId = 1;
            user1.FullName = "Khaled Mohammad";
            user1.Username = "KM";
            user1.Password = "1234";

            user2 = new User();
            user2.UserId = 2;
            user2.FullName = "Suad Ahmad";
            user2.Username = "SA";
            user2.Password = "5678";

            users = new List<User>(); // We created the actual object for the list of users

            users.Add(user1);
            users.Add(user2);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(user1.Username != txtUsername.Text)
            {
                MessageBox.Show("User does not exist");
            }
            else
            {
                if(user1.Password == txtPassword.Text)
                {
                    MessageBox.Show("Welcome " + user1.FullName);
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
        }
    }
}
