using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> returnValue = new List<int>();
            InorderTraversal(root, returnValue);
            return returnValue;
        }

        private void InorderTraversal(TreeNode node, IList<int> visited)
        {
            if (null == node)
            {
                return;
            }

            InorderTraversal(node.left,visited);
            visited.Add(node.val);
            InorderTraversal(node.right,visited);
        }
    }
}
