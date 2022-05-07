using System;
namespace LeetCode
{
	public class number_of_days_in_a_month
	{
		public int NumberOfDays(int year, int month)
		{
			var current = new DateTime(year, month, 1);
			var nextMonth = current.AddMonths(1);
			return (int)(nextMonth - current).TotalDays;
		}
	}
}

