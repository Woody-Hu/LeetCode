using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class word_pattern_ii
    {
        public bool WordPatternMatch(string pattern, string s)
        {
            return WordPatternMatch(pattern, s, new Dictionary<char, string>());
        }

        public bool WordPatternMatch(string pattern, string s, Dictionary<char, string> map)
        {
            if (pattern.Length == 0)
            {
                return s.Length == 0;
            }

            var firstPattern = pattern[0];
            for (int i = 1; i <= s.Length - pattern.Length + 1; i++)
            {
                var ss = s.Substring(0, i);
                map.TryGetValue(firstPattern, out var curretMap);
                if ((curretMap != null && ss.Equals(curretMap)) || (curretMap == null && !map.Values.Contains(ss)))
                {
                    map[firstPattern] = ss;
                    if (WordPatternMatch(pattern.Substring(1), s.Substring(i), map))
                    {
                        return true;
                    }
                    else if (curretMap == null)
                    {
                        map.Remove(firstPattern);
                    }
                }
            }

            return false;
        }
    }
}
