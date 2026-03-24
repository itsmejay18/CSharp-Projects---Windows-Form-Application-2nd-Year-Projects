namespace Login_Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            exit = new Label();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            alert = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 448);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(596, 27);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 33, 33);
            label2.Font = new Font("Bauhaus 93", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(606, 123);
            label2.Name = "label2";
            label2.Size = new Size(114, 39);
            label2.TabIndex = 3;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(549, 167);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 4;
            label1.Text = "E-mail";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(549, 221);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 1);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(549, 243);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(549, 291);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 1);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(549, 328);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(262, 30);
            button1.TabIndex = 6;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 33, 33);
            button2.FlatAppearance.BorderColor = Color.FromArgb(33, 33, 33);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(710, 401);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(88, 30);
            button2.TabIndex = 6;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(512, 406);
            label4.Name = "label4";
            label4.Size = new Size(188, 25);
            label4.TabIndex = 4;
            label4.Text = "Dont have account..";
            label4.Click += label4_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.White;
            exit.Location = new Point(645, 376);
            exit.Name = "exit";
            exit.Size = new Size(52, 21);
            exit.TabIndex = 4;
            exit.Text = "EXIT";
            exit.Click += exit_Click;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.FromArgb(33, 33, 33);
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.ForeColor = Color.White;
            passwordBox.Location = new Point(555, 272);
            passwordBox.Margin = new Padding(3, 2, 3, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(256, 19);
            passwordBox.TabIndex = 7;
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.FromArgb(33, 33, 33);
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailBox.ForeColor = Color.White;
            emailBox.Location = new Point(549, 202);
            emailBox.Margin = new Padding(3, 2, 3, 2);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(256, 19);
            emailBox.TabIndex = 7;
            emailBox.TextChanged += textBox2_TextChanged;
            // 
            // alert
            // 
            alert.AutoSize = true;
            alert.BackColor = Color.FromArgb(33, 33, 33);
            alert.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            alert.ForeColor = Color.Red;
            alert.Location = new Point(573, 301);
            alert.Name = "alert";
            alert.Size = new Size(0, 21);
            alert.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(854, 443);
            Controls.Add(emailBox);
            Controls.Add(passwordBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(exit);
            Controls.Add(alert);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label exit;
        private TextBox passwordBox;
        private TextBox emailBox;
        private Label alert;
    }
}