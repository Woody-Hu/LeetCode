using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class Ygoe9J
	{
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var res = new List<IList<int>>();
            var list = new List<int>();
            DFS(candidates, target, 0, list, res);
            return res;
        }

        private void DFS(int[] input, int target, int i, List<int> list, IList<IList<int>> res)
        {
            if (i == input.Length)
            {
                return;
            }

            if (target <= 0)
            {
                res.Add(new List<int>(list));
                return;
            }

            DFS(input, target, i + 1, list, res);
            if (target - input[i] >= 0)
            {
                list.Add(input[i]);
                DFS(input, target - input[i], i, list, res);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}

