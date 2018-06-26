using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class FindModeinBinarySearchTree
    {
        public int[] FindMode(TreeNode root)
        {
            List<int> returnValue = new List<int>();
            int tempMaxCount =1;
            int tempNowCount = 1;
            int? templastValue = null;

            InnerMethod(root, ref tempMaxCount, ref tempNowCount, ref templastValue, ref returnValue);


            return returnValue.ToArray();
        }

        private void InnerMethod(TreeNode inputNode,ref int nowmaxCount,ref int nowCount,ref int? lastValue,ref List<int> returnValue )
        {
            if (null == inputNode)
            {
                return;
            }

            InnerMethod(inputNode.left,ref nowmaxCount,ref nowCount,ref lastValue,ref returnValue);

            if (null != lastValue && lastValue.Value == inputNode.val)
            {
                nowCount++;
            }
            else
            {
                nowCount = 1;
            }

            if (nowCount == nowmaxCount)
            {
                returnValue.Add(inputNode.val);
            }
            else if (nowCount > nowmaxCount)
            {
                nowmaxCount = nowCount;
                returnValue = new List<int>();
                returnValue.Add(inputNode.val);
            }

            lastValue = inputNode.val;

            InnerMethod(inputNode.right, ref nowmaxCount, ref nowCount, ref lastValue, ref returnValue);

        }

    }
}
