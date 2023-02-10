using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_number_of_integers_to_choose_from_a_range_i
    {
        public int MaxCount(int[] banned, int n, int maxSum)
        {
            var set = new HashSet<int>();
            foreach (var item in banned)
            {
                set.Add(item);
            }

            var res = 0;
            var cur = 0;
            for (int i = 0; i <= n; i++)
            {
                if (set.Contains(i))
                {
                    continue;
                }

                if (i + cur > maxSum)
                {
                    break;
                }

                cur += i;
                res += 1;
            }

            return res;
        }
    }
}
