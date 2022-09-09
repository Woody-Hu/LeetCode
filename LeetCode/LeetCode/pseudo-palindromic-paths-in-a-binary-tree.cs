using System;
namespace LeetCode
{
    public class pseudo_palindromic_paths_in_a_binary_tree
    {
        public int PseudoPalindromicPaths(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var res = 0;
            Visit(root, 0, ref res);
            return res;
        }

        private void Visit(TreeNode root, int current, ref int res)
        {
            if (root == null)
            {
                if (current == 0 || (current & (current - 1)) == 0)
                {
                    res++;
                }

                return;
            }

            current = current ^ (1 << root.val);
            Visit(root.left, current, ref res);
            Visit(root.right, current, ref res);
        }
    }
}
