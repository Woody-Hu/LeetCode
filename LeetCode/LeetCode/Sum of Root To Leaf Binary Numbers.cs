using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Sum_of_Root_To_Leaf_Binary_Numbers
    {
        public int SumRootToLeaf(TreeNode root)
        {
            return SumRootToLeaf(root, 0);
        }

        private int SumRootToLeaf(TreeNode root, int value)
        {
            if (root == null)
            {
                return 0;
            }

            value = value << 1;
            value += root.val;
            if (root.left == null && root.right == null)
            {
                return value;
            }

            var leftValue = SumRootToLeaf(root.left, value);
            var rightValue = SumRootToLeaf(root.right, value);
            return leftValue + rightValue;
        }
    }
}
