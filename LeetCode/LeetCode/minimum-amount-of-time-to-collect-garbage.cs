using System;
namespace LeetCode
{
    public class minimum_amount_of_time_to_collect_garbage
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            var m = 0;
            var p = 0;
            var g = 0;
            for (int i = 0; i < garbage.Length; i++)
            {
                if (garbage[i].Contains("M"))
                {
                    m = i;
                }

                if (garbage[i].Contains("P"))
                    p = i;
                if (garbage[i].Contains("G"))
                    g = i;
            }

            var res = 0;
            foreach (var item in garbage)
            {
                res += item.Length;
            }

            for (int i = 0; i < m; i++)
            {
                res += travel[i];
            }
            for (int i = 0; i < p; i++)
            {
                res += travel[i];
            }
            for (int i = 0; i < g; i++)
            {
                res += travel[i];
            }

            return res;
        }
    }
}
