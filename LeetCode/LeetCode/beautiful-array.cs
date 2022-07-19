using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class beautiful_array
    {
        public int[] BeautifulArray(int n)
        {
            var dic = new Dictionary<int, int[]>();
            return Calculate(n, dic);
        }

        private int[] Calculate(int n, Dictionary<int, int[]> dic)
        {
            if (dic.TryGetValue(n, out var exist))
            {
                return exist;
            }

            var res = new int[n];
            if (n == 1)
            {
                res[0] = 1;
            }
            else
            {
                var t = 0;
                foreach (var item in Calculate((n + 1)/2, dic))
                {
                    res[t++] = 2*item - 1;
                }

                foreach (var item in Calculate((n) / 2, dic))
                {
                    res[t++] = 2 * item;
                }
            }

            dic[n] = res;
            return res;
        }

    }
}
