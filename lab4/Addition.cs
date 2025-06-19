//1.Write a program using method overloading by changing datatype of    
//arguments to perform addition of two integer numbers and two float     
//numbers.
namespace lab4.lab4
{
    internal class Addition
    {
        public int Add(int no1,int no2)
        {
            return no1+ no2;
        }
        public float Add(float f1,float f2) {
            return f1 + f2; 
        }
    }
}
