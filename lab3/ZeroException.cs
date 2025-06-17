
//1. Write a program to Create a divide by zero exception and handle it. 

int n = 10;
int d = 0;
try
{
    d = n / 0;
}
catch (Exception e)
{
    Console.WriteLine("DivideByZeroException");
}
Console.WriteLine("Result is " + d);

