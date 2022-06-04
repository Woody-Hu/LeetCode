using System;
using System.Linq;

namespace LeetCode
{
	public class average_salary_excluding_the_minimum_and_maximum_salary
	{
		public double Average(int[] salary)
		{
            Array.Sort(salary);
            var len = salary.Length;
            var sum = 0.0d;
            for (int i = 1; i < len - 1; i++)
            {
                sum += salary[i];
            }

            return sum / (len - 2);
		}
	}
}

