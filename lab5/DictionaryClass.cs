//Create a Dictionary collection class object and preform following 
//operations: 
//a.Add: Adds a key-value pair. 
//b. Remove: Removes a key-value pair by key. 
//c. ContainsKey: Checks if a key exists in the hashtable. 
//d. ContainsValue: Checks if a value exists in the hashtable. 
//e. Clear: Removes all key-value pairs. 

using System;
using  System.Collections;

class DictionaryClass
{
    public  void Dictionarymethod()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("1.Add\n2.Remove\n3.ContainsKey\n4.ContainsValue\n5.Clear\n6.Exit");


            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter key: ");
                    string key = (Console.ReadLine());
                    Console.Write("Enter value: ");
                    string value = Console.ReadLine();
                    dic.Add(key, value);
                    Console.WriteLine("Key-value pair added.");
                    break;

                case 2:
                    Console.Write("Enter key to remove: ");
                    string removeKey = Console.ReadLine();
                    dic.Remove(removeKey);
                    break;

                case 3:
                    Console.Write("Enter key to check: ");
                    string checkKey = Console.ReadLine();
                    Console.WriteLine(dic.ContainsKey(checkKey));

                    break;

                case 4:
                    Console.Write("Enter value to check: ");
                    string checkValue = Console.ReadLine();
                    Console.WriteLine(dic.ContainsValue(checkValue));

                    break;

                case 5:
                    dic.Clear();
                    Console.WriteLine("cleared");
                    break;

                case 6:
                    Console.WriteLine("Exit");
                    break;


            }

            Console.WriteLine();
            if (dic.Count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
            }
            else
            {
                foreach (var pair in dic)
                {
                    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
                }
                Console.WriteLine();
            }
        }
    }
}
