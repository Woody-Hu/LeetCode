using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class path_crossing
    {
        public bool IsPathCrossing(string path)
        {
            var set = new HashSet<int>();
            var x = 0;
            var y = 0;
            set.Add(0);
            foreach (var item in path)
            {
                switch (item)
                {
                    case 'N': --x; break;
                    case 'S': ++x; break;
                    case 'W': --y; break;
                    case 'E': ++y; break;
                }

                var thumbnail = CalculateThumbnail(x, y);
                if (set.Contains(thumbnail))
                {
                    return true;
                }

                set.Add(thumbnail);
            }

            return false;
        }

        private int CalculateThumbnail(int x, int y)
        {
            return x * 20001 + y;
        }
    }
}
