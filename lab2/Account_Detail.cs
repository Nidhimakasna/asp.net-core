
//6.Write a program for implementing single inheritance which creates one 
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted
//from account details.
class Account_Detail
{
    public string user_Name;
    public int accountNumber;
    public double Principal;
    public float Rate;
    public int Time;

    public void GetAccountDetails()
    {
        Console.Write("Enter Account user Name: ");
        user_Name = Console.ReadLine();

        Console.Write("Enter Account Number: ");
        accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Principal Amount: ");
        Principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest : ");
        Rate = float.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        Time = Convert.ToInt32(Console.ReadLine());
    }
}

class Interest : Account_Detail
{    public void CalculateInterest()
    {
        double interest = (Principal * Rate * Time) / 100;

        Console.WriteLine("\n--- Account Summary ---");
        Console.WriteLine("Account Holder: " + user_Name);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Principal Amount: " + Principal);
        Console.WriteLine("Rate of Interest: " + Rate);
        Console.WriteLine("Time Period: " +  +Time);
        Console.WriteLine("Total Interest: " + interest);
    }
}
