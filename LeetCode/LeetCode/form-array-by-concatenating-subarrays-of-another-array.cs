using System;
namespace LeetCode
{
	public class form_array_by_concatenating_subarrays_of_another_array
	{
        public bool CanChoose(int[][] groups, int[] nums)
        {
            var i = 0;
            for (int k = 0; k < nums.Length && i < groups.Length; )
            {
                if (Check(groups[i], nums, k))
                {
                    k += groups[i].Length;
                    i++;
                }
                else
                {
                    k++;
                }
            }

            return i == groups.Length;
        }

        private bool Check(int[] g, int[] nums, int k)
        {
            if (k + g.Length > nums.Length)
            {
                return false;
            }

            for (int j = 0; j < g.Length; j++)
            {
                if (g[j] != nums[k + j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

