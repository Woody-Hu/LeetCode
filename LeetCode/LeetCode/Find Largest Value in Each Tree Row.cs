using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_Largest_Value_in_Each_Tree_Row
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var res = new List<int>();
            if (root == null)
            {
                return res;
            }

            var currentStack = new Stack<TreeNode>();
            var nextStack = new Stack<TreeNode>();
            currentStack.Push(root);

            var currentMax = int.MinValue;
            while (currentStack.Count != 0 || nextStack.Count != 0)
            {
                if (currentStack.Count == 0)
                {
                    currentStack = nextStack;
                    nextStack = new Stack<TreeNode>();
                    res.Add(currentMax);
                    currentMax = int.MinValue;
                }

                var value = currentStack.Pop();
                currentMax = Math.Max(currentMax, value.val);
                if (value.left != null)
                {
                    nextStack.Push(value.left);
                }

                if (value.right != null)
                {
                    nextStack.Push(value.right);
                }
            }

            res.Add(currentMax);

            return res;
        }
    }
}
