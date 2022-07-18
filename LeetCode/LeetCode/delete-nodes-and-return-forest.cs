using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class delete_nodes_and_return_forest
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var res = new List<TreeNode>();
            if (root == null)
            {
                return res;
            }

            var set = new HashSet<int>();
            foreach (var item in to_delete)
            {
                set.Add(item);
            }

            Visit(root, null, set, res);
            return res;
        }

        private TreeNode Visit(TreeNode root, TreeNode parent, HashSet<int> toDelete, List<TreeNode> res)
        {
            if (root == null)
            {
                return null;
            }

            var left = root.left;
            var right = root.right;
            if (toDelete.Contains(root.val))
            {
                root = null;
            }
            else if (parent == null)
            {
                res.Add(root);
            }

            var leftRes = Visit(left, root, toDelete, res);
            var rightRes = Visit(right, root, toDelete, res);
            if (root != null)
            {
                root.left = leftRes;
                root.right = rightRes;
            }

            return root;
        }
    }
}
