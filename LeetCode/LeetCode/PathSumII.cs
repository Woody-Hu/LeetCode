using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class PathSumII
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            var visited = new List<int>();
            var returnValue = new List<IList<int>>();
            PathSum(root, sum, returnValue, visited);
            return returnValue;
        }

        private void PathSum(TreeNode node, int sum, IList<IList<int>> returnValue, IList<int> visited)
        {
            if (node == null)
            {
                return;
            }

            visited.Add(node.val);
            if (null == node.left && null == node.right && node.val == sum)
            {
                returnValue.Add(new List<int>(visited));
            }

            if (null != node.left)
            {
                PathSum(node.left, sum - node.val, returnValue, visited);
            }

            if (null != node.right)
            {
                PathSum(node.right, sum - node.val, returnValue, visited);
            }
            visited.RemoveAt(visited.Count-1);
        }
    }
}
