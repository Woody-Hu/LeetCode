using System;
namespace LeetCode
{
	public class last_moment_before_all_ants_fall_out_of_a_plank
	{
        public int GetLastMoment(int n, int[] left, int[] right)
        {
            var res = 0;
            foreach (var item in left)
            {
                res = Math.Max(res, item);
            }

            foreach (var item in right)
            {
                res = Math.Max(res, n - item);
            }

            return res;
        }
    }
}

