using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class binary_tree_postorder_traversal
	{
		public IList<int> PostorderTraversal(TreeNode root)
		{
			var res = new List<int>();
			Visit(root, res);
			return res;
		}

		private void Visit(TreeNode root, IList<int> list)
		{
            if (root == null)
            {
				return;
            }

			Visit(root.left, list);
			Visit(root.right, list);
			list.Add(root.val);
		}
	}
}

