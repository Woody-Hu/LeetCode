using System;
namespace LeetCode
{
	public class shu_zu_zhong_shu_zi_chu_xian_de_ci_shu_ii_lcof
	{
        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i+= 3)
            {
                if (i >= nums.Length - 1|| nums[i] != nums[i + 1])
                {
                    return i >= nums.Length ? nums[nums.Length - 1] : nums[i];
                }
            }

            return -1;
        }
    }
}

