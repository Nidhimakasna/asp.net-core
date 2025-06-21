////6.Write a program to calculate Celsius to Fahrenheit and vice-versa using function. 
////using System;

class FerCel
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = CelsiusToFahrenheit(celsius);

        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }
}


class FerCel
{

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = FahrenheitToCelsius(fahrenheit);

        Console.WriteLine("Celsius = " + celsius);
    }
}

