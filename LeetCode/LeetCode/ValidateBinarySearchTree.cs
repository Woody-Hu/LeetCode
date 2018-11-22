using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }

        private bool IsValidBST(TreeNode root, TreeNode lowNode, TreeNode upNode)
        {
            if (null == root)
            {
                return true;
            }

            if (null != lowNode && root.val <= lowNode.val)
            {
                return false;
            }

            if (null != upNode && root.val >= upNode.val)
            {
                return false;
            }

            var leftValue = IsValidBST(root.left, lowNode, root);
            var rightValue = IsValidBST(root.right, root, upNode);

            return leftValue && rightValue;
        }
    }
}
