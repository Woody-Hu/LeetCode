using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RotateCalss
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k-1);
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] input,int start,int end)
        {
            while (start < end)
            {
                int tempValue = input[start];

                input[start] = input[end];

                input[end] = tempValue;

                start++;
                end--;
            }
        }

    }
}
