﻿namespace Leap_Motion_Evaluation_Test_Program
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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Time_Taken_Timer = new System.Windows.Forms.Timer(this.components);
            this.Coutner_Button = new System.Windows.Forms.Button();
            this.Counter_Value = new System.Windows.Forms.Label();
            this.Practice_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Test_Radio_Button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(12, 1007);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Coutner_Button
            // 
            this.Coutner_Button.Location = new System.Drawing.Point(1080, 606);
            this.Coutner_Button.Name = "Coutner_Button";
            this.Coutner_Button.Size = new System.Drawing.Size(75, 23);
            this.Coutner_Button.TabIndex = 1;
            this.Coutner_Button.Text = "Add 1";
            this.Coutner_Button.UseVisualStyleBackColor = true;
            this.Coutner_Button.Click += new System.EventHandler(this.Coutner_Button_Click);
            // 
            // Counter_Value
            // 
            this.Counter_Value.AutoSize = true;
            this.Counter_Value.Location = new System.Drawing.Point(1161, 611);
            this.Counter_Value.Name = "Counter_Value";
            this.Counter_Value.Size = new System.Drawing.Size(35, 13);
            this.Counter_Value.TabIndex = 2;
            this.Counter_Value.Text = "label1";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.Test_Radio_Button);
            this.Controls.Add(this.Practice_Radio_Button);
            this.Controls.Add(this.Counter_Value);
            this.Controls.Add(this.Coutner_Button);
            this.Controls.Add(this.Exit_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Timer Time_Taken_Timer;
        private System.Windows.Forms.Button Coutner_Button;
        private System.Windows.Forms.Label Counter_Value;
        private System.Windows.Forms.RadioButton Practice_Radio_Button;
        private System.Windows.Forms.RadioButton Test_Radio_Button;
    }
}
