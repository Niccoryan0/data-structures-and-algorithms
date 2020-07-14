using System;
using Xunit;
using LinkedListLibrary;
using System.Transactions;

namespace LinkedListsTests
{
    public class UnitTest1
    {
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
            list.InsertBefore(15, 30);

            string result = "16 -> 30 -> 15 -> 8 -> 4 -> NULL";

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
    }
}
