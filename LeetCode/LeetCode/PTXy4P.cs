using System;
namespace LeetCode
{
	public class PTXy4P
	{
        public int GetMinimumTime(int[] time, int[][] fruits, int limit)
        {
            var res = 0;
            foreach (var item in fruits)
            {
                res += time[item[0]] * (item[1] / limit + (item[1] % limit != 0 ? 1 : 0));
            }

            return res;
        }
    }
}

