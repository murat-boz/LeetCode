namespace FindMinimumInRotatedSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int[] test2 = new int[] { 3, 4, 5, 1, 2 };
            int[] test3 = new int[] { 11, 13, 15, 17 };
            int[] test4 = new int[] { 2, 1 };
            int[] test5 = new int[] { 3, 1, 2 };
            int[] test6 = new int[] { 3, 4, 5, 1, 2 };

            Console.WriteLine(new Solution().FindMin(test1));
            Console.WriteLine(new Solution().FindMin(test2));
            Console.WriteLine(new Solution().FindMin(test3));
            Console.WriteLine(new Solution().FindMin(test4));
            Console.WriteLine(new Solution().FindMin(test5));
            Console.WriteLine(new Solution().FindMin(test6));
        }
    }

    public class Solution
    {
        public int FindMin(int[] nums)
        {
            int leftPointer  = 0;
            int rightPointer = nums.Length - 1;

            while (leftPointer <= rightPointer)
            {
                if (nums[leftPointer] <= nums[rightPointer])
                {
                    return nums[leftPointer];
                }

                int midPointer = (rightPointer + leftPointer) / 2;

                if (nums[midPointer] >= nums[leftPointer])
                {
                    leftPointer = midPointer + 1;
                }
                else
                {
                    rightPointer = midPointer;
                }
            }

            return 0;
        }
    }
}