using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class N_aryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();

            InnerMethod(root, returnValue, 0);

            return returnValue;
        }

        private void InnerMethod(Node inputNode, IList<IList<int>> inputLst,int useIndex)
        {
            if (null == inputNode)
            {
                return;
            }

            if (useIndex == inputLst.Count)
            {
                inputLst.Add(new List<int>());
            }

            var useLst = inputLst[useIndex];

            useLst.Add(inputNode.val);

            if (null == inputNode.children)
            {
                return;
            }

            foreach (var item in inputNode.children)
            {
                InnerMethod(item, inputLst, useIndex + 1);
            }
        }
    }
}
