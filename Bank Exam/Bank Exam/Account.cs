using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Exam
{
    internal class Account
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }
        public Account(string accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

    }
}
