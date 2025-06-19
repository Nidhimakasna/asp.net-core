
//5.Write a programs to Find Area of Square, Rectangle and Circle using
//Method Overloading. 
namespace lab4.lab4
{
    internal class FindArea
    {
        public int Farea(int side)
        {
            return side * side;
        }

        public int Farea(int l1, int b1)
        {
            return l1 * b1;
        }
        public double Farea(double radius)
        {
            return 3.14* radius * radius;
        }

    }
}
