using System;
namespace LeetCode
{
	public class um_in_a_matrix
	{
        public int MatrixSum(int[][] nums)
        {
            foreach (var item in nums)
            {
                Array.Sort(item);
            }

            var res = 0;
            for (int i = 0; i < nums[0].Length; i++)
            {
                var max = 0;
                foreach (var item in nums)
                {
                    max = Math.Max(item[i], max);
                }

                res += max;
            }

            return res;
        }
    }
}

