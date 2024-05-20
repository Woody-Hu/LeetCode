using System.Collections.Generic;

namespace LeetCode;

public class zhong_jian_er_cha_shu_lcof
{
    private int[] _order;
    
    private Dictionary<int, int> _indexMap = new Dictionary<int, int>();
    
    
    public TreeNode DeduceTree(int[] preorder, int[] inorder) {
        _order = preorder;
        for (int i = 0; i < inorder.Length; i++) {
            _indexMap[inorder[i]] = i;
        }
        
        return Recur(0, 0, inorder.Length - 1);
    }

    private TreeNode Recur(int root, int left, int right)
    {
        if (left > right) return null;
        TreeNode node = new TreeNode(_order[root]);
        int i = _indexMap[_order[root]];
        node.left = Recur(root + 1, left, i - 1);
        node.right = Recur(root + i - left + 1, i + 1, right);
        return node;
    }
}