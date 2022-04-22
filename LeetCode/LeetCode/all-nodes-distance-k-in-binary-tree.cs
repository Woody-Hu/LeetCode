using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class all_nodes_distance_k_in_binary_tree
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            if (k == 0)
            {
                return new List<int>() { target.val };
            }

            var parentDic = new Dictionary<int, TreeNode>();
            var nodeDic = new Dictionary<int, TreeNode>();
            var visit = new HashSet<int>();
            SetParent(root, null, parentDic, nodeDic);
            var res = new List<int>();
            var children = parentDic.Where(k => k.Value != null && k.Value.val == target.val).Select(k => k.Key);
            foreach (var item in children)
            {
                GetChildWithKDistance(nodeDic[item], visit, k - 1, res);
            }

            var pK = k;
            var current = nodeDic[target.val];
            visit.Add(target.val);
            while (pK > 0 && current != null )
            {
                pK = pK - 1;
                current = parentDic[current.val];
                GetChildWithKDistance(current, visit, pK, res);
            }

            return res;
        }

        private void SetParent(TreeNode root, TreeNode parent, Dictionary<int, TreeNode> parentDic, Dictionary<int, TreeNode> nodeDic)
        {
            if (root == null)
            {
                return;
            }

            parentDic[root.val] = parent;
            nodeDic[root.val] = root;
            SetParent(root.left, root, parentDic, nodeDic);
            SetParent(root.right, root, parentDic, nodeDic);
        }

        private void GetChildWithKDistance(TreeNode root, HashSet<int> visit, int k, List<int> res)
        {
            if (root == null)
            {
                return;
            }

            if (visit.Contains(root.val))
            {
                return;
            }

            visit.Add(root.val);
            if (k == 0)
            {
                res.Add(root.val);
                return;
            }

            GetChildWithKDistance(root.left, visit, k - 1, res);
            GetChildWithKDistance(root.right, visit, k - 1, res);
        }

    }
}
