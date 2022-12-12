using System;
namespace LeetCode
{
    public class frog_jump_ii
    {
        public int MaxJump(int[] stones)
        {
            var res = stones[1] - stones[0];
            for (int i = 2; i < stones.Length; i++)
            {
                res = Math.Max(res, stones[i] - stones[i - 2]);
            }

            return res;
        }
    }
}
