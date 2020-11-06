using System;

namespace LinkedListApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList linkedList = new LinkedList();
            linkedList.InsertNodeAtEnd(56);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(70);
            linkedList.Display();
            int searchResult = linkedList.Search(70);
            if (searchResult != -1)
            {
                Console.WriteLine("Element is present at index : {0}" , searchResult);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            
        }
    }
}
