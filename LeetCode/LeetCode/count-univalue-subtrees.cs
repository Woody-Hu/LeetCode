using System;
namespace LeetCode
{
	public class count_univalue_subtrees
	{
		public int CountUnivalSubtrees(TreeNode root)
		{
			var res = 0;
			Visit(root, ref res);
			return res;
		}

		private bool Visit(TreeNode root, ref int res)
		{
            if (root == null)
            {
				return false;
            }

            if (root.left == null && root.right == null)
            {
				res++;
				return true;
            }

			var isUnival = true;
            if (root.left != null)
            {
				var leftRes = Visit(root.left, ref res) && root.val == root.left.val;
				isUnival = isUnival && leftRes;
            }

            if (root.right != null)
            {
				var rightRes = Visit(root.right, ref res) && root.val == root.right.val;
				isUnival = isUnival && rightRes;
			}

            if (!isUnival)
            {
				return false;
            }

			res++;
			return true;
		}
	}
}

