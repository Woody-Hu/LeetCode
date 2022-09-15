using System;
namespace LeetCode
{
    public class number_of_operations_to_make_network_connected
    {
        public int MakeConnected(int n, int[][] connections)
        {
            if (connections.Length < n - 1)
            {
                return -1;
            }

            var parents = new int[n];
            var count = n;
            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
            }

            foreach (var item in connections)
            {
                Link(parents, item[0], item[1], ref count);
            }

            return count - 1;
        }

        private int FindParent(int[] parents, int i)
        {
            if (parents[i] == i)
            {
                return i;
            }
            else
            {
                parents[i] = FindParent(parents, parents[i]);
                return parents[i];
            }
        }

        private void Link(int[] parents, int left, int right, ref int count)
        {
            var pl = FindParent(parents, left);
            var pr = FindParent(parents, right);
            if (pl == pr)
            {
                return;
            }

            var useL = pl;
            var useR = pr;
            if (pl > pr)
            {
                useL = pr;
                useR = pl;
            }

            parents[useL] = useR;
            count--;
        }
    }
}
