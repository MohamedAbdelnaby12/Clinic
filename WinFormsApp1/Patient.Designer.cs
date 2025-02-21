namespace WinFormsApp1
{
    partial class PatientWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientWindow));
            logoname = new Label();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            Patient_Search_TxtBox = new TextBox();
            button2 = new Button();
            Patient_DGV = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Patient_DGV).BeginInit();
            SuspendLayout();
            // 
            // logoname
            // 
            logoname.AutoSize = true;
            logoname.BackColor = SystemColors.ButtonHighlight;
            logoname.ForeColor = SystemColors.ActiveCaptionText;
            logoname.Location = new Point(33, 51);
            logoname.Name = "logoname";
            logoname.Size = new Size(0, 20);
            logoname.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 59, 73);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(414, 531);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 46;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(87, 96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(524, 659);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 95);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // Patient_Search_TxtBox
            // 
            Patient_Search_TxtBox.Location = new Point(96, 111);
            Patient_Search_TxtBox.Name = "Patient_Search_TxtBox";
            Patient_Search_TxtBox.Size = new Size(133, 23);
            Patient_Search_TxtBox.TabIndex = 47;
            Patient_Search_TxtBox.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 59, 73);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(414, 128);
            button2.Name = "button2";
            button2.Size = new Size(181, 51);
            button2.TabIndex = 48;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Patient_DGV
            // 
            Patient_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Patient_DGV.Location = new Point(96, 154);
            Patient_DGV.Name = "Patient_DGV";
            Patient_DGV.Size = new Size(424, 217);
            Patient_DGV.TabIndex = 49;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 59, 73);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(414, 608);
            button3.Name = "button3";
            button3.Size = new Size(181, 51);
            button3.TabIndex = 50;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 59, 73);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(414, 684);
            button4.Name = "button4";
            button4.Size = new Size(181, 51);
            button4.TabIndex = 51;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 59, 73);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(110, 561);
            button5.Name = "button5";
            button5.Size = new Size(181, 51);
            button5.TabIndex = 52;
            button5.Text = "Import";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(32, 59, 73);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(110, 643);
            button6.Name = "button6";
            button6.Size = new Size(181, 51);
            button6.TabIndex = 53;
            button6.Text = "Export";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // PatientWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 59, 73);
            ClientSize = new Size(697, 749);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Patient_DGV);
            Controls.Add(button2);
            Controls.Add(Patient_Search_TxtBox);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(logoname);
            Name = "PatientWindow";
            Text = "Patient";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Patient_DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label logoname;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox Patient_Search_TxtBox;
        private Button button2;
        private DataGridView Patient_DGV;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}