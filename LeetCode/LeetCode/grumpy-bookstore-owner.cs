using System;
namespace LeetCode
{
    public class grumpy_bookstore_owner
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            var total = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                if (grumpy[i] == 0)
                {
                    total += customers[i];
                }
            }

            var add = 0;
            for (int i = 0; i < minutes; i++)
            {
                add += customers[i] * grumpy[i];
            }

            var max = add;
            for (int i = minutes; i < customers.Length; i++)
            {
                add = add - customers[i - minutes] * grumpy[i - minutes] + customers[i] * grumpy[i];
                max = Math.Max(add, max);
            }

            return total + max;
        }
    }
}
