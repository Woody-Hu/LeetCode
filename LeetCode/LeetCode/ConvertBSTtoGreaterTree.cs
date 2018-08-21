using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ConvertBSTtoGreaterTree
    {
        
        public TreeNode ConvertBST(TreeNode root)
        {
            int tempSum = 0;

            InnerMethod(root, ref tempSum);

            return root;
        }

        private void InnerMethod(TreeNode inputNode,ref int nowSum)
        {
            if (null == inputNode)
            {
                return;
            }

            InnerMethod(inputNode.right, ref nowSum);
            inputNode.val += nowSum;
            nowSum = inputNode.val;
            InnerMethod(inputNode.left, ref nowSum);
        }
    }
}
