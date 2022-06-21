using System;
namespace LeetCode
{
    public class rings_and_rods
    {
        public int CountPoints(string rings)
        {
            var list = new int[10];
            for (int i = 0; i < rings.Length; i+=2)
            {
                var pi = rings[i + 1] - '0';
                char color = rings[i];
                switch (color)
                {
                    case 'R':
                        list[pi] |= 1;
                        break;
                    case 'G':
                        list[pi] |= 2;
                        break;
                    case 'B':
                        list[pi] |= 4;
                        break;
                }
            }

            int res = 0;
            foreach (var item in list)
            {
                if (item == 7)
                {
                    res++;
                }

            }

            return res;
        }
    }
}
