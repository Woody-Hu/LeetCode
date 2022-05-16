using System;
namespace LeetCode
{
    public class find_distance_in_a_binary_tree
    {
        public int FindDistance(TreeNode root, int p, int q)
        {
            var res = 0;
            FindDistance(root, p, q, ref res);
            return res;
        }

        public int FindDistance(TreeNode root, int p, int q, ref int res)
        {
            if (p == q)
            {
                return 0;
            }

            if (res > 0)
            {
                return -1;
            }

            if (root == null)
            {
                return -1;
            }

            var left = FindDistance(root.left, p, q, ref res);
            var right = FindDistance(root.right, p, q, ref res);
            if ((left >= 0 && right >= 0) || ((left >= 0 || right >= 0) && (root.val == p || root.val == q)))
            {
                res = left + right + 2;
                return -1;
            }

            if (left >= 0 || right >= 0)
            {
                return left + right + 2;
            }


            if (root.val == p || root.val == q)
            {
                return 0;
            }

            return -1;
        }
    }
}
