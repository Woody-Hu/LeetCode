using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class power_set_lcci
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>();
            var list = new List<int>();
            DFS(0, nums, list, res);
            return res;
        }

        private void DFS(int i, int[] nums, List<int> list, List<IList<int>> res)
        {
            if (i == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }

            list.Add(nums[i]);
            DFS(i + 1, nums, list, res);
            list.RemoveAt(list.Count - 1);
            DFS(i + 1, nums, list, res);
        }
    }
}
