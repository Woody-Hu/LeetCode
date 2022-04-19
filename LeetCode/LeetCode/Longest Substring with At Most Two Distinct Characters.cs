using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Longest_Substring_with_At_Most_Two_Distinct_Characters
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            var length = s.Length;
            var left = 0;
            var right = 0;
            var dict = new Dictionary<char, int>();
            var res = 0;
            while (right < length)
            {
                if (dict.Count < 3)
                {
                    dict[s[right]] = right++;
                }

                // slidewindow contains 3 characters
                if (dict.Count() == 3)
                {
                    var del_idx = dict.Min(k => k.Value);
                    dict.Remove(s[del_idx]);
                    // move left pointer of the slidewindow
                    left = del_idx + 1;
                }

                res = Math.Max(res, right - left);
            }

            return res;
        }
    }
}
