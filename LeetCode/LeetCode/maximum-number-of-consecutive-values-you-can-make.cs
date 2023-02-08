using System;
namespace LeetCode
{
	public class maximum_number_of_consecutive_values_you_can_make
	{
        public int GetMaximumConsecutive(int[] coins)
        {
            var res = 1;
            Array.Sort(coins);
            foreach (var item in coins)
            {
                if (item > res)
                {
                    break;
                }

                res += item;
            }

            return res;
        }
    }
}

