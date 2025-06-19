//2.Write a program using method overloading by changing number of     
//arguments to calculate area of square and rectangle. 

namespace lab4
{
    internal class Area
    {

        public int area(int side)
        {
            return side* side;
        }

        public int area(int l, int b)
        {
            return l * b;
        }
    }
}
