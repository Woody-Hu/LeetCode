using System.Collections.Generic;

namespace LeetCode;

public class WNC0Lk
{
    public IList<int> RightSideView(TreeNode root)
    {
        var res = new List<int>();
        var stack = new List<TreeNode>();
        if (root != null)
        {
            stack.Add(root);
        }
        else
        {
            return res;
        }
        
        while (stack.Count > 0)
        {
            var n = stack.Count;
            var newStack = new List<TreeNode>();
            for (int i = 0; i < n; i++)
            {
                var node = stack[i];
                if (i == n - 1)
                {
                    res.Add(node.val);
                }
                if (node.left != null)
                {
                    newStack.Add(node.left);
                }
                if (node.right != null)
                {
                    newStack.Add(node.right);
                }
            }

            stack = newStack;
        }
        
        return res;
    }
}