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

        /// <summary>
        /// Givens the existing element to search should return index of that element.
        /// </summary>
        [TestMethod]
        public void GivenExistingElementToSearch_ShouldReturnIndexOfThatElement_HappyCase()
        {
            //Arrange
            int expected = 3;

            //Act
            linkedList.InsertNodeAtEnd(56);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(70);
            int actual = linkedList.Search(70);

            //Assert
            Assert.AreEqual(expected, actual);
        }        
        [TestMethod]
        public void GivenExistingElementToSearch_ShouldReturnIndexOfThatElement_SadCase()
        {
            //Arrange
            int expected = 1;

            //Act
            linkedList.InsertNodeAtEnd(56);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(70);
            int actual = linkedList.Search(70);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        /// <summary>
        /// Givens the non existing element to search should return negative number.
        /// </summary>
        [TestMethod]
        public void GivenNonExistingElementToSearch_ShouldReturnNegativeNumber()
        {
            //Arrange
            int expected = -1;

            //Act
            linkedList.InsertNodeAtEnd(56);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(70);
            int actual = linkedList.Search(90);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
