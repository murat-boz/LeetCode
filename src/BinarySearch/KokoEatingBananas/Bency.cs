using BenchmarkDotNet.Attributes;

namespace KokoEatingBananas
{
    [MemoryDiagnoser(false)]
    public class Bency
    {
        Solution Solution = new Solution();

        [Benchmark]
        [Arguments(new int[] { 3, 6, 7, 11 }                    , 8)]
        [Arguments(new int[] { 30, 11, 23, 4, 20 }              , 5)]
        [Arguments(new int[] { 30, 11, 23, 4, 20 }              , 6)]
        [Arguments(new int[] { 805306368, 805306368, 805306368 }, 1000000000)]
        public void MinEatingSpeed(int[] piles, int h)
        {
            this.Solution.MinEatingSpeed(piles, h);
        }

        [Benchmark]
        [Arguments(new int[] { 3, 6, 7, 11 }                    , 8)]
        [Arguments(new int[] { 30, 11, 23, 4, 20 }              , 5)]
        [Arguments(new int[] { 30, 11, 23, 4, 20 }              , 6)]
        [Arguments(new int[] { 805306368, 805306368, 805306368 }, 1000000000)]
        public void MinEatingSpeed2(int[] piles, int h)
        {
            this.Solution.MinEatingSpeed2(piles, h);
        }

        [Benchmark]
        [Arguments(new int[] { 3, 6, 7, 11 }                    , 8)]
        [Arguments(new int[] { 30, 11, 23, 4, 20 }              , 5)]
        [Arguments(new int[] { 30, 11, 23, 4, 20 }              , 6)]
        [Arguments(new int[] { 805306368, 805306368, 805306368 }, 1000000000)]
        public void MinEatingSpeed3(int[] piles, int h)
        {
            this.Solution.MinEatingSpeed3(piles, h);
        }
    }
}
