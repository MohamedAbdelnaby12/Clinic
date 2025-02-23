
namespace WinFormsApp1
{
    partial class Book
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
            label1 = new Label();
            panel1 = new Panel();
            Doctor = new Label();
            paymentmethod = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            comboBoxDoctors = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Smile__4_;
            pictureBox1.Location = new Point(83, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(69, 110);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 1;
            label1.Text = "Doctor ";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Doctor);
            panel1.Controls.Add(paymentmethod);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBoxDoctors);
            panel1.Location = new Point(83, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 659);
            panel1.TabIndex = 2;
            // 
            // Doctor
            // 
            Doctor.AutoSize = true;
            Doctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Doctor.ForeColor = SystemColors.ControlDarkDark;
            Doctor.Location = new Point(69, 223);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(175, 28);
            Doctor.TabIndex = 41;
            Doctor.Text = "Payment Method";
            Doctor.Click += label2_Click;
            // 
            // paymentmethod
            // 
            paymentmethod.FormattingEnabled = true;
            paymentmethod.Location = new Point(319, 223);
            paymentmethod.Name = "paymentmethod";
            paymentmethod.Size = new Size(151, 28);
            paymentmethod.TabIndex = 40;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 59, 73);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(319, 387);
            button2.Name = "button2";
            button2.Size = new Size(142, 51);
            button2.TabIndex = 35;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(69, 387);
            button1.Name = "button1";
            button1.Size = new Size(142, 51);
            button1.TabIndex = 34;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.FormattingEnabled = true;
            comboBoxDoctors.Location = new Point(319, 114);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(151, 28);
            comboBoxDoctors.TabIndex = 2;
            comboBoxDoctors.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 59, 73);
            ClientSize = new Size(697, 749);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            Load += Book_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxDoctors;
        private Button button1;
        private Button button2;
        private ComboBox paymentmethod;
        private Label Doctor;
    }
}