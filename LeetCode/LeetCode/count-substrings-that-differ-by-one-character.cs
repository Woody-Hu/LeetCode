using System;
using System.Linq;

namespace LeetCode
{
    public class count_substrings_that_differ_by_one_character
    {
        public int CountSubstrings(string s, string t)
        {
            var m = s.Length;
            var n = t.Length;
            var res = 0;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    int diff = 0;
                    for (int k = 0; i + k < m && j + k < n; ++k)
                    {
                        if (s.ElementAt(i + k) != t.ElementAt(j + k))
                        {
                            diff++;
                        }

                        if (diff > 1)
                        {
                            break;
                        }
                        if (diff == 1)
                        {
                            ++res;
                        }
                    }
                }
            }

            return res;
        }
    }
}
