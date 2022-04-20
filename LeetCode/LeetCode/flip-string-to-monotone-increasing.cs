using System;
namespace LeetCode
{
    public class flip_string_to_monotone_increasing
    {
        public int MinFlipsMonoIncr(string s)
        {
            var res = 0;
            var count = 0;
            foreach (var item in s)
            {
                if (item == '1')
                {
                    count++;
                }
                else
                {
                    res = Math.Min(res + 1, count);
                }
            }

            return res;

        }
    }
}
