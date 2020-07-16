using System;
using Xunit;
using static LL_ziplists.Program;
using LinkedListLibrary;


namespace LL_ZipTests
{
    public class UnitTest1
    {

        [Fact]
        public void HappyPathSuccessful()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Insert(13);
            listA.Insert(29);

            listB.Insert(34);
            listB.Insert(1);

            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "13 -> 34 -> 29 -> 1 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }
        [Fact]
        public void CanHandleFirstListShorter()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Insert(12);
            listA.Insert(65);

            listB.Insert(54);
            listB.Insert(540);
            listB.Insert(32);


            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "54 -> 12 -> 540 -> 65 -> 32 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }
        [Fact]
        public void CanHandleSecondListShorter()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Insert(5);
            listA.Insert(15);
            listA.Insert(50);

            listB.Insert(1);
            listB.Insert(10);

            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "5 -> 15 -> 1 -> 50 -> 10 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }

        [Fact]
        public void CanHandleEmptyList()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();
            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }

        [Fact]
        public void CanHandleFirstLinkedListAsEmpty()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Insert(100);
            listA.Insert(12);
            listA.Insert(23);

            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "100 -> 12 -> 23 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }

        [Fact]
        public void CanHandleSecondLinkedListAsEmpty()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Insert(100);
            listA.Insert(12);
            listA.Insert(23);

            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "100 -> 12 -> 23 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }

    }
}
