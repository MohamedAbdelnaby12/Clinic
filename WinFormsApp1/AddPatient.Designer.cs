namespace WinFormsApp1
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            logoname = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            AddPatient_Name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AddPatient_Age = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            AddPatient_Gender = new ComboBox();
            panel4 = new Panel();
            AddPatient_Phone = new TextBox();
            panel5 = new Panel();
            AddPatient_Email = new TextBox();
            label5 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // logoname
            // 
            logoname.AutoSize = true;
            logoname.BackColor = SystemColors.ButtonHighlight;
            logoname.ForeColor = SystemColors.ActiveCaptionText;
            logoname.Location = new Point(24, 24);
            logoname.Name = "logoname";
            logoname.Size = new Size(0, 15);
            logoname.TabIndex = 0;
            logoname.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, -3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 71);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AddPatient_Name);
            panel1.Location = new Point(119, 94);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 53);
            panel1.TabIndex = 24;
            // 
            // AddPatient_Name
            // 
            AddPatient_Name.Location = new Point(11, 16);
            AddPatient_Name.Margin = new Padding(3, 2, 3, 2);
            AddPatient_Name.Name = "AddPatient_Name";
            AddPatient_Name.Size = new Size(350, 23);
            AddPatient_Name.TabIndex = 0;
            AddPatient_Name.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 81);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 159);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 26;
            label2.Text = "Age ";
            label2.Click += label2_Click_1;
            // 
            // AddPatient_Age
            // 
            AddPatient_Age.Location = new Point(11, 16);
            AddPatient_Age.Margin = new Padding(3, 2, 3, 2);
            AddPatient_Age.Name = "AddPatient_Age";
            AddPatient_Age.Size = new Size(350, 23);
            AddPatient_Age.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(AddPatient_Age);
            panel2.Location = new Point(119, 176);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 53);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(AddPatient_Gender);
            panel3.Location = new Point(119, 272);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 53);
            panel3.TabIndex = 27;
            // 
            // AddPatient_Gender
            // 
            AddPatient_Gender.FormattingEnabled = true;
            AddPatient_Gender.Location = new Point(11, 18);
            AddPatient_Gender.Margin = new Padding(3, 2, 3, 2);
            AddPatient_Gender.Name = "AddPatient_Gender";
            AddPatient_Gender.Size = new Size(350, 23);
            AddPatient_Gender.TabIndex = 29;
            AddPatient_Gender.SelectedIndexChanged += AddPatient_Gender_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(AddPatient_Phone);
            panel4.Location = new Point(119, 362);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 53);
            panel4.TabIndex = 29;
            // 
            // AddPatient_Phone
            // 
            AddPatient_Phone.Location = new Point(11, 16);
            AddPatient_Phone.Margin = new Padding(3, 2, 3, 2);
            AddPatient_Phone.Name = "AddPatient_Phone";
            AddPatient_Phone.Size = new Size(350, 23);
            AddPatient_Phone.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(AddPatient_Email);
            panel5.Location = new Point(119, 446);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 53);
            panel5.TabIndex = 31;
            // 
            // AddPatient_Email
            // 
            AddPatient_Email.Location = new Point(11, 16);
            AddPatient_Email.Margin = new Padding(3, 2, 3, 2);
            AddPatient_Email.Name = "AddPatient_Email";
            AddPatient_Email.Size = new Size(350, 23);
            AddPatient_Email.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(131, 431);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 32;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 256);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 30;
            label3.Text = "Gender";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(74, 73);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(459, 495);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 349);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 31;
            label4.Text = "Phone";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(215, 517);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(158, 38);
            button1.TabIndex = 33;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 59, 73);
            ClientSize = new Size(610, 562);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(logoname);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPatient";
            Text = "AddPatient";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logoname;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox AddPatient_Name;
        private Label label2;
        private TextBox AddPatient_Age;
        private Panel panel2;
        private Panel panel3;
        private ComboBox AddPatient_Gender;
        private Panel panel4;
        private TextBox AddPatient_Phone;
        private Panel panel5;
        private TextBox AddPatient_Email;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private Button button1;
    }
}
