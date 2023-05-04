using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class time_needed_to_inform_all_employees
	{
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            var dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                if (!dic.ContainsKey(manager[i]))
                {
                    dic.Add(manager[i], new List<int>());
                }

                dic[manager[i]].Add(i);
            }

            return Calculate(headID, informTime, dic);
        }

        private int Calculate(int i, int[] informTime, Dictionary<int, List<int>> dic)
        {
            var res = 0;
            var children = dic.GetValueOrDefault(i, new List<int>());
            foreach (var item in children)
            {
                res = Math.Max(res, Calculate(item, informTime, dic));
            }

            return informTime[i] + res;

        }
    }
}

