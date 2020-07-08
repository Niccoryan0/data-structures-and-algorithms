using System;
using Xunit;
using static BinarySearch.Program;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 15, 2)]

        public void CanFindValue(int[] arr, int key, int expected)
        {
            int result = BinarySearcher(arr, key);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnNeg1ForInvalidVals()
        {
            int[] arr = new int[] { 11, 22, 33, 44, 55, 66, 77 };
            int key = 90;
            int result = BinarySearcher(arr, key);
            Assert.Equal(-1, result);
        }
    }
}
