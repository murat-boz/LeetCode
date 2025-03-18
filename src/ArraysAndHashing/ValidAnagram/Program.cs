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

        public bool IsAnagramV2(string s, string t)
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

            Dictionary<char, int> dictionary = new();

            foreach (var item in s)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] = dictionary[item] + 1;

                    continue;
                }

                dictionary.TryAdd(item, 1);
            }

            foreach (var item in t)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] = dictionary[item] - 1;

                    continue;
                }

                dictionary.TryAdd(item, 1);
            }

            return dictionary.All(x => x.Value == 0);
        }

        public bool IsAnagramV3(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] count = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }

            foreach (int val in count)
            {
                if (val != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
