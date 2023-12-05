using System;
namespace LeetCode
{
	public class earliest_possible_day_of_full_bloom
	{
        public int EarliestFullBloom(int[] plantTime, int[] growTime)
        {
            var n = plantTime.Length;
            var dic = new int[n];
            for (int i = 0; i < n; i++)
            {
                dic[i] = i;
            }

            Array.Sort(dic, (i, j) => growTime[j] - growTime[i]);
            var res = 0;
            var sum = 0;
            foreach (var item in dic)
            {
                sum += plantTime[item];
                res = Math.Max(res, sum + growTime[item]);
            }

            return res;
        }
    }
}

