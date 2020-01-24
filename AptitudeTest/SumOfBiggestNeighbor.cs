using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AptitudeTest
{
    public class Solution
    {
        //time compexity is O(n)
        public int Challenge(int[] input)
        {
            if (input.Length == 2)
                return input[0] + input[1];

            var groupedInput = input.GroupBy(i => i).ToDictionary(x => x.Key, x => x.Count());
            int m = groupedInput.Values.Max();
            var filterdInput = groupedInput.Where(t => t.Value >= m - 1).Select(x => x.Key).ToArray();
            return largestNeighborSum(input.Where(i => filterdInput.Contains(i)).ToArray());
        }

        private int largestNeighborSum(int[] arr)
        {
            int largestSum = arr[0] + arr[1];
            for (int i = 2; i < arr.Length - 1; i++)
            {
                if (arr[i] + arr[i + 1] > largestSum)
                    largestSum = arr[i] + arr[i + 1];
            }
            return largestSum;
        }
    }
}
