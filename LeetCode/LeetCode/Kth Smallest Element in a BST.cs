using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Kth_Smallest_Element_in_a_BST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var current = root;
            int minCount = 0;

            while (stack.Count != 0 || null != current)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                else
                {
                    var node = stack.Pop();
                    if (++minCount == k)
                    {
                        return node.val;
                    }

                    current = node.right;
                }
            }

            return Int32.MinValue;
        }
    }
}
