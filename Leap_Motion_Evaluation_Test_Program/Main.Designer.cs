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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Time_Taken_Timer = new System.Windows.Forms.Timer(this.components);
            this.Coutner_Button = new System.Windows.Forms.Button();
            this.Counter_Value = new System.Windows.Forms.Label();
            this.Practice_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Test_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Show_Form2 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(16, 1239);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(100, 28);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Time_Taken_Timer
            // 
            this.Time_Taken_Timer.Enabled = true;
            // 
            // Coutner_Button
            // 
            this.Coutner_Button.Location = new System.Drawing.Point(16, 138);
            this.Coutner_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Coutner_Button.Name = "Coutner_Button";
            this.Coutner_Button.Size = new System.Drawing.Size(115, 28);
            this.Coutner_Button.TabIndex = 1;
            this.Coutner_Button.Text = "Add 1";
            this.Coutner_Button.UseVisualStyleBackColor = true;
            this.Coutner_Button.Click += new System.EventHandler(this.Coutner_Button_Click);
            // 
            // Counter_Value
            // 
            this.Counter_Value.AutoSize = true;
            this.Counter_Value.Location = new System.Drawing.Point(139, 144);
            this.Counter_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Counter_Value.Name = "Counter_Value";
            this.Counter_Value.Size = new System.Drawing.Size(16, 17);
            this.Counter_Value.TabIndex = 2;
            this.Counter_Value.Text = "0";
            // 
            // Practice_Radio_Button
            // 
            this.Practice_Radio_Button.AutoSize = true;
            this.Practice_Radio_Button.Checked = true;
            this.Practice_Radio_Button.Location = new System.Drawing.Point(16, 16);
            this.Practice_Radio_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Practice_Radio_Button.Name = "Practice_Radio_Button";
            this.Practice_Radio_Button.Size = new System.Drawing.Size(119, 21);
            this.Practice_Radio_Button.TabIndex = 3;
            this.Practice_Radio_Button.TabStop = true;
            this.Practice_Radio_Button.Text = "Practice Mode";
            this.Practice_Radio_Button.UseVisualStyleBackColor = true;
            this.Practice_Radio_Button.CheckedChanged += new System.EventHandler(this.Practice_Radio_Button_CheckedChanged);
            // 
            // Test_Radio_Button
            // 
            this.Test_Radio_Button.AutoSize = true;
            this.Test_Radio_Button.Location = new System.Drawing.Point(16, 46);
            this.Test_Radio_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Test_Radio_Button.Name = "Test_Radio_Button";
            this.Test_Radio_Button.Size = new System.Drawing.Size(96, 21);
            this.Test_Radio_Button.TabIndex = 4;
            this.Test_Radio_Button.Text = "Test Mode";
            this.Test_Radio_Button.UseVisualStyleBackColor = true;
            this.Test_Radio_Button.CheckedChanged += new System.EventHandler(this.Test_Radio_Button_CheckedChanged);
            // 
            // Show_Form2
            // 
            this.Show_Form2.Location = new System.Drawing.Point(16, 102);
            this.Show_Form2.Margin = new System.Windows.Forms.Padding(4);
            this.Show_Form2.Name = "Show_Form2";
            this.Show_Form2.Size = new System.Drawing.Size(115, 28);
            this.Show_Form2.TabIndex = 5;
            this.Show_Form2.Text = "New Window";
            this.Show_Form2.UseVisualStyleBackColor = true;
            this.Show_Form2.Click += new System.EventHandler(this.Show_Form2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 1130);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(16, 1010);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Show_Form2);
            this.Controls.Add(this.Test_Radio_Button);
            this.Controls.Add(this.Practice_Radio_Button);
            this.Controls.Add(this.Counter_Value);
            this.Controls.Add(this.Coutner_Button);
            this.Controls.Add(this.Exit_Button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main Form";
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
        private System.Windows.Forms.Button Show_Form2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Exit;
    }
}

