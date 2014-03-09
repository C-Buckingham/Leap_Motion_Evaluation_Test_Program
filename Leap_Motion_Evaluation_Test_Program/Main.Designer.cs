namespace Leap_Motion_Evaluation_Test_Program
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Time_Taken_Timer = new System.Windows.Forms.Timer(this.components);
            this.Coutner_Button = new System.Windows.Forms.Button();
            this.Counter_Value = new System.Windows.Forms.Label();
            this.Practice_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Test_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Show_Form2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Time_Taken_Timer
            // 
            this.Time_Taken_Timer.Enabled = true;
            this.Time_Taken_Timer.Interval = 10;
            this.Time_Taken_Timer.Tick += new System.EventHandler(this.Time_Taken_Timer_Tick);
            // 
            // Coutner_Button
            // 
            this.Coutner_Button.Location = new System.Drawing.Point(12, 112);
            this.Coutner_Button.Name = "Coutner_Button";
            this.Coutner_Button.Size = new System.Drawing.Size(86, 23);
            this.Coutner_Button.TabIndex = 1;
            this.Coutner_Button.Text = "Add 1";
            this.Coutner_Button.UseVisualStyleBackColor = true;
            this.Coutner_Button.Click += new System.EventHandler(this.Coutner_Button_Click);
            // 
            // Counter_Value
            // 
            this.Counter_Value.AutoSize = true;
            this.Counter_Value.Location = new System.Drawing.Point(104, 117);
            this.Counter_Value.Name = "Counter_Value";
            this.Counter_Value.Size = new System.Drawing.Size(13, 13);
            this.Counter_Value.TabIndex = 2;
            this.Counter_Value.Text = "0";
            // 
            // Practice_Radio_Button
            // 
            this.Practice_Radio_Button.AutoSize = true;
            this.Practice_Radio_Button.Checked = true;
            this.Practice_Radio_Button.Location = new System.Drawing.Point(12, 13);
            this.Practice_Radio_Button.Name = "Practice_Radio_Button";
            this.Practice_Radio_Button.Size = new System.Drawing.Size(94, 17);
            this.Practice_Radio_Button.TabIndex = 3;
            this.Practice_Radio_Button.TabStop = true;
            this.Practice_Radio_Button.Text = "Practice Mode";
            this.Practice_Radio_Button.UseVisualStyleBackColor = true;
            this.Practice_Radio_Button.CheckedChanged += new System.EventHandler(this.Practice_Radio_Button_CheckedChanged);
            // 
            // Test_Radio_Button
            // 
            this.Test_Radio_Button.AutoSize = true;
            this.Test_Radio_Button.Location = new System.Drawing.Point(12, 37);
            this.Test_Radio_Button.Name = "Test_Radio_Button";
            this.Test_Radio_Button.Size = new System.Drawing.Size(76, 17);
            this.Test_Radio_Button.TabIndex = 4;
            this.Test_Radio_Button.Text = "Test Mode";
            this.Test_Radio_Button.UseVisualStyleBackColor = true;
            this.Test_Radio_Button.CheckedChanged += new System.EventHandler(this.Test_Radio_Button_CheckedChanged);
            // 
            // Show_Form2
            // 
            this.Show_Form2.Location = new System.Drawing.Point(12, 83);
            this.Show_Form2.Name = "Show_Form2";
            this.Show_Form2.Size = new System.Drawing.Size(86, 23);
            this.Show_Form2.TabIndex = 5;
            this.Show_Form2.Text = "New Window";
            this.Show_Form2.UseVisualStyleBackColor = true;
            this.Show_Form2.Click += new System.EventHandler(this.Show_Form2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(11, 1012);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(56, 19);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Show_Form2);
            this.Controls.Add(this.Test_Radio_Button);
            this.Controls.Add(this.Practice_Radio_Button);
            this.Controls.Add(this.Counter_Value);
            this.Controls.Add(this.Coutner_Button);
            this.Name = "Main";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Time_Taken_Timer;
        private System.Windows.Forms.Button Coutner_Button;
        private System.Windows.Forms.Label Counter_Value;
        private System.Windows.Forms.RadioButton Practice_Radio_Button;
        private System.Windows.Forms.RadioButton Test_Radio_Button;
        private System.Windows.Forms.Button Show_Form2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

