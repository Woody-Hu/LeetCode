using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class maximum_width_of_binary_tree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var dict = new Dictionary<int, int>();
            var res = 0;
            Visit(root, dict, 0, 0, ref res);
            return res;
        }

        private void Visit(TreeNode treeNode, Dictionary<int, int> dict, int depth, int pos, ref int res)
        {
            if (treeNode == null)
            {
                return;
            }

            if (!dict.ContainsKey(depth))
            {
                dict[depth] = pos;
            }

            res = Math.Max(res, pos - dict[depth] + 1);
            Visit(treeNode.left, dict, depth + 1, 2 * pos, ref res);
            Visit(treeNode.right, dict, depth + 1, 2 * pos + 1, ref res);
        }
    }
}
