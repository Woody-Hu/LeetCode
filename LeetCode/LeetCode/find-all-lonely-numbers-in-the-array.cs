using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_all_lonely_numbers_in_the_array
    {
        public IList<int> FindLonely(int[] nums)
        {
            var res = new List<int>();
            var dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
            }

            foreach (var item in nums)
            {
                if (dic[item] == 1 && !dic.ContainsKey(item - 1) && !dic.ContainsKey(item + 1))
                {
                    res.Add(item);
                }
            }

            return res;
        }
    }
}
