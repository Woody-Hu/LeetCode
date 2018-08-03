using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SearchinaBinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (null == root)
            {
                return null;
            }

            if (val == root.val)
            {
                return root;
            }
            else if (val < root.val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
        }
    }
}
