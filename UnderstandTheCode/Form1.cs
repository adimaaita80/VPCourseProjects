using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandTheCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button button1 = new Button();
            button1.Name = "Button1";
            button1.Text = "Button1";
            button1.Location = new Point(100, 100);
            button1.Size = new Size(180, 52);

            this.Controls.Add(button1);
        }
    }
}
