
//8.Write a program to Define a class Distance have data members dist1, dist2,
//dist3. Initialize the two data members using constructor and store their 
//addition in third data member using function and display addition. 

namespace practical.lab2
{
    internal class Distance
    {
        public double dis1;
        public double dis2;
        public double dis3;
        public Distance(double d1,double d2)
        {
            dis1 = d1;
            dis2= d2;
            dis3 = 0;
            
        }
        public void AddDistance() { 
            dis3= dis1 + dis2;
        }

        public void DisplayDistance()
        {
            Console.WriteLine("Distance 1: " + dis1);
            Console.WriteLine("Distance 2: " + dis2);
            Console.WriteLine("Total Distance: " + dis3);
        }
    }
}
