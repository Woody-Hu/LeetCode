using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SecondMinimumNodeInaBinaryTree
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            int returnValue = -1;

            HashSet<int> tempSet = new HashSet<int>();

            InnerMethod(root, tempSet);


            if (tempSet.Count > 1)
            {
                var tempLst = tempSet.OrderBy(k => k);
                returnValue = tempLst.ElementAt(1);
            }

            return returnValue;
        }

        private void InnerMethod(TreeNode inputNode,HashSet<int> useSet)
        {
            if (null == inputNode.left && null == inputNode.right)
            {
                useSet.Add(inputNode.val);
                return;
            }

            if (null == inputNode.left || null == inputNode.right)
            {
                return;
            }

            useSet.Add(Math.Min(inputNode.right.val, inputNode.left.val));

            InnerMethod(inputNode.left, useSet);
            InnerMethod(inputNode.right, useSet);
        }
    }
}
