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
            {
                Coutner_Button.Enabled = false;
                Time_Taken_Timer.Stop();
                MessageBox.Show(Time_Taken_Timer.ToString());
            }
                
        }

        private void Show_Form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            if (Test_Radio_Button.Checked == true)
            {            
                Show_Form2.Enabled = false;
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Test_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {
            Exit.Enabled = false;
            Time_Taken_Timer.Start();
        }

        private void Practice_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {
            counter = 1;
            Counter_Value.Text = 0.ToString();

            Coutner_Button.Enabled = true;
            Show_Form2.Enabled = true;
            Exit.Enabled = true;
        }

    }
}
