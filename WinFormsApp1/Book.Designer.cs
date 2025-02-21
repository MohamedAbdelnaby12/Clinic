
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
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Location = new Point(51, 47);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 1;
            label1.Text = "Doctor ";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(83, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 659);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(439, 251);
            dataGridView1.TabIndex = 39;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(339, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 38;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ControlDarkDark;
            checkBox1.Location = new Point(195, 517);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 32);
            checkBox1.TabIndex = 37;
            checkBox1.Text = "Payement ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(51, 143);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 36;
            label2.Text = "Appointment";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 59, 73);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(347, 587);
            button2.Name = "button2";
            button2.Size = new Size(142, 51);
            button2.TabIndex = 35;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(51, 587);
            button1.Name = "button1";
            button1.Size = new Size(142, 51);
            button1.TabIndex = 34;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(339, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
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
            Text = "Book";
            Load += Book_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
    }
}