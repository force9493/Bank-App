using System;

namespace Bank_App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool withdrawRes = false;
            bool depositRes = false;
            decimal amount = 0;
            Account nAccount;
            nAccount = new Account();

            amount = decimal.Parse(Console.ReadLine());
            depositRes = nAccount.deposit(amount);

            Console.WriteLine("Deposit " + (depositRes ? "succeed" : "failed"));

            amount = decimal.Parse(Console.ReadLine());
            withdrawRes = nAccount.withdraw(amount);

            Console.WriteLine("Withdraw " + (withdrawRes ? "succeed" : "failed"));

            Console.WriteLine("Account balance is " + nAccount.getBalace());
        }
    }
}
