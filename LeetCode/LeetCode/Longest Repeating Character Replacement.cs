using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Longest_Repeating_Character_Replacement
    {
        public int CharacterReplacement(string s, int k)
        {
            var count = new int[26];
            var length = s.Length;
            var currentStart = 0;
            var maxLength = 0;
            var maxCount = 0;
            for (int end = 0; end < length; end++)
            {
                count[s[end] - 'A']++;
                maxCount = Math.Max(maxCount, count[s[end] - 'A']);
                while (end - currentStart + 1 - maxCount > k)
                {
                    count[s[currentStart] - 'A']--;
                    currentStart++;
                }

                maxLength = Math.Max(maxLength, end - currentStart + 1);
            }

            return maxLength;
        }
    }
}
