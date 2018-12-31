using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Univalued_Binary_Tree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            int? value = null;
            return IsUnivalTree(root, ref value);
        }

        private bool IsUnivalTree(TreeNode root,ref int? value)
        {
            if (null == root)
            {
                return true;
            }

            if (null == value)
            {
                value = root.val;
            }
            else if (value != root.val)
            {
                return false;
            }

            var left = IsUnivalTree(root.left,ref value);
            var right = IsUnivalTree(root.right,ref value);
            return left && right;
        }
    }
}
