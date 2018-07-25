using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LongestUnivaluePath
    {
        public int LongestUnivaluePathMethod(TreeNode root)
        {
            int returnValue = 0;

            InnerMethod(root, null, ref returnValue);

            return returnValue;
        }

        private int InnerMethod(TreeNode input,TreeNode preNode,ref int returnValue)
        {
            if (input == null)
            {
                return 0;
            }

            int nowLeftLength = InnerMethod(input.left, input, ref returnValue);
            int nowRightLength = InnerMethod(input.right, input, ref returnValue);

            returnValue = Math.Max(returnValue, nowLeftLength + nowRightLength);

            int nowLength = 0;

            if (null != preNode && preNode.val == input.val)
            {
                nowLength = Math.Max(nowLeftLength, nowRightLength) + 1;
            }

            return nowLength;
        }
    }
}
