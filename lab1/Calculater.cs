////8.Write a program to create a Simple Calculator for two numbers (Addition, using System.Diagnostics;Multiplication, Subtraction, Division) [Also using if…else &Switch Case] 
////using System;

class Calculater
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char operation;


        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Choose an operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());


        if (operation == '+')
        {
            result = num1 + num2;
            Console.WriteLine("Result = " + result);
        }
        else if (operation == '-')
        {
            result = num1 - num2;
            Console.WriteLine("Result = " + result);
        }
        else if (operation == '*')
        {
            result = num1 * num2;
            Console.WriteLine("Result = " + result);
        }
        else if (operation == '/')
        {
            result = num1 / num2;
            Console.WriteLine("Result = " + result);
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }


    }
}


class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char operation;


        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());


        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result = " + result);
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine("Result = " + result);
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine("Result = " + result);
                break;

            case '/':
                result = num1 / num2;
                Console.WriteLine("Result=" + result);
                break;

            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}
