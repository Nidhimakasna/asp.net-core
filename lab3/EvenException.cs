
//8.Write a program to accept a number from the user and throw an exception 
//if the number is not an even number. 
using System;

class EvenException
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (n % 2 != 0)
            {
                throw new Exception("Number is not even.");
            }

            Console.WriteLine("The number is even.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
