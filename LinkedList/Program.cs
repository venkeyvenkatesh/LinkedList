using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Demo Program");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
           
            linkedList.Add(70);
            linkedList.Display();

            linkedList.Insert(2, 30);
            linkedList.Display();

            
        }
    }
}
