using System;
namespace LeetCode
{
    public class minimum_penalty_for_a_shop
    {
        public int BestClosingTime(string customers)
        {
            var sum = 0;
            var max = 0;
            var res = customers.Length;
            for (int i = customers.Length - 1; i >= 0; i--)
            {
                if (customers[i] == 'N')
                {
                    sum++;
                    if (sum >= max)
                    {
                        max = sum;
                        res = i;
                    }
                }
                else
                {
                    sum--;
                }
            }

            return res;
        }
    }
}
