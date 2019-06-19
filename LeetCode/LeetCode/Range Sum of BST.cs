using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Range_Sum_of_BST
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            return RangeSumBST(root, L, R, 0);
        }

        private int RangeSumBST(TreeNode root, int L, int R, int sum)
        {
            if (root == null)
            {
                return sum;
            }

            if (!(root.val < L || root.val > R))
            {
                sum = sum + root.val;
            }

            if (root.val > L)
            {
                sum = RangeSumBST(root.left, L, R, sum);
            }

            if (root.val < R)
            {
                sum = RangeSumBST(root.right, L, R, sum);
            }

            return sum;
        }
    }
}
