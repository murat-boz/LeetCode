using System;
using System.Collections.Generic;

namespace TopKFrequentElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 1, 1, 2, 2, 4 };
            int k1 = 2;

            int[] array2 = new int[] { 1 };
            int k2 = 1;

            int[] array3 = new int[] { 1, 2 };
            int k3 = 2;

            new Solution().TopKFrequent(array3, k3);

            Console.WriteLine("Hello World!");
        }
    }

    public sealed class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> hashValues = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!hashValues.ContainsKey(num))
                {
                    hashValues[num] = 1;
                }
                else
                {
                    hashValues[num]++;
                }
            }

            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));

            foreach (var hasValue in hashValues)
            {
                pq.Enqueue(hasValue.Key, hasValue.Value);
            }

            int[] topFrequents = new int[k];

            for (int i = 0; i < k; i++)
            {
                topFrequents[i] = pq.Dequeue();
            }

            return topFrequents;
        }

        //Using MinHeap
        public int[] TopKFrequent2(int[] nums, int k)
        {
            var pq = new PriorityQueue<int, int>();
            var map = new Dictionary<int, int>();
            foreach (var n in nums) //O(N)
            {
                if (map.ContainsKey(n))
                    map[n]++;
                else
                    map[n] = 1;
            }

            foreach (var pair in map) //O(K * Log K) + O((N - K) Log K) = O(N * LogK), when k == n
            {
                pq.Enqueue(pair.Key, pair.Value);
                if (pq.Count > k)
                    pq.Dequeue();
            }

            var res = new int[k];
            for (int i = 0; i < k; i++) //O(K * Log K)
                res[i] = pq.Dequeue();

            return res;
        }

        //Using MaxHeap
        public int[] TopKFrequent3(int[] nums, int k)
        {
            var pq = new PriorityQueue<int, int>(new ByWeight());
            var map = new Dictionary<int, int>();
            foreach (var n in nums) //O(N)
            {
                if (map.ContainsKey(n))
                    map[n]++;
                else
                    map[n] = 1;
            }

            foreach (var pair in map) //O(N * Log N)
                pq.Enqueue(pair.Key, pair.Value);

            var res = new int[k];
            for (int i = 0; i < k; i++) //O(K * Log N)
                res[i] = pq.Dequeue();

            return res;
        }

        private class ByWeight : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
