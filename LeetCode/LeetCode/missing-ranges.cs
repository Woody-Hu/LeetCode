using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class missing_ranges
    {
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            var res = new List<string>();
            var values = nums.Prepend(lower - 1).Append(upper + 1);
            

            for (int i = 0; i < values.Count() - 1; i++)
            {
                var value1 = values.ElementAt(i);
                var value2 = values.ElementAt(i + 1);
                if (value2 - value1 <= 1)
                {
                    continue;
                }
                else if (value2 - value1 == 2)
                {
                    res.Add((value1 + 1).ToString());
                }
                else
                {
                    res.Add($"{value1+1}->{value2 - 1}");
                }
            }

            return res;

        }
    }
}
