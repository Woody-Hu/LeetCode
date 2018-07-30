using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class N_aryTreePreorderTraversal
    {
        public IList<int> Preorder(Node root)
        {
            List<int> returnValue = new List<int>();

            InnerMethod(root, returnValue);

            return returnValue;
        }

        private void InnerMethod(Node inputRoot,List<int> returnValue)
        {
            if (null == inputRoot)
            {
                return;
            }

            returnValue.Add(inputRoot.val);

            if (null != inputRoot.children)
            {
                foreach (var oneItem in inputRoot.children)
                {
                    InnerMethod(oneItem, returnValue);
                }
            }
        }
    }
}
