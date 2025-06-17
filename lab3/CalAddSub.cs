////4.Write a program to create interface Calculate. In this interface we have two 
////member functions Addition() and Subtraction(). Implements this interface
////in another class named Result.

namespace lab3
{
    interface CalAddSub
    {
        public void Addition(int a, int b);
        public void Subtraction(int a, int b);
    }

    class Result : CalAddSub
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Adiition:" + (a + b));
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine("Subtarction:" + (a - b));

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Result result = new Result();
            result.Addition(5, 3);
            result.Subtraction(6, 4);
        }
    }
}
