using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AverageofLevelsinBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> ll = new List<double>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int lvl = q.Count;
                double sum = 0;
                for (int i = 0; i < lvl; i++)
                {
                    if (q.Peek().left != null) q.Enqueue(q.Peek().left);
                    if (q.Peek().right != null) q.Enqueue(q.Peek().right);
                    sum += (double)(q.Dequeue().val);
                }

                sum = sum / ((double)lvl);
                ll.Add(sum);
            }
            return ll;


        }
    }
}
