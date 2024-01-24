using System;
namespace LeetCode
{
	public class _Etpl5
	{
        public int SumNumbers(TreeNode root)
        {
            return DFS(root, 0);
        }

        private int DFS(TreeNode node, int preSum)
        {
            if (node == null)
            {
                return 0;
            }

            var sum = preSum * 10 + node.val;
            if (node.left == null && node.right == null)
            {
                return sum;
            }
            else
            {
                return DFS(node.left, sum) + DFS(node.right, sum);
            }
        }
    }
}

