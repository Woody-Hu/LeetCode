using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BinaryTreeTilt
    {
        public int FindTilt(TreeNode root)
        {
            int returnValue = 0;
            FindTiltLoop(root, ref returnValue);
            return returnValue;
        }

        private int FindTiltLoop(TreeNode input,ref int sumValue)
        {
            if (null == input)
            {
                return 0;
            }

            int useLeftValue = FindTiltLoop(input.left, ref sumValue);

            int useRightValue = FindTiltLoop(input.right, ref sumValue);

            var tempUseTilt = Math.Abs(useLeftValue - useRightValue);

            sumValue += tempUseTilt;

            return useLeftValue + useRightValue + input.val;


        }
    }
}
