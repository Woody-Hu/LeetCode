using System;
namespace LeetCode
{
	public class boats_to_save_people
	{
        public int NumRescueBoats(int[] people, int limit)
        {
            var res = 0;
            Array.Sort(people);
            var l = 0;
            var r = people.Length - 1;
            while (l <= r)
            {
                if (people[l] + people[r] <= limit)
                {
                    l++;
                }

                r--;
                res++;
            }

            return res;
        }
    }
}

