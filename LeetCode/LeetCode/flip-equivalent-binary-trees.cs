using System;
namespace LeetCode
{
    public class flip_equivalent_binary_trees
    {
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 == null || root2 == null || root1.val != root2.val)
            {
                return false;
            }

            return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) || (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
        }
    }
}
