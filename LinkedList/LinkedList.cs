using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;
        public void Append(int data)
        {
            Node node = new Node(data);
              if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
               
                temp.next = node;
                
            }

        }
      

        public void Display()
        {
            if(head==null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + "\t");
                    temp = temp.next;
                }
            }
        }
    }
}
