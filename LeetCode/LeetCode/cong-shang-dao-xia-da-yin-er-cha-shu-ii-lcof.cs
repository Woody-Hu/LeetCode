using System.Collections.Generic;

namespace LeetCode;

public class cong_shang_dao_xia_da_yin_er_cha_shu_ii_lcof
{
    public IList<IList<int>> DecorateRecord(TreeNode root)
    {
        var res = new List<IList<int>>();
        var list = new List<TreeNode>();
        if (root != null)
        {
            list.Add(root);
        }
        
        while (list.Count > 0)
        {
            var record = new List<int>();
            var next = new List<TreeNode>();
            foreach (var node in list)
            {
                record.Add(node.val);
                if (node.left != null)
                {
                    next.Add(node.left);
                }
                if (node.right != null)
                {
                    next.Add(node.right);
                }
            }
            res.Add(record);
            list = next;
        }
        
        return res;
    }
}