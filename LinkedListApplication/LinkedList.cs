using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApplication
{
    class LinkedList
    {
        public Node head;

        /// <summary>
        /// Inserts the node at end.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void InsertNodeAtEnd(int newData)
        {
            Node newNode = new Node(newData);

            if (head == null)
            {
                head = new Node(newData);
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            newNode.next = null;
            temp.next = newNode;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("No elements to pop");
                return;
            }
            Node temp = head;
            Console.WriteLine("{0} element is popped", temp.data);
            head = head.next;
            temp.next = null;
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
    }
}
