using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class construct_binary_search_tree_from_preorder_traversal
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (!preorder.Any())
            {
                return null;
            }

            var root = new TreeNode(preorder[0]);
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            for (int i = 1; i < preorder.Length; i++)
            {
                var parent = stack.Peek();
                var current = new TreeNode(preorder[i]);
                while (stack.Any() && stack.Peek().val < current.val)
                {
                    parent = stack.Pop();
                }

                if (current.val < parent.val)
                {
                    parent.left = current;
                }
                else
                {
                    parent.right = current;
                }

                stack.Push(current);
            }

            return root;
        }
    }
}
