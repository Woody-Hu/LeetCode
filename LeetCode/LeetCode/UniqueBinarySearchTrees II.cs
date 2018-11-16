using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UniqueBinarySearchTrees_II
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
            {
                return new List<TreeNode>();
            }
            return GenerateTrees(1, n);
        }

        private List<TreeNode> GenerateTrees(int startIndex, int endIndex)
        {
            List<TreeNode> returnValue = new List<TreeNode>();
            if (startIndex > endIndex)
            {
                returnValue.Add(null);
                return returnValue;
            }

            if (startIndex == endIndex)
            {
                returnValue.Add(new TreeNode(startIndex));
                return returnValue;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                var leftNodes = GenerateTrees(startIndex, i-1);
                var rightNodes = GenerateTrees(i + 1, endIndex);

                foreach (var oneLeftNode in leftNodes)
                {
                    foreach (var oneRightNode in rightNodes)
                    {
                        var node = new TreeNode(i)
                        {
                            left = oneLeftNode,
                            right = oneRightNode
                        };
                        returnValue.Add(node);
                    }
                }
            }

            return returnValue;
        }
    }
}
