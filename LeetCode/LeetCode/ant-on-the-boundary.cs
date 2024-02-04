using System;
namespace LeetCode
{
	public class ant_on_the_boundary
	{
        public int ReturnToBoundaryCount(int[] nums)
        {
            var res = 0;
            var sum = 0;
            foreach (var item in nums)
            {
                sum += item;
                if (sum == 0)
                {
                    res++;
                }
            }

            return res;
        }
    }
}

