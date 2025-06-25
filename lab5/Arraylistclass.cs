
//1.Create an ArrayList for StudentName and perform following operations: 
//a.Add() - To Add new student in list
//b.Remove() - To Remove Student with specified index 
//c. RemoveRange() - To Remove student with specified range. 
//d. Clear() - To clear all the student from the list 
using System;
using System.Collections;
namespace lab5.lab5
{
    class ArrayListClass
    {
        public void arraylist()
        {
            ArrayList students = new ArrayList();
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("1.Add Student\n2.Remove\n3.Remove Range\n4.Clear\n5.Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Add student : ");
                        string name = Console.ReadLine();
                        students.Add(name);
                        Console.WriteLine("Student added.");
                        break;

                    case 2:
                        Console.Write("Enter index to remove: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        students.RemoveAt(index);
                        Console.WriteLine("Student removed.");

                        break;

                    case 3:
                        Console.Write("Enter starting index: ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number of students to remove: ");
                        int count = Convert.ToInt32(Console.ReadLine());
                        students.RemoveRange(start, count);

                        break;

                    case 4:
                        students.Clear();
                        Console.WriteLine("Removed.");
                        break;

                    case 5:
                        Console.WriteLine("Exit..");
                        break;


                }

                Console.WriteLine("\nStudent List:");
                if (students.Count == 0)
                {
                    Console.WriteLine("List is empty.");
                }
                else
                {
                    int i = 0;
                    foreach (string s in students)
                    {
                        Console.WriteLine(i + ": " + s);
                        i++;
                        
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

