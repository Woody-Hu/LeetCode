using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class DiameterofBinaryTree
    {
        public int DiameterOfBinaryTreeMethod(TreeNode root)
        {
            int returnValue = 0;
            Length(root, ref returnValue);
            return returnValue;


        }

        private int Length(TreeNode root ,ref int maxValue)
        {
            if (null == root)
            {
                return 0;
            }

            int leftValue = Length(root.left,ref maxValue);
            int rightValue = Length(root.right, ref maxValue);

            maxValue = Math.Max(leftValue + rightValue, maxValue);

            return Math.Max( leftValue ,rightValue) + 1;
        }
    }
}
