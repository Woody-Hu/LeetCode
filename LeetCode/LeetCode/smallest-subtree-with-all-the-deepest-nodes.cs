using System;
namespace LeetCode
{
    public class smallest_subtree_with_all_the_deepest_nodes
    {
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            var res = Visit(root);
            return res.Item1;
        }

        private (TreeNode, int) Visit(TreeNode root)
        {
            if (root == null)
            {
                return (null, 0);
            }

            var left = Visit(root.left);
            var right = Visit(root.right);
            if (left.Item2 > right.Item2)
            {
                return (left.Item1, left.Item2 + 1);
            }

            if (left.Item2 < right.Item2)
            {
                return (right.Item1, right.Item2 + 1);
            }

            return (root, left.Item2 + 1);
        }
    }
}
