using System;
namespace LeetCode
{
	public class moving_stones_until_consecutive_ii
	{
        public int[] NumMovesStonesII(int[] stones)
        {
            var n = stones.Length;
            Array.Sort(stones);
            if (stones[n-1] - stones[0] + 1 == n)
            {
                return new int[] { 0, 0 };
            }

            var max = Math.Max(stones[n - 2] - stones[0], stones[n - 1] - stones[1]) + 1 - (n - 1);
            var min = n;
            for (int i = 0, j = 0; i < n && j + 1 <n; i++)
            {
                while (j + 1 < n && stones[j + 1] - stones[i] + 1 <= n)
                {
                    ++j;
                }

                if (j - i + 1 == n - 1 && stones[j] - stones[i] + 1 == n - 1)
                {
                    min = Math.Min(min, 2);
                }
                else
                {
                    min = Math.Min(min, n - (j - i + 1));
                }

            }

            return new int[] { min, max };
        }
    }
}

