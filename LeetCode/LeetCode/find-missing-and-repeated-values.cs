using System;
namespace LeetCode
{
	public class find_missing_and_repeated_values
	{
        public int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            var n = grid.Length;
            var dic = new int[n * n + 1];
            foreach (var item in grid)
            {
                foreach (var x in item)
                {
                    dic[x]++;
                }
            }

            var res = new int[2];
            for (int i = 1; i <= n * n; i++)
            {
                if (dic[i] == 2)
                {
                    res[0] = i;
                }
                else if (dic[i] == 0)
                {
                    res[1] = i;
                }
            }

            return res;
        }
    }
}

