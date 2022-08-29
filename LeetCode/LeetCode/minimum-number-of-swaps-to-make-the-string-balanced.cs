using System;
namespace LeetCode
{
    public class minimum_number_of_swaps_to_make_the_string_balanced
    {
        public int MinSwaps(string s)
        {
            var count = 0;
            var res = 0;
            foreach (var item in s)
            {
                if (item == '[')
                {
                    count++;
                }
                else if (count > 0)
                {
                    count--;
                }
                else
                {
                    count++;
                    res++;
                }
            }

            return res;
        }
    }
}
