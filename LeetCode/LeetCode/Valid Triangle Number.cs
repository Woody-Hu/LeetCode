using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Valid_Triangle_Number
    {
        public int TriangleNumber(int[] nums)
        {
            if (nums.Length < 3)
            {
                return 0;
            }

            Array.Sort(nums);
            var res = 0;
            for (var i = nums.Length - 1; i >=2; i--)
            {
                var max = nums[i];
                var low = 0;
                var high = i - 1;
                while (low < high)
                {
                    if (nums[low] + nums[high] > max)
                    {
                        res+= high -low;
                        high--;
                    }
                    else
                    {
                        low++;
                    }
                }
            }

            return res;
        }
    }
}
