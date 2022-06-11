using System;
namespace LeetCode
{
	public class binary_search_tree_to_greater_sum_tree
	{
		public TreeNode BstToGst(TreeNode root)
		{
			var sum = 0;
			Visit(root, ref sum);
			return root;
		}

		private void Visit(TreeNode root, ref int sum)
		{
            if (root == null)
            {
				return;
            }

			Visit(root.right, ref sum);
			sum += root.val;
			root.val = sum;
			Visit(root.left, ref sum);
		}
	}
}

