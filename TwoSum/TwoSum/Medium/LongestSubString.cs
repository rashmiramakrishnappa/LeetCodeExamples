using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    public class LongestSubString
    {
        public LongestSubString()
        {
            string s = "";
            var length = LengthOfLongestSubstring(s);
        }
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            else
            {
                IDictionary<char, int> charIndexes = new Dictionary<char, int>();
                int maxLength = 1, startIndex = 0; 
                for (int i = 0; i < s.Length; i++)
                {
                    if (!charIndexes.TryAdd(s[i], i))
                    {
                        startIndex = Math.Max(charIndexes[s[i]] + 1, startIndex);
                        charIndexes[s[i]] = i;
                    }
                    maxLength = Math.Max(i - startIndex + 1, maxLength);
                }
                return maxLength;
            }
        }
    }
}

