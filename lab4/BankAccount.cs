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
