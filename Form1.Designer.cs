namespace tictactoe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            buttonRestart = new Button();
            button10 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 40F);
            button1.Location = new Point(31, 31);
            button1.Name = "button1";
            button1.Size = new Size(93, 88);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 40F);
            button2.Location = new Point(130, 31);
            button2.Name = "button2";
            button2.Size = new Size(93, 88);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 40F);
            button3.Location = new Point(229, 31);
            button3.Name = "button3";
            button3.Size = new Size(93, 88);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 40F);
            button4.Location = new Point(31, 125);
            button4.Name = "button4";
            button4.Size = new Size(93, 88);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 40F);
            button6.Location = new Point(229, 125);
            button6.Name = "button6";
            button6.Size = new Size(93, 88);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 40F);
            button5.Location = new Point(130, 125);
            button5.Name = "button5";
            button5.Size = new Size(93, 88);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 40F);
            button7.Location = new Point(31, 219);
            button7.Name = "button7";
            button7.Size = new Size(93, 88);
            button7.TabIndex = 5;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 40F);
            button8.Location = new Point(130, 219);
            button8.Name = "button8";
            button8.Size = new Size(93, 88);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 40F);
            button9.Location = new Point(229, 219);
            button9.Name = "button9";
            button9.Size = new Size(93, 88);
            button9.TabIndex = 7;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 31);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Segoe UI", 20F);
            buttonRestart.Location = new Point(347, 49);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(154, 108);
            buttonRestart.TabIndex = 9;
            buttonRestart.Text = "Restart";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += buttonRestart_Click_1;
            // 
            // button10
            // 
            button10.Location = new Point(302, 0);
            button10.Name = "button10";
            button10.Size = new Size(8, 8);
            button10.TabIndex = 10;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 349);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 348);
            Controls.Add(button10);
            Controls.Add(buttonRestart);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button buttonRestart;
        private Button button10;
        private Panel panel1;
    }
}
