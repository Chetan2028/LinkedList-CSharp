using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApplication
{
    class LinkedList
    {
        public Node head;

        /// <summary>
        /// Adds the specified new data.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void Add(int newData)
        {
            Node newNode = new Node(newData);

            //If the linked list is empty , make the new node as head
            if (head == null)
            {
                head = new Node(newData);
                return;
            }

            newNode.next = null;

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
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
