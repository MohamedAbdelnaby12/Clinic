﻿namespace WinFormsApp1
{
    partial class login
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
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            UserName = new TextBox();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            Password = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Smile__4_;
            pictureBox1.Location = new Point(90, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(90, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(524, 659);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(UserName);
            panel1.Location = new Point(130, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 85);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.تصميم_بدون_عنوان__3_1;
            pictureBox4.Location = new Point(-1, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 68);
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // UserName
            // 
            UserName.Location = new Point(80, 32);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.Size = new Size(356, 27);
            UserName.TabIndex = 0;
            UserName.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(Password);
            panel2.Location = new Point(130, 536);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 81);
            panel2.TabIndex = 26;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.تصميم_بدون_عنوان__2_;
            pictureBox5.Location = new Point(5, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 73);
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // Password
            // 
            Password.Location = new Point(80, 27);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.Size = new Size(356, 27);
            Password.TabIndex = 0;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.تصميم_بدون_عنوان__1_;
            pictureBox2.Location = new Point(90, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(525, 220);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(297, 344);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 27;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(297, 516);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 29;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(261, 645);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 34;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 59, 73);
            ClientSize = new Size(697, 749);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private TextBox UserName;
        private Panel panel2;
        private TextBox Password;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label3;
        private Button button1;
        private Control textBox1;
    }
}