using System;
namespace LeetCode
{
    public class paint_fence
    {
        public int NumWays(int n, int k)
        {
            if (n == 1)
            {
                return k;
            }

            var first = k;
            var second = k * k;
            for (int i = 2; i < n; i++)
            {
                var current = (first + second) * (k - 1);
                first = second;
                second = current;
            }

            return second;
        }
    }
}
