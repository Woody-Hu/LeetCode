using System;
namespace LeetCode
{
    public class count_good_nodes_in_binary_tree
    {
        public int GoodNodes(TreeNode root)
        {
            var res = 0;
            Visit(root, root.val, ref res);
            return res;
        }

        private void Visit(TreeNode root, int currentMax, ref int res)
        {
            if (root == null)
            {
                return;
            }

            var currentValue = root.val;
            if (currentValue >= currentMax)
            {
                res++;
                currentMax = currentValue;
            }

            Visit(root.left, currentMax, ref res);
            Visit(root.right, currentMax, ref res);
        }
    }
}
