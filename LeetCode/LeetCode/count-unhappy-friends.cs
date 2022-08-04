using System;
namespace LeetCode
{
    public class count_unhappy_friends
    {
        public int UnhappyFriends(int n, int[][] preferences, int[][] pairs)
        {
            var order = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    order[i, preferences[i][j]] = j;
                }
            }

            var match = new int[n];
            foreach (int[] pair in pairs)
            {
                int person0 = pair[0], person1 = pair[1];
                match[person0] = person1;
                match[person1] = person0;
            }

            var res = 0;
            for (int x = 0; x < n; x++)
            {
                int y = match[x];
                int index = order[x, y];
                for (int i = 0; i < index; i++)
                {
                    int u = preferences[x][i];
                    int v = match[u];
                    if (order[u, x] < order[u, v])
                    {
                        res++;
                        break;
                    }
                }
            }
            return res;
        }
    }
}
