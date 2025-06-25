//Create a Stack which takes integer values and perform following 
//operations: 
//a.Push() - To Add new item in stack
//b.Pop() - To Remove item from the stack 
//c. Peek() – To Return the top item from the stack. 
//d. Contains() - To Checks whether an item exists in the stack or not. 
//e. Clear() - To clear items from stack
//using System;
//using System.Collections;
////using static System.Runtime.InteropServices.JavaScript.JSType;

using System;
using System.Collections;

class StackClass
{
    public  void stackmethod()
    {
        Stack stack = new Stack();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("1.Push\n2. Pop\n 3.Peek\n4.Contains\n 5.Clear\n6.Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Element: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    stack.Push(n1);
                    break;

                case 2:
                    Console.WriteLine("Removed Element: " + stack.Pop());
                    break;

                case 3:
                    Console.WriteLine("Peek: " + stack.Peek());
                    break;

                case 4:
                    Console.WriteLine("Enter an element: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Contains? " + stack.Contains(n));
                    break;

                case 5:
                    stack.Clear();
                    Console.WriteLine("cleared.");
                    break;

                case 6:
                    Console.WriteLine(" Exiting");
                    break;


            }
            Console.WriteLine();
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                int i = 0;
                foreach (int s1 in stack)
                {
                    Console.WriteLine($"{i}: {s1}");
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}



