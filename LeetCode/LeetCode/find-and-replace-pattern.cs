using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_and_replace_pattern
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var res = new List<string>();
            foreach (var item in words)
            {
                if (Check(item, pattern) && Check(pattern, item))
                {
                    res.Add(item);
                }
            }

            return res;
        }

        private bool Check(string input, string pattern)
        {
            var map = new Dictionary<char, char>();
            for (int i = 0; i < input.Length; i++)
            {
                var x = input[i];
                var y = pattern[i];
                if (!map.ContainsKey(x))
                {
                    map[x] = y;
                }
                else if (map[x] != y)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
