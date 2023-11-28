using System;
namespace LeetCode
{
	public class _AoeFn
	{
        public int UniquePaths(int m, int n)
        {
            var res = 1l;
            for (int x = n, y = 1; y < m; x++, y++)
            {
                res = res * x / y;
            }

            return (int)res;
        }
    }
}

