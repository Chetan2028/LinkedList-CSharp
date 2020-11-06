using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApplication
{
    class LinkedList
    {
        public Node head;

        /// <summary>
        /// Inserts the node at beginning.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void InsertNodeAtBeginning(int newData)
        {
            Node newNode = new Node(newData);

            if (head == null)
            {
                head = new Node(newData);
                return;
            }
            
            newNode.next = head;
            head = newNode;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
    }
}
