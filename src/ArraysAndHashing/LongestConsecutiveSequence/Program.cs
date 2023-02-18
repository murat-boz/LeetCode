using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var test1 = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
        var test2 = new int[] { 100, 4, 200, 1, 3, 2 };
        var test3 = new int[] { };

        Console.WriteLine(new Solution().LongestConsecutive(test3));
    }
}

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int maxLength = 1;

        var hashSets = new HashSet<int>(nums);

        foreach (var hashSet in hashSets)
        {
            if (!hashSets.Contains(hashSet - 1))
            {
                int valueToLookFor = hashSet;

                while (hashSets.Contains(valueToLookFor + 1))
                {
                    valueToLookFor++;

                    maxLength = Math.Max(maxLength, valueToLookFor - hashSet + 1);
                }
            }
        }

        return maxLength;
    }
}