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
                head = newNode;
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
        /// <param name="key">The search key.</param>
        /// <returns></returns>
        public int Search(int key)
        {
            Node temp = head;
            int count = 1;
            while (temp != null)
            {
                if (temp.data == key)
                {
                    return count;
                }
                count++;
                temp = temp.next;
            }
            return -1;
        }

        /// <summary>
        /// Inserts the after.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="newData">The new data.</param>
        public void InsertAfter(int key, int newData)
        {
            int searchValue = Search(key);
            if (searchValue == -1)
            {
                Console.WriteLine("No such element {0} found ", key);
            }
            else
            {
                Node newNode = new Node(newData);
                Node previous = head;
                for (int index = 1; index < searchValue; index++)
                {
                    previous = previous.next;
                }
                newNode.next = previous.next;
                previous.next = newNode;
            }
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
