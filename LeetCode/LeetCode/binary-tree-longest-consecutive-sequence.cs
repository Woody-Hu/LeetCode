using System;
namespace LeetCode
{
    public class binary_tree_longest_consecutive_sequence
    {
        public int LongestConsecutive(TreeNode root)
        {
            var res = 0;
            Visit(root, null, 0, ref res);
            return res;
        }

        private void Visit(TreeNode root, TreeNode pre, int preLength, ref int length)
        {
            if (root == null)
            {
                return;
            }

            var res = 1;
            if (pre != null && root.val == pre.val + 1)
            {
                res = preLength + 1;
            }

            length = Math.Max(res, length);
            Visit(root.left, root, res, ref length);
            Visit(root.right, root, res, ref length);
        }
    }
}
