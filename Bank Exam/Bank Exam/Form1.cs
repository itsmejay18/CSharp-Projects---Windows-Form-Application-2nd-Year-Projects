using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Exam
{
    public partial class BankingForm : Form
    {
        public BankingForm()
        {
            InitializeComponent();
        }

        private Bank bank = new Bank();
       
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            string accountHolder = txtAccountHolder.Text;
            if (!string.IsNullOrEmpty(accountNumber) && !string.IsNullOrEmpty(accountHolder))
            {
                bank.CreateAccount(accountNumber, accountHolder);
                lblMessage.Text = "Account created successfully.";
            }
            else
            {
                lblMessage.Text = "Please enter account details.";
            }
        }


        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void BankingForm_Load(object sender, EventArgs e)
        {

        }


        private void btnDeposit_Click_1(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            var account = bank.GetAccount(accountNumber);
            if (account != null)
            {
                account.Deposit(amount);
                lblMessage.Text = $"Deposited {amount:C} successfully.";
            }
            else
            {
                lblMessage.Text = "Account not found.";
            }
        }

        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            var account = bank.GetAccount(accountNumber);
            if (account != null)
            {
                if (account.Withdraw(amount))
                {
                    lblMessage.Text = $"Withdrew {amount:C} successfully.";
                }
                else
                {
                    lblMessage.Text = "Insufficient funds.";
                }
            }
            else
            {
                lblMessage.Text = "Account not found.";
            }
        }

        private void btnCheckBalance_Click_1(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;
            var account = bank.GetAccount(accountNumber);
            if (account != null)
            {
                lblMessage.Text = $"Current balance: {account.Balance:C}.";
            }
            else
            {
                lblMessage.Text = "Account not found.";
            }
        }
    }
    
}
