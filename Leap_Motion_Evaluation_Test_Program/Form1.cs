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
    public partial class Form1 : Form
    {
        int counter = 1;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coutner_Button_Click(object sender, EventArgs e)
        {
            Counter_Value.Text = counter++.ToString();
            if (counter == 6)
            {
                Coutner_Button.Visible = false;
            }
        }

    }
}
