using System;
namespace LeetCode
{
    public class KnLfVT
    {
        public TreeNode ExpandBinaryTree(TreeNode root)
        {
            if (root.left != null)
            {
                root.left = new TreeNode(-1, ExpandBinaryTree(root.left), null);
            }

            if (root.right != null)
            {
                root.right = new TreeNode(-1, null, ExpandBinaryTree(root.right));
            }

            return root;
        }
    }
}
