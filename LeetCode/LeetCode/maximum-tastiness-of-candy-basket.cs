using System;
namespace LeetCode
{
    public class maximum_tastiness_of_candy_basket
    {
        public int MaximumTastiness(int[] price, int k)
        {
            var n = price.Length;
            Array.Sort(price);
            if (k == 2)
            {
                return price[n - 1] - price[0];
            }

            var l = 0;
            var r = (price[n - 1] - price[0]) / (k - 1) + 1;
            while (l + 1 < r)
            {
                var mid = (l + r) / 2;
                if (Check(price, mid, k))
                {
                    l = mid;
                }
                else
                {
                    r = mid;
                }
            }

            return l;
        }

        private bool Check(int[] price, int value, int k)
        {
            var count = 1;
            var pre = price[0];

            for (int i = 1; i < price.Length; i++)
            {
                if (price[i] >= pre + value)
                {
                    count++;
                    pre = price[i];
                }

                if (count == k)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
