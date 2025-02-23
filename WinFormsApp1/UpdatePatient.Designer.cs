namespace WinFormsApp1
{
    partial class UpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePatient));
            logoname = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            email = new TextBox();
            panel4 = new Panel();
            phone = new TextBox();
            panel3 = new Panel();
            gender = new ComboBox();
            panel2 = new Panel();
            age = new TextBox();
            panel1 = new Panel();
            name = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logoname
            // 
            logoname.AutoSize = true;
            logoname.BackColor = SystemColors.ButtonHighlight;
            logoname.ForeColor = SystemColors.ActiveCaptionText;
            logoname.Location = new Point(57, 63);
            logoname.Name = "logoname";
            logoname.Size = new Size(0, 20);
            logoname.TabIndex = 35;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(248, 688);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 48;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(152, 464);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 45;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 340);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 44;
            label3.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(152, 573);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 47;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 211);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 41;
            label2.Text = "Age ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 107);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 36;
            label1.Text = "Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(email);
            panel5.Location = new Point(138, 593);
            panel5.Name = "panel5";
            panel5.Size = new Size(423, 70);
            panel5.TabIndex = 46;
            // 
            // email
            // 
            email.Location = new Point(13, 21);
            email.Name = "email";
            email.Size = new Size(399, 27);
            email.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(phone);
            panel4.Location = new Point(138, 481);
            panel4.Name = "panel4";
            panel4.Size = new Size(423, 70);
            panel4.TabIndex = 43;
            // 
            // phone
            // 
            phone.Location = new Point(13, 21);
            phone.Name = "phone";
            phone.Size = new Size(399, 27);
            phone.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(gender);
            panel3.Location = new Point(138, 361);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 70);
            panel3.TabIndex = 42;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Location = new Point(13, 24);
            gender.Name = "gender";
            gender.Size = new Size(399, 28);
            gender.TabIndex = 29;
            gender.SelectedIndexChanged += gender_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(age);
            panel2.Location = new Point(138, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 70);
            panel2.TabIndex = 40;
            // 
            // age
            // 
            age.Location = new Point(13, 21);
            age.Name = "age";
            age.Size = new Size(399, 27);
            age.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(name);
            panel1.Location = new Point(138, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 70);
            panel1.TabIndex = 39;
            // 
            // name
            // 
            name.Location = new Point(13, 21);
            name.Name = "name";
            name.Size = new Size(399, 27);
            name.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(87, 96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(524, 659);
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 95);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // UpdatePatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 59, 73);
            ClientSize = new Size(697, 749);
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
            Name = "UpdatePatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdatePatient";
            Load += UpdatePatient_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
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
        private Label logoname;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private TextBox email;
        private Panel panel4;
        private TextBox phone;
        private Panel panel3;
        private ComboBox gender;
        private Panel panel2;
        private TextBox age;
        private Panel panel1;
        private TextBox name;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}