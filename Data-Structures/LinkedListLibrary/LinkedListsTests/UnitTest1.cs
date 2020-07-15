using System;
using Xunit;
using LinkedListLibrary;
using System.Transactions;

namespace LinkedListsTests
{
    public class UnitTest1
    {

        [Fact]
        public void CanCountNodes()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            int result = list.CountNodes();
            Assert.Equal(6, result);
        }


        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            Assert.Equal(42, list.Head.Value);
        }

        [Fact]
        public void CanFindValueInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            int key = 15;
            bool exists = list.Includes(key);

            Assert.True(exists);
        }

        [Fact]
        public void CannotFindValueInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            int key = 21;
            bool exists = list.Includes(key);

            Assert.False(exists);
        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            string result = list.ToString();

            string expected = "15 -> 8 -> 4 -> NULL";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanAppendNode()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Append(20);
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
            }
            Assert.Equal(20, list.Current.Value);
        }

        [Fact]
        public void CanAppendMultipleNodes()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Append(20);
            list.Append(98);
            list.Append(3);
            string result = "16 -> 15 -> 8 -> 4 -> 20 -> 98 -> 3 -> NULL";
            Assert.Equal(result, list.ToString());
        }

        [Fact]
        public void CanInsertNodeBefore()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.InsertBefore(8, 30);

            string result = "16 -> 15 -> 30 -> 8 -> 4 -> NULL";

            Assert.Equal(result, list.ToString());
        }
        [Fact]
        public void CanInsertNodeAfter()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.InsertAfter(15, 30);
            string result = "16 -> 15 -> 30 -> 8 -> 4 -> NULL";

            Assert.Equal(result, list.ToString());
        }

        [Fact]
        public void CanSuccessfullyInsertANodeBeforeTheFirstNode()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.InsertBefore(42, 5);
            string expected = "5 -> 42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";
            Assert.Equal(expected, list.ToString());

        }

        [Fact]
        public void CanSuccessfullyInsertAfterANodeInMiddle()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.InsertAfter(16, 5);
            string expected = "42 -> 23 -> 16 -> 5 -> 15 -> 8 -> 4 -> NULL";
            Assert.Equal(expected, list.ToString());

        }

        [Fact]
        public void CanSuccessfullyInsertANodeAfterTheLast()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.InsertAfter(4, 5);
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 5 -> NULL";
            Assert.Equal(expected, list.ToString());
        }

        [Fact]
        public void CanReturnKthFromEndHappyPath()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            int result = list.KthFromEnd(3);
            Assert.Equal(16, result);
        }

        [Fact]
        public void CanReturnExceptionKGreaterThanListLength()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            var ex = Assert.Throws<Exception>(() => list.KthFromEnd(5));
            Assert.Equal("Invalid K", ex.Message);
        }

        [Fact]
        public void CanReturnExceptionKEqualToListLength()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            var ex = Assert.Throws<Exception>(() => list.KthFromEnd(4));
            Assert.Equal("Invalid K", ex.Message);
        }

        [Fact]
        public void ThrowForNegativeK()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            var ex = Assert.Throws<Exception>(() => list.KthFromEnd(-1));
            Assert.Equal("K is negative", ex.Message);
        }
        [Fact]
        public void CanHandleLinkedListSizeOneHappyPath()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            int result = list.KthFromEnd(0);
            Assert.Equal(4, result);
        }
    }
}
