////6.Create a BankAccount class having constructor accepting initialBalance and 
////accountHolderName. Also create Deposite() and withdraw() overloaded 
////methods by which user can deposit/withdraw amount using different types
////of parameters(ex.cash, check).

class BankAccount
{
    string accountHolderName;
    double initialBalance;
    public BankAccount(string name, double balance)
    {
        accountHolderName = name;
        initialBalance = balance;
    }
    public void Deposit(double amount)
    {
        initialBalance += amount;
    }
    public void Deposit(string checkNumber,double amount)
    {
        initialBalance += amount;
    }
    public void Withdraw(double amount) {
        if (amount <=  initialBalance)
        {
            initialBalance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    public void Withdraw(string checkNumber, double amount) {
        if (amount <= initialBalance)
        {
            initialBalance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }
    public void ShowBalance()
    {
        Console.WriteLine("Current Balance: " + initialBalance);
    }
}
//using System;

//class BankAccount
//{
//    string accountHolderName;
//    double balance;

//    // Constructor
//    public BankAccount(string name, double initialBalance)
//    {
//        accountHolderName = name;
//        balance = initialBalance;
//    }
//    public void Deposit(double amount)
//    {
//        balance += amount;
//        Console.WriteLine("Cash Deposited: " + amount);
//    }

//    public void Deposit(string checkNumber, double amount)
//    {
//        balance += amount;
//        Console.WriteLine("Deposited using Check No. " + checkNumber + ": " + amount);
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount <= balance)
//        {
//            balance -= amount;
//            Console.WriteLine("Cash Withdrawn: " + amount);
//        }
//        else
//        {
//            Console.WriteLine("Insufficient Balance!");
//        }
//    }

//    public void Withdraw(string checkNumber, double amount)
//    {
//        if (amount <= balance)
//        {
//            balance -= amount;
//            Console.WriteLine("Withdrawn using Check No. " + checkNumber + ": " + amount);
//        }
//        else
//        {
//            Console.WriteLine("Insufficient Balance!");
//        }
//    }

//    public void ShowBalance()
//    {
//        Console.WriteLine("Current Balance: " + balance);
//    }
//}

