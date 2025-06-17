
////9. Write a program to Swapping without using third variable.
//using System;
class swapnum
{
    static void Main(string[] args)
    {
        int a, b;


        Console.Write("Enter first number (a): ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nBefore Swapping: a = {a}, b = {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"After Swapping: a = {a}, b = {b}");
    }
}

