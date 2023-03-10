using System;
namespace LeetCode
{
    public class maximum_total_importance_of_roads
    {
        public long MaximumImportance(int n, int[][] roads)
        {
            var values = new long[n];
            foreach (var item in roads)
            {
                values[item[0]]++;
                values[item[1]]++;
            }

            var cityValue = 1;
            Array.Sort(values);
            var res = 0l;
            foreach (var item in values)
            {
                res += item * cityValue;
                cityValue++;
            }

            return res;
        }
    }
}
