//5. Write a program to calculate area of Square, Rectangle and Circle. 

Console.WriteLine("enter length ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("area of square: " + l * l);
Console.WriteLine("enter width ");
int w = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("area of rectangle:" + l * w);
Console.WriteLine("enter a radius");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("area of circle:" +  3.14* r * r);
