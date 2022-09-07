using System;
namespace LeetCode
{
    public class qiu_12n_lcof
    {
        public int SumNums(int n)
        {
            bool flag = n > 0 && (n += SumNums(n-1)) > 0;
            return n;
        }
    }
}
