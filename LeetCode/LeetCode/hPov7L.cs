using System;
using System.Collections.Generic;

namespace LeetCode;

public class hPov7L
{
    public IList<int> LargestValues(TreeNode root) {
        if (root == null) {
            return new List<int>();
        }
        IList<int> res = new List<int>();
        DFS(res, root, 0);
        return res;
    }

    public void DFS(IList<int> res, TreeNode root, int curHeight) {
        if (curHeight == res.Count) {
            res.Add(root.val);
        } else {
            res[curHeight] = Math.Max(res[curHeight], root.val);
        }
        if (root.left != null) {
            DFS(res, root.left, curHeight + 1);
        }
        if (root.right != null) {
            DFS(res, root.right, curHeight + 1);
        }
    }
}