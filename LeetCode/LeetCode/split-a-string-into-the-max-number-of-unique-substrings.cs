using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class split_a_string_into_the_max_number_of_unique_substrings
	{
        public int MaxUniqueSplit(string s)
        {
            var res = 0;
            var set = new HashSet<string>();
            Backtrack(0, 0, s, set, ref res);
            return res;
        }

        private void Backtrack(int index, int split, string input, HashSet<string> set, ref int res)
        {
            if (index >= input.Length)
            {
                res = Math.Max(res, split);
                return;
            }

            for (int i = index; i < input.Length; i++)
            {
                var sub = input.Substring(index, i - index + 1);
                if (set.Add(sub))
                {
                    Backtrack(i + 1, split + 1, input, set, ref res);
                    set.Remove(sub);
                }
            }
        }
    }
}

