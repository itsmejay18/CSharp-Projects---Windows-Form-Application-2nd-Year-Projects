using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Exam
{
    internal class Bank
    {
        private List<Account> accounts = new List<Account>();
        public Account CreateAccount(string accountNumber, string accountHolder)
        {
            var account = new Account(accountNumber, accountHolder);
            accounts.Add(account);
            return account;
        }
        public Account GetAccount(string accountNumber)
        {
            return accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }
    }
}
