namespace QR_Code_Scanner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(422, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 115);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(404, 298);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(225, 88);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(121, 21);
            this.cboDevice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camera : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(422, 143);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(268, 168);
            this.txtQRCode.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Timer timer1;
    }
}

