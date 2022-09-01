using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class find_players_with_zero_or_one_losses
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var res = new List<IList<int>>();
            var loser = new Dictionary<int, int>();
            var wt = new HashSet<int>();
            var lt = new HashSet<int>();
            foreach (var arr in matches)
            {
                if (!loser.ContainsKey(arr[1]))
                    loser.Add(arr[1], 1);
                else loser[arr[1]]++;
            }

            foreach (var arr in matches)
            {
                if (!loser.ContainsKey(arr[0]))
                    wt.Add(arr[0]);
                if (loser.ContainsKey(arr[1]) && loser[arr[1]] == 1)
                    lt.Add(arr[1]);
            }

            var wtl = wt.ToList();
            wtl.Sort();
            res.Add(wtl);
            var ltl = lt.ToList();
            ltl.Sort();
            res.Add(ltl);
            return res;
        }
    }
}
