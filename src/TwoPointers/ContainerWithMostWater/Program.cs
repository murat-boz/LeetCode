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
            var test5 = new int[] { 1, 7, 2, 5, 4, 7, 3, 6 };

            Console.WriteLine(new Solution().MaxArea2(test5));
        }
    }
}