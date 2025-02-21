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
            button1 = new Button();
            tName = new TextBox();
            Phone = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(256, 354);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Name
            // 
            tName.Location = new Point(256, 41);
            tName.Name = "Name";
            tName.Size = new Size(125, 27);
            tName.TabIndex = 2;
            // 
            // Phone
            // 
            Phone.Location = new Point(256, 121);
            Phone.Name = "Phone";
            Phone.Size = new Size(125, 27);
            Phone.TabIndex = 3;
            // 
            // Email
            // 
            Email.Location = new Point(256, 194);
            Email.Name = "Email";
            Email.Size = new Size(125, 27);
            Email.TabIndex = 4;
            // 
            // Password
            // 
            Password.Location = new Point(256, 271);
            Password.Name = "Password";
            Password.Size = new Size(125, 27);
            Password.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 128);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 197);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 278);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Phone);
            Controls.Add(tName);
            Controls.Add(button1);
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tName;
        private TextBox Phone;
        private TextBox Email;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}