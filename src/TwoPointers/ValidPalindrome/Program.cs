using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1 = "A man, a plan, a canal: Panama";
            string test2 = "race a car";

            Console.WriteLine(new Solution().IsPalindrome(test1));
            Console.WriteLine(new Solution().IsPalindrome(test2));
        }
    }

    public sealed class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = this.ConvertToAlphaNumeric(s).ToLower();

            int leftPointer  = 0;
            int rightPointer = s.Length - 1;

            while (leftPointer <= rightPointer)
            {
                if (s[leftPointer] != s[rightPointer])
                {
                    return false;
                }

                leftPointer++;
                rightPointer--;
            }

            return true;
        }

        private string ConvertToAlphaNumeric(string s)
        {
            return Regex.Replace(s, "[^A-Za-z0-9]", string.Empty);
        }
    }
}