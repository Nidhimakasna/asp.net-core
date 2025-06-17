//3.Write a program to create an abstract class Sum having abstract methods
//SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c). Create another
//class Calculate which extends the abstract class and implements the
//abstract methods. 

namespace lab3
{
    internal abstract class SumOfNumber
    {
        public abstract void SumOfTwo(int a, int b);
        public abstract void SumOfThree(int x, int y, int z);

    }

    class Calculate : SumOfNumber
    {
        public override void SumOfTwo(int a, int b)
        {
            Console.WriteLine("sum of two number:" + (a + b));
        }
        public override void SumOfThree(int x, int y, int z)
        {
            Console.WriteLine("sum of three number:" + (x + y + z));
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            Console.WriteLine("enter a 1 num");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a 2 num");
            int b = Convert.ToInt32(Console.ReadLine());
            calculate.SumOfTwo(a, b);
            Console.WriteLine("enter a 1 num");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a 2 num");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a 3 num");
            int z = Convert.ToInt32(Console.ReadLine());
            calculate.SumOfThree(x, y, z);
        }
    }

}