using System;
using System.Linq;

namespace LeetCode
{
    public class delete_and_earn
    {
        public int DeleteAndEarn(int[] nums)
        {
            var max = nums.Max();
            var array = new int[max + 1];
            foreach (var item in nums)
            {
                array[item] += item;
            }

            var first = array[0];
            var second = Math.Max(array[0], array[1]);

            for (int i = 2; i < array.Length; i++)
            {
                var temp = second;
                second = Math.Max(first + array[i], second);
                first = temp;
            }

            return second;
        }
    }
}
