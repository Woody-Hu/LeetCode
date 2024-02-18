using System;
namespace LeetCode
{
	public class NYBBNL
	{
        public TreeNode IncreasingBST(TreeNode root)
        {
            var pre = new TreeNode(-1);
            var resNode = pre;
            InOrder(root, ref resNode);
            return pre.right;
        }

        private void InOrder(TreeNode node, ref TreeNode res)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.left, ref res);
            res.right = node;
            node.left = null;
            res = node;

            InOrder(node.right, ref res);
        }
    }
}

