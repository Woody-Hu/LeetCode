using System;
namespace LeetCode
{
    public class number_of_common_factors
    {
        public int CommonFactors(int a, int b)
        {
            var min = Math.Min(a, b);
            var res = 0;
            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i ==0)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
