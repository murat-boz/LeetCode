using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsAnagram("anagram", "nagaram"));
        }
    }

    public sealed class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null || t == null)
            {
                return false;
            }

            string trimmedS = s.Trim();
            string trimmedT = t.Trim();

            if (trimmedS.Length != trimmedT.Length)
            {
                return false;
            }

            Dictionary<char, int> dictionaryS = this.AddDictionaryWithRule(trimmedS);
            Dictionary<char, int> dictionaryT = this.AddDictionaryWithRule(trimmedT);

            if (dictionaryS == null || dictionaryT == null)
            {
                return false;
            }

            return !dictionaryS.Except(dictionaryT).Any();
        }

        private Dictionary<char, int> AddDictionaryWithRule(string value)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < value.Length; i++)
            {
                int bufferValue = 0;

                dictionary.TryGetValue(value[i], out bufferValue);

                if (bufferValue > 0)
                {
                    dictionary[value[i]] = bufferValue + 1;

                    continue;
                }

                dictionary.TryAdd(value[i], bufferValue + 1);
            }

            return dictionary;
        }
    }
}
