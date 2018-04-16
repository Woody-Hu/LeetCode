using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MinimumDistanceBetweenBSTNodes
    {
        public int MinDiffInBST(TreeNode root)
        {
            int returnValue = int.MaxValue;

            int? frontValue = null;

            CalculateLoop(root, ref returnValue, ref frontValue);

            return returnValue;
        }

        public void CalculateLoop(TreeNode inputNode,ref int minDiffValue,ref int?frontValue)
        {
            if (null == inputNode)
            {
                return;
            }

            CalculateLoop(inputNode.left, ref minDiffValue, ref frontValue);

            if (null != frontValue)
            {
                minDiffValue = Math.Min(minDiffValue, Math.Abs(frontValue.Value - inputNode.val));

            }

            frontValue = inputNode.val;

            CalculateLoop(inputNode.right, ref minDiffValue, ref frontValue);
        }
    }
}
