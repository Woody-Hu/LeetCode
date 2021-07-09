using System;
namespace LeetCode
{
    public class Sum_of_Digits_in_Base_K
    {
        public int SumBase(int n, int k)
        {
            var res = 0;
            while (n > 0)
            {
                res += n % k;
                n /= k;
            }

            return res;
        }
    }
}
