using System;
namespace LeetCode
{
	public class binary_tree_pruning
	{
		public TreeNode PruneTree(TreeNode root)
		{
            if (ContainsOneValue(root))
            {
				return root;
            }

			return null;
		}

		private bool ContainsOneValue(TreeNode root)
		{
            if (root == null)
            {
				return false;
            }

			var leftRes = ContainsOneValue(root.left);
			var rightRes = ContainsOneValue(root.right);
            if (!leftRes)
            {
				root.left = null;
            }

            if (!rightRes)
            {
				root.right = null;
            }

			return root.val == 1 || leftRes | rightRes;
		}
	}
}

