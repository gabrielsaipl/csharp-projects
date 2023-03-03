namespace Banking.Tests;

using Banking.Accounts;
using Banking.CheckingAccounts;
using Banking.SavingsAccounts;


public class UnitTest1
{
    [Fact]
    public void BankingTests()
    {
        Account SAccount = new SavingsAccount(5000);
        SAccount.Deposit(1000);
        SAccount.PrintBalance();
        Assert.Equal(6800, SAccount.Balance);

    }
}