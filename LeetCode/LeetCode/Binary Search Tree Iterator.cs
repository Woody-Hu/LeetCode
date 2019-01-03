using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BSTIterator
    {
        private readonly Stack<TreeNode> stack = new Stack<TreeNode>();

        public BSTIterator(TreeNode root)
        {
            SetNext(root);
        }

        /** @return the next smallest number */
        public int Next()
        {
            var node = stack.Pop();
            if (null == node)
            {
                return -1;
            }

            SetNext(node.right);
            return node.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return stack.Count != 0;
        }

        private void SetNext(TreeNode node)
        {
            while (null != node)
            {
                stack.Push(node);
                node = node.left;
            }
        }
    }
}
