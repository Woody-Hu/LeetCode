using System;
namespace LeetCode
{
    public class lowest_common_ancestor_of_deepest_leaves
    {
        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var ld = CalcualteDeep(root.left);
            var rd = CalcualteDeep(root.right);
            if (ld == rd)
            {
                return root;
            }
            else if (ld > rd)
            {
                return LcaDeepestLeaves(root.left);
            }
            else
            {
                return LcaDeepestLeaves(root.right);
            }
        }

        private int CalcualteDeep(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var lD = CalcualteDeep(root.left);
            var rD = CalcualteDeep(root.right);
            return Math.Max(lD, rD) + 1;
        }
    }
}
