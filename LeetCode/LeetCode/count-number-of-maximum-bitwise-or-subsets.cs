using System;
namespace LeetCode
{
    public class count_number_of_maximum_bitwise_or_subsets
    {
        public int CountMaxOrSubsets(int[] nums)
        {
            var max = 0;
            var res = 0;
            DFS(nums, 0, 0, ref max, ref res);
            return res;
        }

        private void DFS(int[] nums, int i, int value, ref int max, ref int res)
        {
            if (i == nums.Length)
            {
                if (value > max)
                {
                    max = value;
                    res = 1;
                }
                else if (value == max)
                {
                    res++;
                }

                return;
            }

            DFS(nums, i + 1, value, ref max, ref res);
            DFS(nums, i + 1, value|nums[i], ref max, ref res);
        }
    }
}
