using lab5.lab5;
using System;
using System.Collections;
namespace lab5.lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 For Program Arraylist");
            Console.WriteLine("2 For Program List");
            Console.WriteLine("3 For Program Stack");
            Console.WriteLine("4 For Program Queue");
            Console.WriteLine("5 For Program Hash");
            Console.WriteLine("6 For Program Dictionary");


            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    ArrayListClass arrayListClass = new ArrayListClass();
                    arrayListClass.arraylist();
                    break;
                case 2:
                    ListClass listClass = new ListClass();
                    listClass.listtmethod();
                    break;
                case 3:
                    StackClass stackClass = new StackClass();
                    stackClass.stackmethod();
                    break;
                case 4:
                    QueueClass queueClass = new QueueClass();
                    queueClass.queuemethod();
                    break;
                    
                case 5:
                    HashClass hashClass=new HashClass();
                    hashClass.hashmethod();
                    break;
                case 6:
                    DictionaryClass dictionaryClass=new DictionaryClass();
                    dictionaryClass.Dictionarymethod();
                    break;


            }


        }
    }
}
