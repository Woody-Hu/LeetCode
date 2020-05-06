using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Number_of_Days_Between_Two_Dates
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            var dateTime1 = DateTime.Parse(date1);
            var dateTime2 = DateTime.Parse(date2);

            return Math.Abs((int)((dateTime2 - dateTime1).TotalDays));
        }
    }
}
