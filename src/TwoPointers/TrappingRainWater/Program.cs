// See https://aka.ms/new-console-template for more information

int[] test = new int[] { 0, 2, 0, 3, 1, 0, 1, 3, 2, 1 };
int[] test2 = new int[] { 4, 2, 0, 3, 2, 5 };
int[] test3 = new int[] { 4, 2, 3 };

Console.WriteLine(new Solution().Trap(test));

public class Solution
{
    public int Trap(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;

        int maxL = height[0];
        int maxR = height[height.Length - 1];
        int area = 0;

        while (leftPointer < rightPointer)
        {
            if (maxL <= maxR)
            {
                var leftTemp = Math.Min(maxR, maxL) - height[leftPointer];

                if (leftTemp > 0)
                {
                    area += leftTemp;
                }

                leftPointer++;

                maxL = Math.Max(maxL, height[leftPointer]);
            }
            else
            {
                var rightTemp = Math.Min(maxR, maxL) - height[rightPointer];

                if (rightTemp > 0)
                {
                    area += rightTemp;
                }

                rightPointer--;

                maxR = Math.Max(maxR, height[rightPointer]);
            }
        }

        return area;
    }
}