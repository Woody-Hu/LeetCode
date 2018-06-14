using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class PathSumIII
    {
        public int PathSum(TreeNode root, int sum)
        {
            if (null == root)
            {
                return 0;
            }

            return innerMethod(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
        }

        private int innerMethod(TreeNode input,int sum)
        {
            if (null == input)
            {
                return 0;
            }

            int returnValue = (sum == input.val ? 1 : 0) + innerMethod(input.left, sum - input.val) + innerMethod(input.right, sum - input.val);

            return returnValue;

                
        }
    }
}
