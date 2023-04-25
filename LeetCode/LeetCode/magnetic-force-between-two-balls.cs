using System;
namespace LeetCode
{
	public class magnetic_force_between_two_balls
	{
        public int MaxDistance(int[] position, int m)
        {
            Array.Sort(position);
            var left = 1;
            var right = position[position.Length - 1] - position[0];
            var res = -1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (Check(mid, position, m))
                {
                    res = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return res;
        }

        private bool Check(int x, int[] position, int m)
        {
            var pre = position[0];
            var cnt = 1;
            for (int i = 1; i < position.Length; i++)
            {
                if (position[i] - pre >= x)
                {
                    pre = position[i];
                    cnt += 1;
                }
            }

            return cnt >= m;
        }
    }
}

