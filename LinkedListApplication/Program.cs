﻿using System;

namespace LinkedListApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList linkedList = new LinkedList();
            linkedList.InsertNodeAtEnd(56);
            linkedList.InsertNodeAtEnd(70);
            linkedList.Display();
            linkedList.InsertNodeAtGivenPosition(2, 30);
            linkedList.Display();
        }
    }
}
