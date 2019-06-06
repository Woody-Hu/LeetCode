using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Unique_Substrings_in_Wraparound_String
    {
        public int FindSubstringInWraproundString(string p)
        {
            int res = 0;
            int i = 0;
            int[] letters = new int[26];
            while (i < p.Length)
            {
                int endIndex = i;
                while (endIndex + 1 < p.Length && p[endIndex + 1] % 26 == (p[endIndex] + 1) % 26) endIndex++;
                for (int j = i; j <= endIndex; j++)
                {
                    letters[p[j] - 'a'] = Math.Max(letters[p[j] - 'a'], endIndex - j + 1);
                }

                i = endIndex + 1;
            }

            for (int j = 0; j < 26; j++)
            {
                res += letters[j];
            }
            return res;
        }
    }
}
