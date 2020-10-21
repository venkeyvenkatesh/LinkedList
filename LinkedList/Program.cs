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



            Console.WriteLine("Position of 30 is "+linkedList.getPosition(30));

            Console.WriteLine("Position of 56 is " + linkedList.getPosition(56));

            Console.WriteLine("Position of 70 is " + linkedList.getPosition(70));

            Console.WriteLine("Position of 20 is " + linkedList.getPosition(20));




        }
    }
}
