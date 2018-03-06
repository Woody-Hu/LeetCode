using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class FindBottomLeftTreeValue
    {
        public int FindBottomLeftValueMethod(TreeNode root)
        {
            int returnValue = 0;
            int nowIndex = int.MinValue;
            int nowDeep = int.MinValue;

            FindLoop(root, 0, 0,ref nowDeep,ref returnValue,ref nowIndex);

            return returnValue;

        }

        private void FindLoop(TreeNode inputNode,int inputIndex,int inputDeep,ref int nowDeep,ref int nowReturnValue,ref int nowIndex)
        {
            if (null == inputNode.left && null == inputNode.right)
            {
                if (inputDeep > nowDeep )
                {
                    nowDeep = inputDeep;
                    nowIndex = inputIndex;
                    nowReturnValue = inputNode.val;
                }
                else if (inputDeep == nowDeep && inputIndex > nowIndex)
                {
                    nowDeep = inputDeep;
                    nowIndex = inputIndex;
                    nowReturnValue = inputNode.val;
                }
                return;
            }
            if (null != inputNode.left)
            {
                FindLoop(inputNode.left, 2 * inputIndex + 2,inputDeep + 1,ref nowDeep, ref nowReturnValue,ref nowIndex);
            }
            if (null != inputNode.right)
            {
                FindLoop(inputNode.right, 2 * inputIndex + 1, inputDeep + 1, ref nowDeep, ref nowReturnValue, ref nowIndex);
            }
        }
    }
}
