namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { -1, 0, 3, 5, 9, 12, 15 };
            int target1 = 9;

            int[] test2 = { -1, 0, 3, 5, 9, 12 };
            int target2 = 2;

            Console.WriteLine(new Solution().Search(test1, target1));
        }
    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int leftPointer  = 0;
            int rightPointer = nums.Length - 1;
            int currentIndex = -1;

            while (leftPointer <= rightPointer)
            {
                currentIndex = (rightPointer + leftPointer) / 2;

                if (nums[currentIndex] == target)
                {
                    return currentIndex;
                }
                else if (nums[currentIndex] < target)
                {
                    leftPointer = currentIndex + 1;
                }
                else if (nums[currentIndex] > target)
                {
                    rightPointer = currentIndex -1;
                }
            }

            return -1;
        }
    }
}