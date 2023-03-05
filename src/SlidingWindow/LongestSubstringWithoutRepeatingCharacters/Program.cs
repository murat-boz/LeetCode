namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
            {
                return s.Length;
            }

            int leftPointer  = 0;
            int rightPointer = 0;
            int maxLength    = 0;

            HashSet<int> chars = new HashSet<int>();

            while (rightPointer < s.Length)
            {
                if (!chars.Contains(s[rightPointer]))
                {
                    chars.Add(s[rightPointer]);
                    maxLength = Math.Max(maxLength, rightPointer - leftPointer + 1);

                    rightPointer++;
                }
                else
                {
                    chars.Remove(s[leftPointer]);
                    leftPointer++;
                }
            }

            return maxLength;
        }
    }
}