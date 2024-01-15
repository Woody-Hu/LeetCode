using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class count_elements_with_maximum_frequency
	{
        public int MaxFrequencyElements(int[] nums)
        {
            var max = 0;
            var res = 0;
            var dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic[item] = 0;
                }

                dic[item]++;
                max = Math.Max(max, dic[item]);
            }

            foreach (var item in nums)
            {
                if (dic[item] == max)
                {
                    res++;
                }
            }

            return res;
        }
    }
}

