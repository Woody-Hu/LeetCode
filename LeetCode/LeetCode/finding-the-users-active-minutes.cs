using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class finding_the_users_active_minutes
    {
        public int[] FindingUsersActiveMinutes(int[][] logs, int k)
        {
            Array.Sort(logs, new ArrayComparer());
            var res = new int[k];
            var id = logs[0][0];
            var ticket = logs[0][1];
            var count = 0;
            for (int i = 1; i < logs.Length; i++)
            {
                if (logs[i][0] != id)
                {
                    res[count]++;
                    count = 0;
                    ticket = logs[i][1];
                    id = logs[i][0];
                }
                else if (ticket < logs[i][1])
                {
                    count++;
                    ticket = logs[i][1];
                }
            }

            res[count]++;
            return res;
        }

        private class ArrayComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                if (x[0] == y[0])
                {
                    return x[1] - y[1];
                }

                return x[0] - y[0];
            }
        }
    }
}
