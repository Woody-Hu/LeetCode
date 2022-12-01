using System;
namespace LeetCode
{
	public class find_the_pivot_integer
	{
        public int PivotInteger(int n)
        {
            var m = n * (n + 1) / 2;
            var x = (int)Math.Sqrt(m);
            if (x * x == m)
            {
                return x;
            }
            else
            {
                return -1;
            }
        }
    }
}

