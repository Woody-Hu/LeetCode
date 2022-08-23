using System;
namespace LeetCode
{
    public class check_if_a_string_can_break_another_string
    {
		public bool CheckIfCanBreak(string s1, string s2)
		{
			var c1 = s1.ToCharArray();
			var c2 = s2.ToCharArray();
			Array.Sort(c1);
			Array.Sort(c2);
			var pre = c1[0] - c2[0];
			for (int i = 0; i < c1.Length; i++)
			{
				if (c1[i] - c2[i] < 0 && pre > 0)
					return false;
				if (c1[i] - c2[i] > 0 && pre < 0)
					return false;
				if (c1[i] - c2[i] != 0)
					pre = c1[i] - c2[i];
			}
			return true;
		}
    }
}
