using System;
namespace LeetCode
{
    public class wiggle_subsequence
    {
        public int WiggleMaxLength(int[] nums)
        {
            var n = nums.Length;
            var up = new int[n];
            var down = new int[n];
            up[0] = 1;
            down[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    up[i] = Math.Max(up[i - 1], down[i - 1] + 1);
                    down[i] = down[i - 1];
                }
                else if (nums[i] < nums[i - 1])
                {
                    up[i] = up[i - 1];
                    down[i] = Math.Max(down[i - 1], up[i - 1] + 1);
                }
                else
                {
                    up[i] = up[i - 1];
                    down[i] = down[i - 1];
                }
            }

            return Math.Max(up[n - 1], down[n - 1]);
        }
    }
}
