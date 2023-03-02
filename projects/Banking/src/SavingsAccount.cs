using System;
using Banking.Accounts;

namespace Banking.SavingsAccounts
{

    public class SavingsAccount : Account
    {
        public SavingsAccount(double balance) : base(balance)
        {
        }
       
        private double _interestRate = 0.8;

        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount + (amount * _interestRate);
                return true;
            }
            return false;
        }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += (amount + (amount * _interestRate));
                return true;
            }
            return false;
        }
        public override void PrintBalance()
        {
            Console.WriteLine($"Savings Balance: {Balance}");
        }
    }
}