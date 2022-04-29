using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class number_of_distinct_substrings_in_a_string
    {
        public int CountDistinct(string s)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length; j > i; j--)
                {
                    var sub = s.Substring(i, j - i);
                    set.Add(sub);
                }
            }

            return set.Count;
        }
    }
}
