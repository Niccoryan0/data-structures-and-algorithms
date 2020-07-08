using System;
using Xunit;
using static ArrayShift.Program;

namespace ArrayShiftTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8 }, 5, new int[] { 2, 4, 5, 6, 8 })]
        [InlineData(new int[] { 4, 8, 15, 23, 42 }, 16, new int[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[] {  }, 5, new int[] { 5 })]
        [InlineData(new int[] { 4 }, 6, new int[] { 4, 6 })]
        public void ArrayShiftTest(int[] testArr, int testNum, int[] expected)
        {
            int[] result = InsertShiftArray(testArr, testNum);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 4, 4, 1 }, 8, new int[] { 1, 3, 8, 4, 4, 1 })]
        [InlineData(new int[] {  }, 16, new int[] {  })]
        public void ArrayShiftTestFail(int[] testArr, int testNum, int[] expected)
        {
            int[] result = InsertShiftArray(testArr, testNum);
            Assert.NotEqual(expected, result);
        }
    }
}
