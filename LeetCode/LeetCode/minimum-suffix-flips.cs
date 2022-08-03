using System;
namespace LeetCode
{
    public class minimum_suffix_flips
    {
        public int MinFlips(string target)
        {
            var res = 0;
            var pre = '0';
            foreach (var item in target)
            {
                if (pre != item)
                {
                    res++;
                    pre = item;
                }
            }

            return res;
        }
    }
}
