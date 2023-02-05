using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            string[] array2 = new string[] { "", "" };

            new Solution().GroupAnagrams(array);
        }
    }

    public sealed class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var groups = new Dictionary<string, IList<string>>();

            foreach (string s in strs)
            {
                char[] hash = new char[26];

                foreach (char c in s)
                {
                    hash[c - 'a']++;
                }

                string key = new string(hash);

                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }

                groups[key].Add(s);
            }
            return groups.Values.ToList();
        }
    }
}
