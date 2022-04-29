using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class palindrome_permutation
    {
        public bool CanPermutePalindrome(string s)
        {
            var counts = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!counts.ContainsKey(item))
                {
                    counts.Add(item, 0);
                }

                counts[item]++;
            }

            return counts.Where(k => k.Value % 2 != 0).Count() <= 1;
        }
    }
}
