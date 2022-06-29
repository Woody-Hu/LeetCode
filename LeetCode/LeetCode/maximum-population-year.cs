using System;
namespace LeetCode
{
    public class maximum_population_year
    {
        public int MaximumPopulation(int[][] logs)
        {
            var baseValue = 1950;
            var array = new int[110];
            foreach (var item in logs)
            {
                array[item[0] - baseValue]++;
                array[item[1] - baseValue]--;
            }

            var maxValue = 0;
            var res = 0;
            var current = 0;
            for (int i = 0; i < array.Length; i++)
            {
                current += array[i];
                if (current > maxValue)
                {
                    maxValue = current;
                    res = i;
                }
            }

            return res + baseValue;
        }
    }
}
