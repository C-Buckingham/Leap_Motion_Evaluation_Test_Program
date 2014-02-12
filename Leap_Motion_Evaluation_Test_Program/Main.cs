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
    public partial class Main : Form
    {
        int counter = 1;
        public Main()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Position = new Point(0, 0);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coutner_Button_Click(object sender, EventArgs e)
        {
            Counter_Value.Text = counter++.ToString();

            if (counter == 6)
                Coutner_Button.Visible = false;
        }

        private void Show_Form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

    }
}
