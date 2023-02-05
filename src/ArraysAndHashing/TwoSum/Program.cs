using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new Solution().TwoSum(new int[] { 3, 2, 3 }, 6);

            Console.WriteLine(string.Format("First: {0} \r\nSecond: {1}", intArray[0], intArray[1]));
        }
    }

    public sealed class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (indices.ContainsKey(diff))
                {
                    return new int[] { indices[diff], i };
                }

                indices[nums[i]] = i;
            }

            return null;
        }
    }
}
