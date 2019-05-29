using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Minimum_Genetic_Mutation
    {
        public int MinMutation(string start, string end, string[] bank)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (var oneStr in bank)
            {
                set.Add(oneStr);
            }

            if (!set.Contains(end))
                return -1;

            char[] choices = { 'A', 'C', 'G', 'T' };
            Queue<string> queue = new Queue<string>();
            int res = 0;
            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                for (int k = queue.Count; k > 0; k--)
                {
                    var gene = queue.Dequeue();
                    if (end.Equals(gene))
                        return res;
                    for (int i = 0; i < gene.Length; i++)
                    {
                        char[] newGene = gene.ToCharArray();
                        foreach (var c in choices)
                        {
                            newGene[i] = c;
                            var s = new string(newGene);
                            if (set.Contains(s) && !s.Equals(gene))
                            {
                                queue.Enqueue(s);
                                set.Remove(s);
                            }
                        }
                    }
                }
                res++;
            }
            return -1;
        }
    }
}
