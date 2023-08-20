using System;
namespace LeetCode
{
	public class minimum_operations_to_reduce_an_integer_to_0
	{
        public int MinOperations(int n)
        {
            var res = 1;
            while ((n & (n - 1)) > 0)
            {
                var lb = n & -n;
                if ((n & lb << 1) > 0)
                {
                    n += lb;
                }
                else
                {
                    n -= lb;
                }

                res++;
            }

            return res;
        }
    }
}

