using System;
namespace LeetCode
{
    public class distribute_coins_in_binary_tree
    {
        public int DistributeCoins(TreeNode root)
        {
            var res = 0;
            Visit(root, ref res);
            return res;
        }

        private int Visit(TreeNode root, ref int res)
        {
            if (root == null)
            {
                return 0;
            }

            var l = Visit(root.left, ref res);
            var r = Visit(root.right, ref res);
            res += Math.Abs(l) + Math.Abs(r);
            return root.val + l + r - 1;
        }
    }
}
