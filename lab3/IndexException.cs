////2.Write a program that reads 5 numbers from user. Demonstrate concept of 
////IndexOutOfRange Exception.

int[] arr = new int[5];
try
{
    for (int i = 0; i <= 5; i++)
    {
        Console.WriteLine("enter a elements");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e);
}