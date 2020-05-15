using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_Lucky_Integer_in_an_Array
    {
        public int FindLucky(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }

                dict[item]++;
            }

            var res = -1;

            foreach (var item in dict)
            {
                if (item.Key == item.Value)
                {
                    res = Math.Max(item.Key, res);
                }
            }

            return res;
        }
    }
}
