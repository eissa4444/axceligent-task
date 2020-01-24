using AptitudeTest;
using System;
using Xunit;

namespace Aptitude.UnitTesting
{
    public class UnitTesting
    {
        private Solution solution;
        public UnitTesting()
        {
            solution = new Solution();
        }
        

        [Theory()]
        [InlineData(new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 }, 10)]
        [InlineData(new int[] { 1, 6, 1, 2, 6, 1, 6, 6 }, 12)]
        public void Challenge_WhenCalledWithIntArray_SholdReturnSumOfBiggestNeighbor(int[] input, int expectedCount)
        {
            Assert.Equal(expectedCount, solution.Challenge(input));
        }
    }
}
