using System;
namespace LeetCode
{
    public class partitioning_into_minimum_number_of_deci_binary_numbers
    {
        public int MinPartitions(string n)
        {
            var res = 0;
            foreach (var item in n)
            {
                res = Math.Max(res, item - '0');
            }

            return res;
        }
    }
}
