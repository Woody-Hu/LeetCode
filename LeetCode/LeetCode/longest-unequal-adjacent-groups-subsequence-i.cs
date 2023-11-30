using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class longest_unequal_adjacent_groups_subsequence_i
	{
        public IList<string> GetWordsInLongestSubsequence(int n, string[] words, int[] groups)
        {
            var res = new List<string>();
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1 || groups[i] != groups[i + 1])
                {
                    res.Add(words[i]);
                }
            }

            return res;
        }
    }
}

