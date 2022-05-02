using System;
namespace LeetCode
{
    public class binary_tree_upside_down
    {
        public TreeNode UpsideDownBinaryTree(TreeNode root)
        {
            TreeNode right = null;
            TreeNode parent = null;
            while (root != null)
            {
                var left = root.left;
                root.left = right;
                right = root.right;
                root.right = parent;
                parent = root;
                root = left;
            }

            return parent;
        }
    }
}
