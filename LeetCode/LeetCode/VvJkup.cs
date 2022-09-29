using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class VvJkup
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
            var visited = new bool[nums.Length];
            PermuteBuild(nums, visited, 0, new List<int>(), res);
            return res;
        }

        private void PermuteBuild(int[] nums, bool[] visited, int l, List<int> list, List<IList<int>> res)
        {
            if (l == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (!visited[j])
                {
                    list.Add(nums[j]);
                    visited[j] = true;
                    PermuteBuild(nums, visited, l + 1, list, res);
                    list.Remove(nums[j]);
                    visited[j] = false;
                }
            }
        }
    }
}
