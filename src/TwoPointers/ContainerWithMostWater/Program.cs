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
}