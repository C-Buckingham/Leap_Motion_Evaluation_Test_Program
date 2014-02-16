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
        List<double> timeTakenList = new List<double>();
        string allTime;
        int counter = 1;
        double timeTaken = 0;
        public Main()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void Coutner_Button_Click(object sender, EventArgs e)
        {
            Counter_Value.Text = counter++.ToString();

            if (counter == 6 && Test_Radio_Button.Checked == true)
            {
                Coutner_Button.Enabled = false;
                Time_Taken_Timer.Stop();
                timeTakenList.Add(timeTaken);
                MessageBox.Show("Thank you for completing all the tasks");
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

        private void Exit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < timeTakenList.Count(); i++)
            {
                allTime += timeTakenList[i].ToString() + " ";

            }
            System.IO.File.WriteAllText(@"C:\Users\chris\desktop\time.txt", allTime);
            this.Close();
        }

        private void Test_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Test_Radio_Button.Checked == true)
            {            
                Cursor.Position = new Point(0, 0);
                Exit.Enabled = false;
                Time_Taken_Timer.Start();
            }

        }

        private void Practice_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {
            counter = 1;
            Counter_Value.Text = 0.ToString();

            Coutner_Button.Enabled = true;
            Show_Form2.Enabled = true;
            Exit.Enabled = true;
        }

        private void Time_Taken_Timer_Tick(object sender, EventArgs e)
        {
            timeTaken += 0.01;
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Mousedown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
