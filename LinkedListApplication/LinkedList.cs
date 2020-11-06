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
        /// Inorder to insert the node at a given position ,we need to traverse till position-1 node
        /// Inserts the node at given position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="newData">The new data.</param>
        public void InsertNodeAtGivenPosition(int position, int newData)
        {
            Node newNode = new Node(newData);
            int count = 1;
            Node previous = head;
            while (count < position - 1)
            {
                previous = previous.next;
                count++;
            }
            Node current = previous.next;
            newNode.next = current;
            previous.next = newNode;
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