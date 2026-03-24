using System.Text.RegularExpressions;

namespace Login_Reg

{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regMainPass = new System.Windows.Forms.TextBox();
            this.regSubPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.regPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.regName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 891);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // regMainPass
            // 
            this.regMainPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.regMainPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regMainPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regMainPass.ForeColor = System.Drawing.Color.White;
            this.regMainPass.Location = new System.Drawing.Point(632, 351);
            this.regMainPass.Name = "regMainPass";
            this.regMainPass.Size = new System.Drawing.Size(293, 23);
            this.regMainPass.TabIndex = 19;
            this.regMainPass.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // regSubPassword
            // 
            this.regSubPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.regSubPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regSubPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regSubPassword.ForeColor = System.Drawing.Color.White;
            this.regSubPassword.Location = new System.Drawing.Point(639, 444);
            this.regSubPassword.Name = "regSubPassword";
            this.regSubPassword.Size = new System.Drawing.Size(293, 23);
            this.regSubPassword.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(849, 807);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(632, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(632, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(590, 814);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Already have account..";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(742, 773);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(63, 26);
            this.exit.TabIndex = 11;
            this.exit.Text = "EXIT";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.alert.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(660, 673);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 26);
            this.alert.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(632, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Re-Eenter password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(632, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(632, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(707, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 49);
            this.label2.TabIndex = 9;
            this.label2.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(691, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(639, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "E-mail";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(639, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 16;
            // 
            // regEmail
            // 
            this.regEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.regEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regEmail.ForeColor = System.Drawing.Color.White;
            this.regEmail.Location = new System.Drawing.Point(639, 269);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(293, 23);
            this.regEmail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(632, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(632, 554);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 15;
            // 
            // regPhone
            // 
            this.regPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.regPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regPhone.ForeColor = System.Drawing.Color.White;
            this.regPhone.Location = new System.Drawing.Point(639, 528);
            this.regPhone.Name = "regPhone";
            this.regPhone.Size = new System.Drawing.Size(293, 23);
            this.regPhone.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(632, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "User Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(632, 642);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 15;
            // 
            // regName
            // 
            this.regName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.regName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regName.ForeColor = System.Drawing.Color.White;
            this.regName.Location = new System.Drawing.Point(639, 616);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(293, 23);
            this.regName.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(975, 862);
            this.Controls.Add(this.regEmail);
            this.Controls.Add(this.regMainPass);
            this.Controls.Add(this.regName);
            this.Controls.Add(this.regPhone);
            this.Controls.Add(this.regSubPassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox regMainPass;
        private TextBox regSubPassword;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label4;
        private Label exit;
        private Label alert;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel3;
        private TextBox regEmail;
        private Label label6;
        private Panel panel4;
        private TextBox regPhone;
        private Label label7;
        private Panel panel5;
        private TextBox regName;
    }
}