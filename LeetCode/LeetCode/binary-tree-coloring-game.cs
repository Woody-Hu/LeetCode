using System;
namespace LeetCode
{
	public class binary_tree_coloring_game
	{
        public bool BtreeGameWinningMove(TreeNode root, int n, int x)
        {
            TreeNode xNode = null;
            Find(root, x, ref xNode);
            var leftSize = GetSubTreeSize(xNode.left);
            if (leftSize >= (n + 1)/2)
            {
                return true;
            }

            var rightSize = GetSubTreeSize(xNode.right);
            if (rightSize >= (n + 1) / 2)
            {
                return true;
            }

            var remain = n - 1 - leftSize - rightSize;
            return remain >= (n + 1) / 2;
        }

        private void Find(TreeNode node, int x, ref TreeNode xNode)
        {
            if (xNode != null || node == null)
            {
                return;
            }

            if (node.val == x)
            {
                xNode = node;
                return;
            }

            Find(node.left, x, ref xNode);
            Find(node.right, x, ref xNode);
        }

        private int GetSubTreeSize(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + GetSubTreeSize(node.left) + GetSubTreeSize(node.right);
        }
    }
}

