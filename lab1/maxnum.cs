////10. Write a program to find maximum numbers from given 3 numbers using ternary operator. 

using System;

class maxnum
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a number: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        int n3 = int.Parse(Console.ReadLine());
        int res = (n1 > n2) ? (n1 > n3 ? n1 : n3) : (n2 > n3 ? n2 : n3);
        Console.WriteLine("The number is " + res);
    }
}
