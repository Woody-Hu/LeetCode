using System.Collections.Generic;

namespace LeetCode;

public class recover_a_tree_from_preorder_traversal
{
    public TreeNode RecoverFromPreorder(string traversal) {
        var path = new List<TreeNode>();
        var pos = 0;
        while (pos < traversal.Length) {
            var level = 0;
            while (traversal[pos] == '-') {
                level++;
                pos++;
            }
            var value = 0;
            while (pos < traversal.Length && char.IsDigit(traversal[pos])) {
                value = value * 10 + (traversal[pos] - '0');
                pos++;
            }
            var node = new TreeNode(value);
            if (level == path.Count) {
                if (path.Count > 0) {
                    path[^1].left = node;
                }
            } else {
                while (level != path.Count) {
                    path.RemoveAt(path.Count - 1);
                }
                path[^1].right = node;
            }
            path.Add(node);
        }
        
        return path[0];

    }
}