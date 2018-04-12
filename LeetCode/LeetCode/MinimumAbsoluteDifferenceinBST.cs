using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MinimumAbsoluteDifferenceinBST
    {
        public int GetMinimumDifference(TreeNode root)
        {
            int returnValue = int.MaxValue;
            int? frontValue = null;

            GetValueMinLoop(root, ref returnValue, ref frontValue);

            return returnValue;
        }

        private void GetValueMinLoop(TreeNode root,ref int minValue,ref int? frontValue)
        {
            if (null == root)
            {
                return;
            }
            GetValueMinLoop(root.left, ref minValue, ref frontValue);

            if (null != frontValue)
            {
                minValue = Math.Min(minValue, root.val - frontValue.Value);
            }

            frontValue = root.val;

            GetValueMinLoop(root.right, ref minValue, ref frontValue);

        }
    }
}
