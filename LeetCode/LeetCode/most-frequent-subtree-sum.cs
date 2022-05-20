using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class most_frequent_subtree_sum
    {
        public int[] FindFrequentTreeSum(TreeNode root)
        {
            var dict = new Dictionary<int, int>();
            Visit(root, dict);
            if (!dict.Any())
            {
                return new int[0]; 
            }

            var max = dict.Values.Max();
            var res = dict.Where(k => k.Value == max).Select(k => k.Key);
            return res.ToArray();
        }

        private int? Visit(TreeNode root, Dictionary<int, int> count)
        {
            if (root == null)
            {
                return null;
            }

            var value = root.val;
            var leftRes = Visit(root.left, count);
            var rightRes = Visit(root.right, count);
            if (leftRes != null)
            {
                value += leftRes.Value;
            }

            if (rightRes != null)
            {
                value += rightRes.Value;
            }

            if (!count.ContainsKey(value))
            {
                count.Add(value, 0);
            }

            count[value]++;
            return value;
        }
    }
}
