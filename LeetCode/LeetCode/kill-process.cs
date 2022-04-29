using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class kill_process
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var pidIndexs = new Dictionary<int, int>();
            for (int i = 0; i < pid.Count; i++)
            {
                pidIndexs.Add(pid[i], i);
            }

            var killIndex = pidIndexs[kill];
            var parents = new int[pid.Count];
            for (int i = 0; i < pid.Count; i++)
            {
                parents[i] = i;
            }

            for (int i = 0; i < ppid.Count; i++)
            {
                var ppidValue = ppid[i];
                if (ppidValue == 0)
                {
                    continue;
                }

                var parentIndex = pidIndexs[ppid[i]];
                Merge(parents, parentIndex, i, killIndex);
            }

            var res = new List<int>();
            for (int i = 0; i < parents.Length; i++)
            {
                var parentIndex = Find(parents, i);
                if (parentIndex == killIndex)
                {
                    res.Add(pid[i]);
                }
            }

            return res;
        }

        private int Find(int[] parents, int i)
        {
            if (parents[i] == i)
            {
                return i;
            }
            else
            {
                var parent = Find(parents, parents[i]);
                parents[i] = parent;
                return parent;
            }

        }

        private void Merge(int[] parents, int parent, int child, int kill)
        {
            if (child == kill)
            {
                return;
            }

            parents[Find(parents, child)] = parents[Find(parents, parent)];
        }
    }
}
