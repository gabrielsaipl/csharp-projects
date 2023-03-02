using System;

namespace Banking.Accounts
{

    public class Account
    {
        public Account(double balance)
        {
            Balance = balance;
        }
       private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
public virtual bool Withdraw(double amount){
 return  false; //this._balance -= amount;
}
public virtual bool Deposit(double amount){
  return false; //this._balance += amount;
}
public virtual void PrintBalance(){
   Console.WriteLine($"Balance: {_balance}");
}
}
}
// Path: src/Program.cs