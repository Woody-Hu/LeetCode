using System;
namespace LeetCode
{
	public class furthest_point_from_origin
	{
        public int FurthestDistanceFromOrigin(string moves)
        {
            var lc = 0;
            var lr = 0;
            var dic = new int[3];
            var res = 0;
            foreach (var item in moves)
            {
                if (item == 'L')
                {
                    dic[0]++;
                }
                else if (item == 'R')
                {
                    dic[1]++;
                }
                else
                {
                    dic[2]++;
                }
            }

            if (dic[0] >= dic[1])
            {
                dic[0] += dic[2];
                res = dic[0] - dic[1];
            }
            else
            {
                dic[1] += dic[2];
                res = dic[1] - dic[0];
            }

            return res;
        }
    }
}

