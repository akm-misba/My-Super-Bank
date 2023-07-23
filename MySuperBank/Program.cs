using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Misba",100);
            Console.WriteLine($"Account {account.Number} was created for { account.Owner} with {account.Balance}");
            account.MakeDeposit(20, DateTime.Now, "nisdsf");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(-5, DateTime.Now, "uyyyyyy");
            Console.WriteLine($"====={account.Balance}========");
            account.MakeWithdrawal(-5, DateTime.Now, "uyyyyyy");
            Console.WriteLine($"----{account.Balance}-----");
            Console.WriteLine(account.GetAccountHistory());



            Console.WriteLine("sahim",600);
            Console.WriteLine($"Account {account.Number} was created for { account.Owner} with {account.Balance}");


        }
    }
}
