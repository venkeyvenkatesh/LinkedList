using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;

            }

        }
        public void Insert(int pos, int Data)
        {
            if (pos < 1)
            {
                Console.WriteLine("Invalid position");

            }
            else
            {
                if (pos == 1)
                {
                    Node node = new Node(Data);

                    node.next = head;
                    head = node;

                }
                else
                {

                    Node node = new Node(Data);
                    Node temp = head;
                    for (int i = 2; i < pos; i++)
                    {
                        temp = temp.next;
                    }

                    node.next = temp.next;
                    temp.next = node;

                }
            }
        }
        public void removetFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is  empty");
            }
            else
            {
                Console.WriteLine(head.data + " is removed from the list");
                head = head.next;
            }
        }

        public void removeAtLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is  empty");
            }
            else
            {
                Node temp = head;
                Node prev = null; ;
                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                }
                Console.WriteLine(temp.data + " is rmoved from the list");
                prev.next = null;
            }
        }

        public void removeAtCertainPosition(int pos)
        {
            if (pos < 1)
            {
                Console.WriteLine("Invalid position");

            }
            else
            {
                if (pos == 1)
                {
                    // Node node = new Node(Data);

                    // node.next = head;
                    //  head = node;

                    head = head.next;

                }
                else
                {

                    //  Node node = new Node(Data);
                    Node temp = head;
                    Node prev = null;
                    for (int i = 2; i <= pos; i++)
                    {
                        prev = temp;
                        temp = temp.next;
                    }

                    prev.next = temp.next;

                }
            }
        }
        public int getPosition(int data)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return 0;

            }
            else
            {
                int pos = 0;
                Node temp = head;
                while (temp != null)
                {
                    pos++;
                    if (temp.data == data)
                    {
                        return pos;
                    }
                    temp = temp.next;

                }
                if (temp == null)
                {
                    Console.WriteLine("Element not found");

                }
                return 0;
            }
        }

        public void Display()
        {
            if (head == null)
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
            Console.WriteLine();
        }

        public int size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }


        public Node Sort(Node head)
        {


            if (head == null || head.next == null)
            {
                return head;
            }

            Node temp = head;

            Node slow = head;

            Node fast = head;

            while (fast != null && fast.next != null)
            {
                temp = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            temp.next = null;


            Node leftSide = Sort(head);
            Node rightSide = Sort(slow);


            return Merge(leftSide, rightSide);
        }

        internal Node Merge(Node l1, Node l2)
        {
            Node sorted_temp = new Node();
            Node current_node = sorted_temp;

            while (l1 != null && l2 != null)
            {
                if (l1.data < l2.data)
                {
                    current_node.next = l1;

                    l1 = l1.next;
                }
                else
                {
                    current_node.next = l2;

                    l2 = l2.next;
                }
                current_node = current_node.next;
            }

            if (l1 != null)
            {
                current_node.next = l1;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                current_node.next = l2;
                l2 = l2.next;
            }

            return sorted_temp.next;
        }

    }
}
