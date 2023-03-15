using System;
namespace LeetCode
{
    public class maximal_network_rank
    {
        public int MaximalNetworkRank(int n, int[][] roads)
        {
            var links = new bool[n, n];
            var degrees = new int[n];
            foreach (var item in roads)
            {
                links[item[0], item[1]] = true;
                links[item[1], item[0]] = true;
                degrees[item[0]]++;
                degrees[item[1]]++;
            }

            var res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int rank = degrees[i] + degrees[j] - (links[i, j] ? 1 : 0);
                    res = Math.Max(res, rank);
                }
            }

            return res;
        }
    }
}
