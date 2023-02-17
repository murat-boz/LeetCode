namespace Search2DMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] 
            {
                new int[] { 1 , 3 , 5 , 7  },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 },
            };

            int target1 = 3;
            int target2 = 13;

            Console.WriteLine(new Solution().SearchMatrix(matrix, target1));
            Console.WriteLine(new Solution().SearchMatrix(matrix, target2));
        }
    }

    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var flatMatrix = matrix.SelectMany(x => x);

            return this.BinarySearch(flatMatrix.ToArray(), target) != -1;
        }

        private int BinarySearch(int[] array, int target)
        {
            int currentIndex = -1;
            int leftPointer  = 0;
            int rightPointer = array.Length - 1;

            while (leftPointer <= rightPointer)
            {
                currentIndex = leftPointer + ((rightPointer - leftPointer) / 2);

                if (array[currentIndex] == target)
                {
                    return currentIndex;
                }
                else if (array[currentIndex] > target)
                {
                    rightPointer = currentIndex - 1;
                }
                else if (array[currentIndex] < target)
                {
                    leftPointer = currentIndex + 1;
                }
            }

            return -1;
        }
    }
}