using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class reduce_array_size_to_the_half
    {
        public int MinSetSize(int[] arr)
        {
            var res = 0;
            var dic = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!dic.ContainsKey(item))
                {
                    dic[item] = 0;
                }

                dic[item]++;
            }


            var ordered = dic.OrderByDescending(k => k.Value);
            var current = 0;
            foreach (var item in ordered)
            {
                res++;
                current += dic[item.Key];
                if (current >= arr.Length/2)
                {
                    break;
                }
            }

            return res;
        }
    }
}
