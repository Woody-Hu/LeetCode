using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class counting_elements
    {
        public int CountElements(int[] arr)
        {
            var set = new HashSet<int>();
            foreach (var item in arr)
            {
                set.Add(item);
            }

            var res = 0;
            foreach (var item in arr)
            {
                if (set.Contains(item + 1))
                {
                    res++;
                }
            }

            return res;
        }
    }
}
