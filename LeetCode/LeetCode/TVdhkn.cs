using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class TVdhkn
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>();
            var current = new List<int>();
            Visit(0, nums, current, res);
            return res;
        }

        private void Visit(int i, int[] nums, List<int> current, List<IList<int>> res)
        {
            if (i == nums.Length)
            {
                res.Add(new List<int>(current));
                return;
            }

            current.Add(nums[i]);
            Visit(i + 1, nums, current, res);
            current.RemoveAt(current.Count - 1);
            Visit(i + 1, nums, current, res);
        }
    }
}
