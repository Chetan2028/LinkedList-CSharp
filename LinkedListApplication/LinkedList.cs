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
        /// Traverse till the last -1 node and make next of that node to null
        /// Pops the last.
        /// </summary>
        public void PopLast()
        {
            Node last = head;
            Node previousToLast = null;
            while (last.next != null)
            {
                previousToLast = last;
                last = last.next;
            }
            previousToLast.next = null;
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
