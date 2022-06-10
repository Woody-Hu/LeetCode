using System;
using System.Linq;

namespace LeetCode
{
    public class number_of_laser_beams_in_a_bank
    {
        public int NumberOfBeams(string[] bank)
        {
            var res = 0;
            var last = 0;
            foreach (var item in bank)
            {
                var count = item.Count(k => k == '1');
                if (count != 0)
                {
                    res += last * count;
                    last = count;
                }
            }

            return res;
        }
    }
}
