using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_All_Duplicates_in_an_Array
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                {
                    list.Add(index + 1);
                    continue;
                }

                nums[index] = -nums[index];
            }

            return list;
        }
    }
}
