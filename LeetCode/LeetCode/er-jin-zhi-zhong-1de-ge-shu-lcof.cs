using System;
namespace LeetCode
{
    public class er_jin_zhi_zhong_1de_ge_shu_lcof
    {
        public int HammingWeight(uint n)
        {
            var res = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                res++;
            }

            return res;
        }
    }
}
