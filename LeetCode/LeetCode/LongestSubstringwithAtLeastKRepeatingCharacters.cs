using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestSubstringwithAtLeastKRepeatingCharacters
    {
        public int LongestSubstring(string s, int k)
        {
            int[] useCharArray = new int[26];

            foreach (var oneChar in s)
            {
                useCharArray[oneChar - 'a'] += 1;
            }

            bool returnTag = true;

            foreach (var oneValue in useCharArray)
            {
                if (oneValue >0 && oneValue < k)
                {
                    returnTag = false;
                    break;
                }
            }

            if (returnTag)
            {
                return s.Length;
            }

            int result = 0;
            int start = 0, cur = 0;

            while (cur < s.Length)
            {
                if (useCharArray[s[cur] - 'a'] < k)
                {
                    result = Math.Max(result, LongestSubstring(s.Substring(start, cur - start), k));
                    start = cur + 1;
                }

                cur++;
            }

            result = Math.Max(result, LongestSubstring(s.Substring(start), k));

            return result;
        }
    }
}
