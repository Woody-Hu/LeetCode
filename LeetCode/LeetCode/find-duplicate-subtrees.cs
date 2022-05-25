using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_duplicate_subtrees
    {
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            var dict = new Dictionary<string, int>();
            var res = new List<TreeNode>();
            Visit(root, dict, res);
            return res;
        }

        private string Visit(TreeNode root, Dictionary<string, int> dict, List<TreeNode> res)
        {
            if (root == null)
            {
                return "n";
            }

            var thumbnail = $"{root.val}:{Visit(root.left, dict, res)}:{Visit(root.right, dict, res)}";
            if (!dict.ContainsKey(thumbnail))
            {
                dict.Add(thumbnail, 0);
            }

            dict[thumbnail]++;
            if (dict[thumbnail] == 2)
            {
                res.Add(root);
            }

            return thumbnail;
        }
    }
}
