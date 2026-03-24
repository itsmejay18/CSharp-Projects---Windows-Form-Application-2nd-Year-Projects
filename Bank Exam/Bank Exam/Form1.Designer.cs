namespace Bank_Exam
{
    partial class BankingForm
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
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(135, 62);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(135, 103);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(100, 20);
            this.txtAccountHolder.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(135, 142);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Number :\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "\r\nAccount Holder Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount :";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(315, 59);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(132, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(315, 89);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(132, 23);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click_1);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(315, 118);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(132, 23);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click_1);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(315, 148);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(132, 23);
            this.btnCheckBalance.TabIndex = 6;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click_1);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(19, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(55, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Messages";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Location = new System.Drawing.Point(135, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 42);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "MINI - BANK";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(204, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 41);
            this.panel2.TabIndex = 10;
            // 
            // BankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 289);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccountHolder);
            this.Controls.Add(this.txtAccountNumber);
            this.Name = "BankingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BankingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}

