using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class House_Robber_III
    {
        public int Rob(TreeNode root)
        {
            int[] maxVal = DpRob(root);
            return Math.Max(maxVal[0], maxVal[1]);
        }

        private int[] DpRob(TreeNode root)
        {
            if (root == null)
            {
                return new int[] {0, 0};
            }
            else
            {
                int[] maxVal = new int[2];
                int[] leftMax = DpRob(root.left);
                int[] rightMax = DpRob(root.right);
                maxVal[0] = Math.Max(leftMax[0], leftMax[1]) + Math.Max(rightMax[0], rightMax[1]);
                maxVal[1] = leftMax[0] + rightMax[0] + root.val;
                return maxVal;
            }
        }
    }
}
