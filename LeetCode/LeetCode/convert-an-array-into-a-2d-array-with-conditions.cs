using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class convert_an_array_into_a_2d_array_with_conditions
	{
        public IList<IList<int>> FindMatrix(int[] nums)
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

            var res = new List<IList<int>>();
            while (dic.Any())
            {
                var list = new List<int>();
                var keys = dic.Keys;
                foreach (var item in keys)
                {
                    list.Add(item);
                    dic[item]--;
                    if (dic[item] == 0)
                    {
                        dic.Remove(item);
                    }
                }

                res.Add(list);
            }

            return res;
        }
    }
}

