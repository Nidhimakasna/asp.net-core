//6.Write a program to Replace lower case characters to upper case and     
//Vice-versa. 
//using System;

class Character
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string ch = Console.ReadLine();

        string result = "";

        foreach (char i in ch)
        {
            if (char.IsLower(i))
                result += char.ToUpper(i);
            else if (char.IsUpper(i))
                result += char.ToLower(i);
            else
                result += i;
        }

        Console.WriteLine("Converted string: " + result); 
    }
}
