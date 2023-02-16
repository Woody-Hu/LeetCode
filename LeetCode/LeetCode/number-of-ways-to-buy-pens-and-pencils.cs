using System;
namespace LeetCode
{
	public class number_of_ways_to_buy_pens_and_pencils
	{
        public long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            var max1 = total / cost1;
            var res = 0l;
            for (int i = 0; i <= max1; i++)
            {
                var rest = total - i * cost1;
                res += rest / cost2 + 1;
            }

            return res;
        }
    }
}

