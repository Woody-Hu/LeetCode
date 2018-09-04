using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class IncreasingOrderSearchTree
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode returnValue = null;
            TreeNode useParent = null;

            InnerMethod(root, ref returnValue, ref useParent);
            return returnValue;
        }

        private void InnerMethod(TreeNode inputRoot,ref TreeNode inputReturnValue,ref TreeNode inputParent)
        {
            if (null == inputRoot)
            {
                return;
            }

            InnerMethod(inputRoot.left, ref inputReturnValue, ref inputParent);

            if (null == inputReturnValue)
            {
                inputReturnValue = new TreeNode(inputRoot.val);
                inputParent = inputReturnValue;
            }
            else if(null != inputParent)
            {

                inputParent.right = new TreeNode(inputRoot.val);
                inputParent = inputParent.right;
            }

            InnerMethod(inputRoot.right, ref inputReturnValue, ref inputParent);

        }
    }
}
