using System;
namespace LeetCode
{
	public class number_of_students_doing_homework_at_a_given_time
	{
		public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
		{
			var res = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                {
					res++;
                }
            }

			return res;
		}
	}
}

