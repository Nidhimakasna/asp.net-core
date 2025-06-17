
//5.Write a program to calculate area of a Rectangle using constructor. 

namespace practical.lab2
{
    internal class Rectangle
    {
        public double Length;
        public double Width;
        public double area;
        public Rectangle(double length, double width)
        {
               Length= length;
               Width= width;

        }
        public void DisplayArea()
        {
            Console.WriteLine($"area of rectangle:{Length*Width}");
        }
    }
}
