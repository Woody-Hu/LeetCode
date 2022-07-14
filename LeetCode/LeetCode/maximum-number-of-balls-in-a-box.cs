using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_number_of_balls_in_a_box
    {
        public int CountBalls(int lowLimit, int highLimit)
        {
            int[] ints = new int[46];
            for (int i = lowLimit; i <= highLimit; i++)
            {
                ints[Calculate(i)]++;
            }

            var res = 0;
            foreach (var item in ints)
            {
                res = Math.Max(res, item);
            }

            return res;
        }

        private int Calculate(int n)
        {
            int ans = 0;
            while (n > 0)
            {
                ans += n % 10;
                n /= 10;
            }

            return ans;
        }
    }
}
