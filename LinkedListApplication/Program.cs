using System;

namespace LinkedListApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList linkedList = new LinkedList();
            linkedList.InsertNodeAtBeginning(70);
            linkedList.InsertNodeAtBeginning(30);
            linkedList.InsertNodeAtBeginning(56);
            linkedList.Display();
        }
    }
}
