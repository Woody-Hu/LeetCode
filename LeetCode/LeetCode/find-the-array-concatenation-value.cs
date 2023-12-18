using System;
namespace LeetCode
{
	public class find_the_array_concatenation_value
	{
        public long FindTheArrayConcVal(int[] nums)
        {
            var res = 0l;
            var i = 0;
            var j = nums.Length - 1;
            for (; i <= j; i++, j--)
            {
                if (i != j)
                {
                    res += int.Parse(nums[i].ToString() + nums[j].ToString());
                }
                else
                {
                    res += nums[i];
                }
            }

            return res;
        }
    }
}

