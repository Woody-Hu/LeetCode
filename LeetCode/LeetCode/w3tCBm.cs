using System;
namespace LeetCode
{
	public class w3tCBm
	{
        public int[] CountBits(int n)
        {
            var res = new int[n + 1];
            var highBit = 0;
            for (int i = 1; i <= n; i++)
            {
                if ((i & (i - 1)) == 0)
                {
                    highBit = i;
                }

                res[i] = res[i - highBit] + 1;
            }

            return res;
        }
    }
}

