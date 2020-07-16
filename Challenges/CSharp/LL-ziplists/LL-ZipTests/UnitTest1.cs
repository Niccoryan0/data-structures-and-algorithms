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

            string expected = "29 -> 1 -> 13 -> 34 -> NULL";

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
            listB.Insert(60);


            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "12 -> 54 -> 65 -> 540 -> 32 -> NULL";

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

            string expected = "5 -> 1 -> 15 -> 10 -> 50 -> NULL";

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

            string expected = "23 -> 12 -> 100 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }

        [Fact]
        public void CanHandleSecondLinkedListAsEmpty()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listB.Insert(100);
            listB.Insert(12);
            listB.Insert(23);

            Node answer = Zip(listA, listB);

            LinkedList linkedListResult = new LinkedList();
            linkedListResult.Head = answer;

            string expected = "23 -> 12 -> 100 -> NULL";

            Assert.Equal(expected, linkedListResult.ToString());
        }

    }
}
