using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MaximumDepthofN_aryTree
    {
        public int MaxDepth(Node root)
        {
            int returnValue = 0;

            InnerMethod(root, ref returnValue, 1);

            return returnValue;
        }

        private void InnerMethod(Node inputNode,ref int returnValue,int nowDeep)
        {
            if (null == inputNode)
            {
                return;
            }

            returnValue = Math.Max(returnValue, nowDeep);

            if (null != inputNode.children)
            {
                foreach (var item in inputNode.children)
                {
                    InnerMethod(item, ref returnValue, nowDeep + 1);
                }
            }
        }
    }
}
