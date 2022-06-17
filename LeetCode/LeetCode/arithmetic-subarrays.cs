using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class arithmetic_subarrays
	{
		public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
		{
			var res = new List<bool>(l.Length);
            for (int i = 0; i < l.Length; i++)
            {
				var li = l[i];
				var ri = r[i];
				var sub = new int[ri - li + 1];
				Array.Copy(nums, li, sub, 0, ri - li + 1);
				Array.Sort(sub);
				if (sub.Length <= 2)
				{
					res.Add(true);
				}
				else
				{
					var dif = sub[1] - sub[0];
					var added = false;
					for (int j = 2; j < sub.Length; j++)
					{
                        if ((sub[j] - sub[j - 1]) != dif)
                        {
							added = true;
							res.Add(false);
							break;
                        }
					}

                    if (!added)
                    {
						res.Add(true);
                    }
				}
            }

			return res;
		}
	}
}

