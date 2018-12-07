using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SumRoottoLeafNumbers
    {
        public int SumNumbers(TreeNode root)
        {
            var visitedNumber = new List<int>();
            var sum = 0;
            SumNumbers(root, visitedNumber, ref sum);
            return sum;
        }

        private void SumNumbers(TreeNode root, List<int> visitedNumber, ref int sum)
        {
            if (null == root)
            {
                return;
            }

            visitedNumber.Add(root.val);

            if (null == root.right && null == root.left)
            {
                var tempStringBuilder = new StringBuilder();

                foreach (var oneValue in visitedNumber)
                {
                    tempStringBuilder.Append(oneValue);
                }

                sum += int.Parse(tempStringBuilder.ToString());

            }
            else
            {
                SumNumbers(root.left, visitedNumber, ref sum);
                SumNumbers(root.right, visitedNumber, ref sum);
            }

            visitedNumber.RemoveAt(visitedNumber.Count - 1);
        }
    }
}
