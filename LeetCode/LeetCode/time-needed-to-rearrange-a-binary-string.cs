using System;
namespace LeetCode
{
	public class time_needed_to_rearrange_a_binary_string
	{
        public int SecondsToRemoveOccurrences(string s)
        {
            var f = 0;
            var pre0 = 0;
            foreach (var item in s)
            {
                if (item == '0')
                {
                    pre0++;
                }
                else if (pre0 > 0)
                {
                    f = Math.Max(f + 1, pre0);
                }

            }

            return f;
        }
    }
}

