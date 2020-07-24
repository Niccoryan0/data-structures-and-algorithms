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

            listA.Append(29);
            listA.Append(13);

            listB.Append(1);
            listB.Append(34);

            LinkedList answer = Zip(listA, listB);

            string expected = "29 -> 1 -> 13 -> 34 -> NULL";

            Assert.Equal(expected, answer.ToString());
        }
        [Fact]
        public void CanHandleFirstListShorter()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Append(65);
            listA.Append(12);

            listB.Append(60);
            listB.Append(32);
            listB.Append(540);
            listB.Append(54);


            LinkedList answer = Zip(listA, listB);

            string expected = "65 -> 60 -> 12 -> 32 -> 540 -> 54 -> NULL";

            Assert.Equal(expected, answer.ToString());
        }
        [Fact]
        public void CanHandleSecondListShorter()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Append(50);
            listA.Append(15);
            listA.Append(5);
            listA.Append(99);
            listA.Append(20);


            listB.Append(10);
            listB.Append(1);

            LinkedList answer = Zip(listA, listB);

            string expected = "50 -> 10 -> 15 -> 1 -> 5 -> 99 -> 20 -> NULL";

            Assert.Equal(expected, answer.ToString());
        }

        [Fact]
        public void CanHandleEmptyList()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();
            LinkedList answer = Zip(listA, listB);

            string expected = "NULL";

            Assert.Equal(expected, answer.ToString());
        }

        [Fact]
        public void CanHandleFirstLinkedListAsEmpty()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listA.Append(23);
            listA.Append(12);
            listA.Append(100);

            LinkedList answer = Zip(listA, listB);

            string expected = "23 -> 12 -> 100 -> NULL";

            Assert.Equal(expected, answer.ToString());
        }

        [Fact]
        public void CanHandleSecondLinkedListAsEmpty()
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            listB.Append(23);
            listB.Append(12);
            listB.Append(100);

            LinkedList answer = Zip(listA, listB);

            string expected = "23 -> 12 -> 100 -> NULL";

            Assert.Equal(expected, answer.ToString());
        }

    }
}
