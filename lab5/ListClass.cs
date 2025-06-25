
//2.Create a List for StudentName and perform following operations: 
//a.Add() - To Add new student in list
//b.Remove() - To Remove Student with specified index 
//c. RemoveRange() - To Remove student with specified range. 
//d. Clear() - To clear all the student from the list



using System;
using System.Collections;

class ListClass
{
    public  void listtmethod()
    {
        List<string> student = new List<string>();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n1. Add Student\n2. Remove by Index\n3. Remove Range\n4. Clear List\n5. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write(" Add Student: ");
                    string name = Console.ReadLine();
                    student.Add(name);
                    Console.WriteLine("Student added.");
                    break;

                case 2:
                    Console.Write("Enter index to remove: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    student.RemoveAt(index);
                    Console.WriteLine("Student removed.");

                    break;

                case 3:
                    Console.Write("Enter starting index: ");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number of students to remove: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    student.RemoveRange(start, count);
                    Console.WriteLine("Students removed.");

                    break;

                case 4:
                    student.Clear();
                    Console.WriteLine("All students removed.");
                    break;

                case 5:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }


            Console.WriteLine("\nStudent List:");
            if (student.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                int i = 0;
                foreach (string s in student)
                {
                    Console.WriteLine(i + ": " + s);
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}


























