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
            int n = current ^ (1 << root.val);
            if (root.left == null && root.right == null)
            {
                if (n == 0 || (n & (n - 1)) == 0)
                {
                    ++res;
                }

                return;
            }

            if (root.left != null)
            {
                Visit(root.left, n, ref res);
            }

            if (root.right != null)
            {
                Visit(root.right, n, ref res);
            }
        }
    }
}
