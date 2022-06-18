using System;
namespace LeetCode
{
	public class final_value_of_variable_after_performing_operations
	{
		public int FinalValueAfterOperations(string[] operations)
		{
			var res = 0;
            foreach (var item in operations)
            {
				if (item[1] == '-')
				{
					res--;
				}
				else
				{
					res++;
				}
            }

			return res;
		}
	}
}

