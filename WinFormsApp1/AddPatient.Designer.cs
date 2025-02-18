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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            textBox3 = new TextBox();
            panel5 = new Panel();
            textBox4 = new TextBox();
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
            logoname.Location = new Point(27, 32);
            logoname.Name = "logoname";
            logoname.Size = new Size(0, 20);
            logoname.TabIndex = 0;
            logoname.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(524, 95);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(136, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 70);
            panel1.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 212);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 26;
            label2.Text = "Age ";
            label2.Click += label2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 27);
            textBox2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(136, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 70);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBox1);
            panel3.Location = new Point(136, 362);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 70);
            panel3.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(399, 28);
            comboBox1.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(136, 482);
            panel4.Name = "panel4";
            panel4.Size = new Size(422, 70);
            panel4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 27);
            textBox3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox4);
            panel5.Location = new Point(136, 595);
            panel5.Name = "panel5";
            panel5.Size = new Size(422, 70);
            panel5.TabIndex = 31;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(399, 27);
            textBox4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(150, 575);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 32;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 342);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 30;
            label3.Text = "Gender";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(85, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(524, 659);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 465);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 31;
            label4.Text = "Phone";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(246, 689);
            button1.Name = "button1";
            button1.Size = new Size(180, 50);
            button1.TabIndex = 33;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 59, 73);
            ClientSize = new Size(697, 814);
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Panel panel2;
        private Panel panel3;
        private ComboBox comboBox1;
        private Panel panel4;
        private TextBox textBox3;
        private Panel panel5;
        private TextBox textBox4;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private Button button1;
    }
}
