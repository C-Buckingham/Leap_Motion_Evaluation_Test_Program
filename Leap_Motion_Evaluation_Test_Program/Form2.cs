using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leap_Motion_Evaluation_Test_Program
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(300, 300);
            CenterToParent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            webBrowser1.Navigate("www.bbc.co.uk");
        }
    }
}
