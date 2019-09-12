using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Day_of_the_Week
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            var days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (month < 3)
            {
                month += 12;
                year -= 1;
            }

            int c = year / 100;
            year = year % 100;
            int w = (c / 4 - 2 * c + year + year / 4 + 13 * (month + 1) / 5 + day - 1) % 7;
            return days[(w + 7) % 7];

        }
    }
}
