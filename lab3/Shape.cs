
////7.Write a program to create interface named Shape.In this interface, we
////have three methods Circle(), Triangle() and Square() which calculates area 
////of Circle, Triangle and Square respectively. Implement Shape interface.

namespace lab3
{
    internal interface Shape
    {
        public void Circle(double radius);
        public void Triangle(double b, double h);
        public void Square(double side);

    }
    class CalculatArea : Shape
    {
        public void Circle(double radius)
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Arae of Circle:" + area);
        }
        public void Triangle(double b, double h)
        {
            double area = 0.5 * b * h;
            Console.WriteLine("Arae of Triangle:" + area);

        }
        public void Square(double side)
        {
            double area = side * side;
            Console.WriteLine("Area of Side:" + area);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            CalculatArea calculatArea = new CalculatArea();
            calculatArea.Circle(10);
            calculatArea.Triangle(2, 3);
            calculatArea.Square(10);
        }
    }
}

