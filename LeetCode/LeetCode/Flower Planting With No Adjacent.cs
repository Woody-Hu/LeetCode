using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Flower_Planting_With_No_Adjacent
    {
        public int[] GardenNoAdj(int N, int[][] paths)
        {
            var dic = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < N; i++)
                dic.Add(i, new HashSet<int>());

            foreach (var path in paths)
            {
                dic[path[0] - 1].Add(path[1] - 1);
                dic[path[1] - 1].Add(path[0] - 1);
            }


            int[] res = new int[N];
            for (int i = 0; i < N; i++)
            {
                int[] colors = new int[5];
                foreach (var j in dic[i])
                {
                    colors[res[j]] = 1;
                }

                for (int c = 4; c > 0; --c)
                    if (colors[c] == 0)
                        res[i] = c;
            }
            return res;
        }
    }
}
