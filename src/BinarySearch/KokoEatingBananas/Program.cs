using BenchmarkDotNet.Running;

namespace KokoEatingBananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Bency>();
        }
    }

    public class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int leftPoiner  = 1;
            int rightPoiner = piles.Max();
            int minValue    = rightPoiner;

            while (leftPoiner <= rightPoiner)
            {
                int midPointer = leftPoiner + (rightPoiner - leftPoiner) / 2;
                long midHour   = 0;

                for (int i = 0; i < piles.Length; i++)
                {
                    midHour = midHour + (int)Math.Ceiling((decimal)piles[i] / midPointer);
                }

                if (h >= midHour)
                {
                    rightPoiner = midPointer - 1;

                    minValue = midPointer;
                }
                else
                {
                    leftPoiner = midPointer + 1;
                }
            }

            return minValue;
        }

        public int MinEatingSpeed2(int[] piles, int h)
        {
            int leftPoiner = 1;
            int rightPoiner = piles.Max();
            int minValue = rightPoiner;

            while (leftPoiner <= rightPoiner)
            {
                int midPointer = leftPoiner + (rightPoiner - leftPoiner) / 2;
                long midHour = 0;

                for (int i = 0; i < piles.Length; i++)
                {
                    midHour = midHour + (int)Math.Ceiling(piles[i] / (double)midPointer);
                }

                if (h >= midHour)
                {
                    rightPoiner = midPointer - 1;

                    minValue = midPointer;
                }
                else
                {
                    leftPoiner = midPointer + 1;
                }
            }

            return minValue;
        }

        public int MinEatingSpeed3(int[] piles, int h)
        {
            int leftPoiner = 1;
            int rightPoiner = piles.Max();
            int minValue = rightPoiner;

            while (leftPoiner <= rightPoiner)
            {
                int midPointer = leftPoiner + (rightPoiner - leftPoiner) / 2;
                long midHour = 0;

                for (int i = 0; i < piles.Length; i++)
                {
                    midHour = midHour + (int)Math.Ceiling((double)piles[i] / (double)midPointer);
                }

                if (h >= midHour)
                {
                    rightPoiner = midPointer - 1;

                    minValue = midPointer;
                }
                else
                {
                    leftPoiner = midPointer + 1;
                }
            }

            return minValue;
        }
    }
}