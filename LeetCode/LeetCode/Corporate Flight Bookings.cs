using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Corporate_Flight_Bookings
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            var res = new int[n];
            foreach (var oneArray in bookings)
            {
                res[oneArray[0] - 1] += oneArray[2];
                if (oneArray[1] < n)
                {
                    res[oneArray[1]] -= oneArray[2];
                }
            }

            for (int i = 1; i < n; i++)
            {
                res[i] += res[i - 1];
            }

            return res;
        }
    }
}
