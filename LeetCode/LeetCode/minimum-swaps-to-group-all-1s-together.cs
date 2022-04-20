using System;
namespace LeetCode
{
    public class minimum_swaps_to_group_all_1s_together
    {
        public int MinSwaps(int[] data)
        {
            var totalOneCount = 0;
            foreach (var item in data)
            {
                totalOneCount += item;
            }

            if (totalOneCount == 0 || totalOneCount == 1)
            {
                return 0;
            }

            var current = 0;
            for (int i = 0; i < totalOneCount; i++)
            {
                current += data[i];
            }

            var temp = current;
            for (int i = totalOneCount; i < data.Length ; i++)
            {
                current = current - data[i - totalOneCount] + data[i];
                temp = Math.Max(current, temp);
            }

            return totalOneCount - temp;
        }
    }
}
