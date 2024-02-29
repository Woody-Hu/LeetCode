using System;
using System.Linq;

namespace LeetCode
{
	public class number_of_students_unable_to_eat_lunch
	{
        public int CountStudents(int[] students, int[] sandwiches)
        {
            var s1 = students.Sum();
            var s0 = students.Length - s1;
            for (int i = 0; i < sandwiches.Length; i++)
            {
                if (sandwiches[i] == 0 && s0 > 0)
                {
                    s0--;
                }
                else if (sandwiches[i] == 1 && s1 > 0)
                {
                    s1--;
                }
                else
                {
                    break;
                }
            }

            return s0 + s1;
        }
    }
}

