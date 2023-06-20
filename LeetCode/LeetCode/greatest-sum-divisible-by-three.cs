using System;
namespace LeetCode
{
	public class greatest_sum_divisible_by_three
	{
        public int MaxSumDivThree(int[] nums)
        {
            var f = new int []{ 0, int.MinValue, int.MinValue };
            foreach (var item in nums)
            {
                var g = new int[3];
                Array.Copy(f, g, 3);
                for (int i = 0; i < 3; i++)
                {
                    g[(i + item % 3) % 3] = Math.Max(g[(i + item % 3) % 3], f[i] + item);
                }

                f = g;
            }

            return f[0];
        }
    }
}

