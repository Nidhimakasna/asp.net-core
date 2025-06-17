
////10.Write a program to change the case of entered character. 

namespace lab3
{
    internal class ChangeChar
    {
        static void Main()
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z')
            {
                ch = Char.ToUpper(ch);
                Console.WriteLine("Uppercase: " + ch);
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                ch = Char.ToLower(ch);
                Console.WriteLine("Lowercase: " + ch);
            }
            else
            {
                Console.WriteLine("Not a letter.");
            }
        }
    }
}
