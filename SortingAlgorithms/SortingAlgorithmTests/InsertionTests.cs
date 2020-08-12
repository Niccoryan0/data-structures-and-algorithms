using System;
using Xunit;
using static SortingAlgorithms.Insertion;

namespace InsertionSortingAlgorithmTests
{
    public class InsertionTests
    {
        [Fact]
        public void CanInsertionSortArray()
        {
            int[] arr = new int[] { 8, 4, 23, 43, 16, 15 };
            int[] expected = new int[] { 4, 8, 15, 16, 23, 43 };

            int[] result = InsertionSort(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanInsertionSortReversedArray()
        {
            int[] arr = new int[] { 20, 18, 12, 8, 5, -2 };
            int[] expected = new int[] { -2, 5, 8, 12, 18, 20 };

            int[] result = InsertionSort(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanInsertionSortFewUniquesArray()
        {
            int[] arr = new int[] { 5, 12, 7, 5, 5, 7 };
            int[] expected = new int[] { 5, 5, 5, 7, 7, 12 };

            int[] result = InsertionSort(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanInsertionSortNearlyInsertionSorted()
        {
            int[] arr = new int[] { 2, 3, 5, 7, 13, 11 };
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13 };

            int[] result = InsertionSort(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanHandleArrayLength1()
        {
            int[] arr = new int[] { 2 };
            int[] expected = new int[] { 2 };

            int[] result = InsertionSort(arr);

            Assert.Equal(expected, result);
        }

    }
}
