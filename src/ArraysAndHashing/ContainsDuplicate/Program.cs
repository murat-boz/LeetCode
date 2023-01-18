using System.Collections.Generic;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Solution().ContainsDuplicate(new int[] { 1, 2, 3, 4 });
        }
    }

    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> numsHashSet = new HashSet<int>(nums.Length);

            foreach (var num in nums)
            {
                if (!numsHashSet.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
