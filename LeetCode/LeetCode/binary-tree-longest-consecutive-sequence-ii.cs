using System;
namespace LeetCode
{
    public class binary_tree_longest_consecutive_sequence_ii
    {
        public int LongestConsecutive(TreeNode root)
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

            var increase = 1;
            var decrease = 1;
            if (root.left != null)
            {
                var leftRes = Visit(root.left, ref res);
                if (root.val == root.left.val + 1)
                {
                    decrease = leftRes.Item2 + 1;
                }
                else if (root.val == root.left.val - 1)
                {
                    increase = leftRes.Item1 + 1;
                }
            }

            if (root.right != null)
            {
                var rightRes = Visit(root.right, ref res);
                if (root.val == root.right.val + 1)
                {
                    decrease = Math.Max(decrease, rightRes.Item2 + 1);
                }
                else if (root.val == root.right.val - 1)
                {
                    increase = Math.Max(increase, rightRes.Item1 + 1);
                }
            }

            res = Math.Max(res, increase + decrease - 1);
            return (increase, decrease);
        }
    }
}
