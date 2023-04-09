using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // To create a new custom event handling method:
        // object sender: represents the control that triggered the event.
        // EventArgs e: represents all the data related to the event.
        private void my_event_handler(object sender, EventArgs e)
        {
            txtScreen.Text =  ((Button)sender).Text; // I cast the sender into a Button
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(my_event_handler);
            btn2.Click += new EventHandler(my_event_handler);
            button3.Click += new EventHandler(my_event_handler);
            // Continue doing this for all number buttons
        }

        // You are required to create a simple calculator based on this project
        // The calculator must provide the following operations:
        // Adding +, Subtracting -, Multiplication *, Division /
        

        // Note: You must use custom event handlers just as explained in this lecture
    }
}
