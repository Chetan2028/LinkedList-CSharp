using System;

namespace LinkedListApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList linkedList = new LinkedList();
            linkedList.InsertNodeAtEnd(56);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(70);
            linkedList.Display();
            linkedList.PopLast();
            linkedList.Display();
        }
    }
}
