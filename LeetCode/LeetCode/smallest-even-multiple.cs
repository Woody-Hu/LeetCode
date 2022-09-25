using System;
namespace LeetCode
{
    public class smallest_even_multiple
    {
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
            {
                return n;
            }
            else
            {
                return n * 2;
            }
        }
    }
}
