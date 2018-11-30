using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FlattenBinaryTreetoLinkedList
    {
        public void Flatten(TreeNode root)
        {
            if (null == root)
            {
                return;
            }
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (null != node.right)
                {
                    stack.Push(node.right);
                    node.right = null;
                }
                if (null != node.left)
                {
                    stack.Push(node.left);
                    node.left = null;
                }

     

                if (stack.Count != 0)
                {
                    node.right = stack.Peek();
                }
            }
        }
    }
}
