using System;
namespace LeetCode
{
	public class delete_leaves_with_a_given_value
	{
		public TreeNode RemoveLeafNodes(TreeNode root, int target)
		{
            if (root == null)
            {
				return null;
            }

			var left = RemoveLeafNodes(root.left, target);
			var right = RemoveLeafNodes(root.right, target);
			root.left = left;
			root.right = right;
            if (left == null && right == null && root.val == target)
            {
				return null;
            }

			return root;
		}
	}
}

