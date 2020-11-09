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
        public void GivenElementToInsertAtSpecifiedPosition_HappyCase()
        {
            linkedList.InsertNodeAtEnd(10);
            linkedList.InsertNodeAtEnd(20);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(40);
            linkedList.InsertAfter(20, 100);

            int actual = linkedList.Search(100);

            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenElementToInsertAtSpecifiefPosition_SadCase()
        {
            linkedList.InsertNodeAtEnd(10);
            linkedList.InsertNodeAtEnd(20);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(40);
            linkedList.InsertAfter(40, 100);

            int actual = linkedList.Search(100);

            int expected = 3;

            Assert.AreNotEqual(expected, actual);
        }

    }
}
