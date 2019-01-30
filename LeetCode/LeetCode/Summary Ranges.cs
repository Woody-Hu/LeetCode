using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Summary_Ranges
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var list = new List<string>();
            if (nums == null || nums.Length == 0)
            {
                return list;
            }

            int start = nums[0];
   
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i-1] + 1)
                {
                    if (start == nums[i - 1])
                    {
                        list.Add(start.ToString());
                    }
                    else
                    {
                        list.Add($"{start}->{nums[i-1]}");
                    }

                    start = nums[i];
                }
            }

            if (start == nums[nums.Length - 1])
            {
                list.Add(start.ToString());
            }
            else
            {
                list.Add($"{start}->{nums[nums.Length - 1]}");
            }

            return list;
        }
    }
}
