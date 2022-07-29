using System;
using System.Linq;

namespace LeetCode
{
    public class fair_distribution_of_cookies
    {
        public int DistributeCookies(int[] cookies, int k)
        {
            Array.Sort(cookies);
            var res = int.MaxValue;
            Visit(cookies, new int[k], k, cookies.Length - 1, ref res);
            return res;
        }

        private void Visit(int[] cookies, int[] data, int k, int index, ref int res)
        {
            if (index < 0)
            {
                var max = 0;
                max = data.Max();
                res = Math.Min(res, max);
                return;
            }

            for (int i = 0; i < k; i++)
            {
                if (index == cookies.Length - 1 && i > 0) return;
                data[i] += cookies[index];
                Visit(cookies, data, k, index - 1, ref res);
                data[i] -= cookies[index];
            }
        }
    }
}
