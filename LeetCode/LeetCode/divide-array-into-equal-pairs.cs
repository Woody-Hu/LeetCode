using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class divide_array_into_equal_pairs
	{
        public bool DivideArray(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
            }

            var res = true;
            foreach (var item in dic)
            {
                res = res && item.Value % 2 == 0;
                if (!res)
                {
                    break;
                }
            }

            return res;
        }
    }
}

