using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            var useList = new List<int>();

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (null == node)
                {
                    continue;
                }
                useList.Add(node.val);
                stack.Push(node.right);
                stack.Push(node.left);
            }

            return useList;
        }

    }
}
