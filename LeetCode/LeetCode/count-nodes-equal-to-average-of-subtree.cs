using System;
namespace LeetCode
{
    public class count_nodes_equal_to_average_of_subtree
    {
        public int AverageOfSubtree(TreeNode root)
        {
            var res = 0;
            Visit(root, ref res);
            return res;
        }

        private (int, int) Visit(TreeNode root, ref int res)
        {
            if (root == null)
            {
                return (0, 0);
            }

            var left = Visit(root.left, ref res);
            var right = Visit(root.right, ref res);
            var count = left.Item2 + right.Item2 + 1;
            var sum = root.val + left.Item1 + right.Item1;
            var avg = sum / count;
            if (avg == root.val)
            {
                res++;
            }

            return (sum, count);
        }
    }
}
