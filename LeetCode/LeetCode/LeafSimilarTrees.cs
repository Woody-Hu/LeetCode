using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LeafSimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> lstValue1 = new List<int>();
            List<int> lstValue2 = new List<int>();

            InnerMethod(root1, ref lstValue1);
            InnerMethod(root2, ref lstValue2);

            if (lstValue1.Count != lstValue2.Count)
            {
                return false;
            }

            for (int i = 0; i < lstValue1.Count; i++)
            {
                if (lstValue1[i] != lstValue2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void InnerMethod(TreeNode inputRoot,ref List<int> lstValue)
        {
            if (null == inputRoot)
            {
                return;
            }

            if (null == inputRoot.left && null == inputRoot.right)
            {
                lstValue.Add(inputRoot.val);
            }

            InnerMethod(inputRoot.left, ref lstValue);
            InnerMethod(inputRoot.right, ref lstValue);
        }
    }
}
