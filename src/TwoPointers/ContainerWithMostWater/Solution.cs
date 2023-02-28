namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int leftPointer = 0;
            int rightPointer = height.Length - 1;
            int maxArea = 0;

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
