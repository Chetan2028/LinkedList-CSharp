using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApplication
{
    public class LinkedList
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
        /// Searches the specified search key.
        /// </summary>
        /// <param name="searchKey">The search key.</param>
        /// <returns></returns>
        public int Search(int searchKey)
        {
            Node temp = head;
            int count = 1;
            while(temp != null)
            {
                if (temp.data == searchKey)
                {
                    return count;
                }
                count++;
                temp = temp.next;
            }
            return -1;
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
