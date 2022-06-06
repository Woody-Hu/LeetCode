using System;
namespace LeetCode
{
    public class deepest_leaves_sum
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            var res = 0;
            var maxDep = 0;
            Visit(root, 0, ref maxDep, ref res);
            return res;
        }

        private void Visit(TreeNode root, int currentDep, ref int maxDep, ref int res)
        {
            if (root == null)
            {
                return;
            }

            if (root.left == null && root.right == null)
            {
                if (currentDep > maxDep)
                {
                    maxDep = currentDep;
                    res = root.val;
                }
                else if (currentDep == maxDep)
                {
                    res += root.val;
                }
            }
            else
            {
                Visit(root.left, currentDep + 1, ref maxDep, ref res);
                Visit(root.right, currentDep + 1, ref maxDep, ref res);
            }
        }
    }
}
