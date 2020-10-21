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

            linkedList.Add(30);
            linkedList.Display();


            Console.WriteLine("Size is " + linkedList.size());
            Console.WriteLine("Position of 30 is " + linkedList.getPosition(30));

            int position = linkedList.getPosition(30);
            linkedList.Insert(position + 1, 40);
            linkedList.Display();

            linkedList.removeAtCertainPosition(3);
            linkedList.Display();
            Console.WriteLine("Size is " + linkedList.size());


          
            linkedList.Display();
        }
    }
}
