using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_leaves_of_binary_tree
	{
		public IList<IList<int>> FindLeaves(TreeNode root)
		{
			var res = new List<IList<int>>();
			var dict = new Dictionary<int, IList<int>>();
			Visit(root, dict);
            foreach (var item in dict)
            {
				res.Add(item.Value);
            }

			return res;
		}

		private int Visit(TreeNode root, Dictionary<int, IList<int>> dict)
		{
            if (root == null)
            {
				return -1;
            }

			var left = Visit(root.left, dict);
			var right = Visit(root.right, dict);
			var current = Math.Max(left, right) + 1;
            if (!dict.ContainsKey(current))
            {
				dict.Add(current, new List<int>());
            }

			dict[current].Add(root.val);
			return current;
		}
	}
}

