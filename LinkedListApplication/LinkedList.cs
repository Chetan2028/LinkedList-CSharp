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
        /// Deletes a given node.
        /// </summary>
        /// <param name="key">The key.</param>
        public void DeleteAGivenNode(int key)
        {
            int searchResult = Search(key);
            if (searchResult == -1)
            {
                Console.WriteLine("No element found to delete");
            }
            else
            {
                Node temp = head;
                Node previous = null;

                //If the head node needs to be deleted , then change the head
                if (temp != null && temp.data == key)
                {
                    head = temp.next;
                    return;
                }
                //traversing till the previous node of the node to be deleted.
                while (temp.data != key)
                {
                    previous = temp;
                    temp = temp.next;
                }
                previous.next = temp.next;
            }
        }
        /// <summary>
        /// Sizes the of linked list.
        /// </summary>
        public int SizeOfLinkedList()
        {
            int count = 1;
            Node temp = head;
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("No of elements in a linked list is : {0}", count);
            return count;
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
        
        //Sort the linked list
        public void SortLinkedList()
        {
            Node current = head;
            Node index = null;
            int temp;

            if (head == null)
            {
                return;
            }

            while (current != null)
            {
                //Node index will point to node next to current
                index = current.next;

                while (index != null)
                {
                    //If current's data is greater than index's node data ,swap the data between them
                    if (current.data > index.data)
                    {
                        temp = current.data;
                        current.data = index.data;
                        index.data = temp;
                    }
                    index = index.next;
                }
                current = current.next;
            }
        }
    }
}
