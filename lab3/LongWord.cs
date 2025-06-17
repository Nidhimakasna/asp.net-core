

////9.Write a program to find the longest word in a string. 
class LongWord
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sen = Console.ReadLine();

        string[] words = sen.Split(' ');

        string longest = words[0];

        foreach (string i in words)
        {
            if (i.Length > longest.Length)
            {
                longest = i;
            }
        }

        Console.WriteLine("Longest word: " + longest);
    }
}
