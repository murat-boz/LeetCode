namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var test2 = new int[] { 1, 1 };
            var test3 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 1 };
            var test4 = new int[] { 1, 8, 6, 2, 5, 4, 5, 3, 1 };

            Console.WriteLine(new Solution().MaxArea(test1));
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int leftPointer  = 0;
            int rightPointer = height.Length - 1;
            int maxArea      = 0;

            while (leftPointer <= rightPointer)
            {
                int xAxis = rightPointer - leftPointer;
                int yAxis = Math.Min(height[leftPointer], height[rightPointer]);

                int currentSquare = xAxis * yAxis;

                if (currentSquare >= maxArea)
                {
                    maxArea = currentSquare;
                }

                if (height[leftPointer] < height[rightPointer])
                {
                    leftPointer++;
                }
                else if (height[leftPointer] >= height[rightPointer])
                {
                    rightPointer--;
                }
            }

            return maxArea;
        }
    }
}