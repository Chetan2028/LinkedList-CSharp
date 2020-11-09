using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTesting
{
    [TestClass]
    public class LinkedListUnitTest
    {
        private readonly LinkedListApplication.LinkedList linkedList;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListUnitTest"/> class.
        /// </summary>
        public LinkedListUnitTest()
        {
            linkedList = new LinkedListApplication.LinkedList();
        }

        [TestMethod]
        public void CheckForSizeOfLinkedList_HappyCase()
        {
            linkedList.InsertNodeAtEnd(10);
            linkedList.InsertNodeAtEnd(20);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(40);
            int actual = linkedList.SizeOfLinkedList();
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckForSizeOfLinkedList_SadCase()
        {
            linkedList.InsertNodeAtEnd(10);
            linkedList.InsertNodeAtEnd(20);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(40);
            int actual = linkedList.SizeOfLinkedList();
            int expected = 2;
            Assert.AreNotEqual(expected, actual);
        }
    }
}
