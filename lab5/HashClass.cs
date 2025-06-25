//Create a Hashtable collection class object and preform following 
//operations: 
//a.Add: Adds a key-value pair. 
//b. Remove: Removes a key-value pair by key. 
//c. ContainsKey: Checks if a key exists in the hashtable. 
//d. ContainsValue: Checks if a value exists in the hashtable. 
//e. Clear: Removes all key-value pairs.
using System;

using System.Collections;

namespace lab5.lab5
{
    internal class HashClass
    {
        public  void hashmethod()
        {
            Hashtable ht = new Hashtable();
            int c = 0;
            while (c != 6)
            {
                Console.WriteLine("1.Add\n2.Remove\n3.ContainsKey\n4.ContainsValue\n5.Clear\n6.Exit");
                Console.WriteLine("Enter a choice");
                 c= Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.Write("Enter key: ");
                        string key1 = (Console.ReadLine());
                        Console.Write("Enter value: ");
                        string value1 = Console.ReadLine();
                        ht.Add(key1, value1);
                        Console.WriteLine("Key-value pair added.");
                        break;
                    case 2:
                        Console.Write("Enter key to remove: ");
                        string removeKey = Console.ReadLine();
                        ht.Remove(removeKey);
                        break;

                    case 3:
                        Console.Write("Enter key to check: ");
                        string checkKey = Console.ReadLine();
                        Console.WriteLine(ht.ContainsKey(checkKey));

                        break;

                    case 4:
                        Console.Write("Enter value to check: ");
                        string checkValue = Console.ReadLine();
                        Console.WriteLine(ht.ContainsValue(checkValue));

                        break;

                    case 5:
                        ht.Clear();
                        Console.WriteLine("cleared");
                        break;

                    case 6:
                        Console.WriteLine("Exit");
                        break;

                }
                Console.WriteLine();
                if (ht.Count == 0)
                {
                    Console.WriteLine("Hashtable is empty.");
                }
                else
                {
                    foreach (DictionaryEntry res in ht)
                    {
                        Console.WriteLine($"Key: {res.Key}, Value: {res.Value}");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}

        
    


