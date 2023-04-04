using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class minimum_rounds_to_complete_all_tasks
	{
        public int MinimumRounds(int[] tasks)
        {
            var res = 0;
            var dic = new Dictionary<int, int>();
            foreach (var item in tasks)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
            }

            foreach (var item in dic)
            {
                if (item.Value < 2)
                {
                    return -1;
                }

                res += (item.Value + 2) / 3;
            }

            return res;
        }
    }
}

