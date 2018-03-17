using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CountCompleteTreeNodes
    {
        private int countDeep(TreeNode inputNode)
        {
            return null == inputNode? -1 : 1+countDeep(inputNode.left);
        }

        public int CountNodes(TreeNode root)
        {
            int nowDeep = countDeep(root);

            return 0 > nowDeep ? 0 : nowDeep - 1 == countDeep(root.right) ? (1 << nowDeep) + CountNodes(root.right) : (1 << (nowDeep - 1)) + CountNodes(root.left);
        }

      
    }
}
