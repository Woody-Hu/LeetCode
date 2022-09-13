using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class optimal_partition_of_string
    {
        public int PartitionString(string s)
        {
            var set = new HashSet<char>();
            var res = 1;
            foreach (var item in s)
            {
                if (set.Contains(item))
                {
                    res++;
                    set.Clear();
                }

                set.Add(item);
            }

            return res;
        }
    }
}
