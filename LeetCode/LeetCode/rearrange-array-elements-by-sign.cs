using System;
namespace LeetCode
{
    public class rearrange_array_elements_by_sign
    {
        public int[] RearrangeArray(int[] nums) {
            var res = new int[nums.Length];
            var evenI = 0;
            var oddI = 1;
            foreach (var item in nums)
            {
                if (item > 0)
                {
                    res[evenI] = item;
                    evenI += 2;
                }
                else
                {
                    res[oddI] = item;
                    oddI += 2;
                }
            }

            return res;
        }
    }
}
