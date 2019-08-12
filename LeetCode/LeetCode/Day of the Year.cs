using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Day_of_the_Year
    {
        private static int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public int DayOfYear(string date)
        {
            int[] time = date.Split('-').Select(int.Parse).ToArray();
            int days = 0;
            for (int i = 0; i < time[1] - 1; ++i)
                days += month[i];
            return days + time[2] + (time[1] > 2 && (time[0] % 4 == 0 && time[0] % 100 != 0 || time[0] % 400 == 0) ? 1 : 0);
        }
    }
}
