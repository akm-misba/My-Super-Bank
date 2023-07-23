using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get

            {
                decimal balance = 0;
                foreach (var item in alltransactions)
                {
                    balance = balance + item.ammount;
                }
                return balance;

            }


        }
        private static int AccountNumberSeed = 1234567890;
        public List<Transaction> alltransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            //this.Balance = initialBalance;
            MakeDeposit(initialBalance, DateTime.Now, "Intial Balance");
            this.Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in alltransactions)
            {
                balance += item.ammount;
                report.AppendLine($"{item.date.ToShortDateString()}\t{item.ammount}\t{balance}\t{item.note}");
            }

            return report.ToString();
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            alltransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            alltransactions.Add(withdrawal);
        }
    }
}
