//Create a Queue which takes integer values and perform following    
//operations:  
//a.Enqueue() - Adds an item into the queue. 
//b. Dequeue() - Returns an item from the beginning of the queue and  
//                          removes it from the queue. 
//c. Peek() - Returns an first item from the queue without removing it. 
//d. Contains() - Checks whether an item is in the queue or not 
//e. Clear() - Removes all the items from the queue 
using System;
using System.Collections;

class QueueClass
{
    public  void queuemethod()
    {
        Queue queue = new Queue();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("1.Enqueue\n2. Dequeue\n 3.Peek\n4.Contains\n 5.Clear\n6.Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter item to enqueue: ");
                    int item = Convert.ToInt32(Console.ReadLine());
                    queue.Enqueue(item);
                    break;

                case 2:
                    Console.WriteLine("Removed item: " + queue.Dequeue());
                    break;

                case 3:
                    Console.WriteLine("Peek: " + queue.Peek());
                    break;

                case 4:
                    Console.WriteLine("Enter an element: ");
                    int q1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Contains? " + queue.Contains(q1));
                    break;

                case 5:
                    queue.Clear();
                    Console.WriteLine("cleared.");
                    break;

                case 6:
                    Console.WriteLine(" Exiting");
                    break;


            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                int i = 0;
                foreach (int q in queue)
                {
                    Console.WriteLine($"{i}: {q}");
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}






