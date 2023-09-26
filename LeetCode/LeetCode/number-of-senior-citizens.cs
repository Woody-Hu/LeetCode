using System;
namespace LeetCode
{
	public class number_of_senior_citizens
	{
        public int CountSeniors(string[] details)
        {
            var res = 0;
            foreach (var item in details)
            {
                if (int.Parse(item.Substring(11,2)) > 60)
                {
                    res++;
                }
            }

            return res;
        }
    }
}

