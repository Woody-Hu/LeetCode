using System;
namespace LeetCode
{
    public class reverse_odd_levels_of_binary_tree
    {
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            Visit(root.left, root.right, 1);
            return root;
        }

        private void Visit(TreeNode l, TreeNode r, int level)
        {
            if (l == null)
            {
                return;
            }

            if (level % 2 != 0)
            {
                var temp = l.val;
                l.val = r.val;
                r.val = temp;
            }

            Visit(l.left, r.right, level + 1);
            Visit(l.right, r.left, level + 1);
        }
    }
}
