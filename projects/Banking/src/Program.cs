using System;
using Banking.Accounts;
using Banking.CheckingAccounts;
using Banking.SavingsAccounts;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uncomment the below block to test your code
      
      Account SAccount = new SavingsAccount(5000);

      // Creating saving account object
      SAccount.Deposit(1000);
      SAccount.PrintBalance();

      SAccount.Withdraw(3000);
      SAccount.PrintBalance();

      Console.WriteLine();

      // Creating checking account object
      Account CAccount = new CheckingAccount(5000);
      CAccount.Deposit(1000);
      CAccount.PrintBalance();

      CAccount.Withdraw(3000);
      CAccount.PrintBalance();
            
        }
    }
}