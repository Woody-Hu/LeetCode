using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class balance_a_binary_search_tree
    {
        public TreeNode BalanceBST(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            var list = new List<TreeNode>();
            InOrder(root, list);
            return Build(list, 0, list.Count - 1);
        }

        private void InOrder(TreeNode root, List<TreeNode> list)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left, list);
            list.Add(root);
            InOrder(root.right, list);
        }

        private TreeNode Build(List<TreeNode> list, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            var mid = (left + right) / 2;
            var res = new TreeNode(list[mid].val);
            res.left = Build(list, left, mid - 1);
            res.right = Build(list, mid + 1, right);
            return res;
        }
    }
}
