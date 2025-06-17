////7.Write a program to find out Simple Interest using function. (I = PRN / 100)
////using System;

class Lab1
{

    static double SimpleInterest(double principal, double rate, double time)
    {
        double interest = (principal * rate * time) / 100;
        return interest;
    }

    static void Main(string[] args)
    {

        Console.Write("Enter Principal Amount (P): ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest (R): ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time in Years (N): ");
        double time = double.Parse(Console.ReadLine());


        double interest = SimpleInterest(principal, rate, time);

        Console.WriteLine("Simple Interest = " + interest);
    }
}
