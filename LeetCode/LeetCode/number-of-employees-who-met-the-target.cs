using System;
using System.Linq;

namespace LeetCode
{
	public class number_of_employees_who_met_the_target
	{
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            return hours.Where(k => k >= target).Count();
        }
    }
}

