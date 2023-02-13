namespace BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new int[] { 7, 1, 5, 3, 6, 4 };
            var test2 = new int[] { 7, 6, 4, 3, 1 };

            new Solution().MaxProfit(test2);
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int buy  = prices[0];
            int sell = 0;
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (buy > prices[i])
                {
                    buy = prices[i];

                    continue;
                }

                sell = prices[i];

                if (sell > buy && maxProfit < sell - buy)
                {
                    maxProfit = sell - buy;
                }
            }

            return maxProfit;
        }
    }
}