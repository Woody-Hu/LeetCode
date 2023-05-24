using System;
namespace LeetCode
{
	public class insufficient_nodes_in_root_to_leaf_paths
	{
        public TreeNode SufficientSubset(TreeNode root, int limit)
        {
            var res = Calculate(root, 0, limit);
            return res ? root : null;
        }

        private bool Calculate(TreeNode root, int currentSum, int limit)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return root.val + currentSum >= limit;
            }

            var cl = Calculate(root.left, currentSum + root.val, limit);
            var cr = Calculate(root.right, currentSum + root.val, limit);
            if (!cl)
            {
                root.left = null;
            }

            if (!cr)
            {
                root.right = null;
            }

            return cl || cr;
        }
    }
}

