using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Majority_Element_II
    {
        public IList<int> MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            var list = new List<int>();
            var length = nums.Length;
            var useLength = length / 3;
            int? lastValue = null;

            for (int i = 0; i < length - useLength; i++)
            {
                if (lastValue != null && lastValue == nums[i])
                {
                    continue;
                }
                if (nums[i] == nums[i+useLength])
                {
                    list.Add(nums[i]);
                    lastValue = nums[i];
                }
            }

            return list;
        }
    }
}
