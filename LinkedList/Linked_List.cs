using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Linked_List
    {
        internal Node head;
        // Add to first.
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
        }

        // Displays this instance.
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty.");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
        }
    }
}
