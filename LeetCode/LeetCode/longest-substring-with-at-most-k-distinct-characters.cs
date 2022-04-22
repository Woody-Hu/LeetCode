using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class longest_substring_with_at_most_k_distinct_characters
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            var length = s.Length;
            if (length * k == 0)
            {
                return 0;
            }

            var location = new Dictionary<char, int>();
            var l = 0;
            var r = 0;
            var res = 1;
            while (r < length)
            {
                location[s[r]] = r;
                r = r + 1;
                if (location.Count > k)
                {
                    var remove = location.OrderBy(k => k.Value).First().Key;
                    var removeIndex = location[remove];
                    location.Remove(remove);
                    l = removeIndex + 1;
                }

                res = Math.Max(res, r - l);
            }

            return res;
        }
    }
}

