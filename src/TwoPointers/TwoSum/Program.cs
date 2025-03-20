using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new Solution().TwoSum(new int[] { 3, 4, 5, 6, 7, 12 }, 11);

            Console.WriteLine(string.Format("First: {0} \r\nSecond: {1}", intArray[0], intArray[1]));
        }
    }

    public sealed class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int leftPointer = 0;
            int rightPointer = nums.Length - 1;

            while (leftPointer < rightPointer)
            {
                if (nums[leftPointer] + nums[rightPointer] > target)
                {
                    rightPointer--;
                }
                else if (nums[leftPointer] + nums[rightPointer] < target)
                {
                    leftPointer++;
                }
                else
                {
                    return new int[] { leftPointer + 1, rightPointer + 1 };
                }
            }

            return null;
        }
    }
}
