using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Demo Program");

            LinkedList linkedList = new LinkedList();
            linkedList.AddAtFirst(70);
            linkedList.AddAtFirst(30);
            linkedList.AddAtFirst(56);
            linkedList.Display();
        }
    }
}
