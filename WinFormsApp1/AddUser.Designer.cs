namespace WinFormsApp1
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            Password = new TextBox();
            panel4 = new Panel();
            Email = new TextBox();
            panel2 = new Panel();
            Phone = new TextBox();
            panel1 = new Panel();
            tName = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(246, 651);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 46;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(151, 361);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 43;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(151, 500);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 45;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(151, 234);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 39;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(151, 115);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 34;
            label1.Text = "Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(Password);
            panel5.Location = new Point(137, 518);
            panel5.Name = "panel5";
            panel5.Size = new Size(423, 70);
            panel5.TabIndex = 44;
            // 
            // Password
            // 
            Password.Location = new Point(13, 21);
            Password.Name = "Password";
            Password.Size = new Size(399, 27);
            Password.TabIndex = 0;
            Password.TextChanged += AddPatient_Email_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(Email);
            panel4.Location = new Point(137, 380);
            panel4.Name = "panel4";
            panel4.Size = new Size(423, 70);
            panel4.TabIndex = 41;
            // 
            // Email
            // 
            Email.Location = new Point(13, 21);
            Email.Name = "Email";
            Email.Size = new Size(399, 27);
            Email.TabIndex = 0;
            Email.TextChanged += AddPatient_Phone_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Phone);
            panel2.Location = new Point(137, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 70);
            panel2.TabIndex = 38;
            // 
            // Phone
            // 
            Phone.Location = new Point(13, 21);
            Phone.Name = "Phone";
            Phone.Size = new Size(399, 27);
            Phone.TabIndex = 0;
            Phone.TextChanged += AddPatient_Age_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tName);
            panel1.Location = new Point(137, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 70);
            panel1.TabIndex = 37;
            // 
            // tName
            // 
            tName.Location = new Point(13, 21);
            tName.Name = "tName";
            tName.Size = new Size(399, 27);
            tName.TabIndex = 0;
            tName.TextChanged += AddPatient_Name_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(86, 95);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(524, 659);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 95);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 59, 73);
            ClientSize = new Size(697, 749);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private TextBox Password;
        private Panel panel4;
        private TextBox Email;
        private Panel panel2;
        private TextBox Phone;
        private Panel panel1;
        private TextBox tName;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}