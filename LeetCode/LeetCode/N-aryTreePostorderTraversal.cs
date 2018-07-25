using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class N_aryTreePostorderTraversal
    {
        public IList<int> Postorder(Node root)
        {
            List<int> returnValue = new List<int>();

            InnerMethod(root, returnValue);

            return returnValue;
        }

        private void InnerMethod(Node input,List<int> returnValue)
        {
            if (null == input)
            {
                return;
            }

            if (null != input.children)
            {
                foreach (var item in input.children)
                {
                    InnerMethod(item, returnValue);
                }
            }

            returnValue.Add(input.val);
        }
    }
}
