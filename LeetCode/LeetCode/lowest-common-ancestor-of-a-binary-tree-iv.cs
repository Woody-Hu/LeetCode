using System;
namespace LeetCode
{
    public class lowest_common_ancestor_of_a_binary_tree_iv
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes)
        {
            if (root == null)
            {
                return null;
            }

            foreach (var item in nodes)
            {
                if (root == item)
                {
                    return root;
                }
            }

            var left = LowestCommonAncestor(root.left, nodes);
            var right = LowestCommonAncestor(root.right, nodes);
            if (left != null & right != null )
            {
                return root;
            }

            if (left != null)
            {
                return left;
            }

            return right;
        }
    }
}
