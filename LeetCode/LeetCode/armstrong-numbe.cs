using System;
namespace LeetCode
{
	public class armstrong_numbe
	{
		public bool IsArmstrong(int n)
		{
			var length = n.ToString().Length;
			var res = 0;
			var temp = n;
            while (temp > 0)
            {
				var value = temp % 10;
				temp = temp / 10;
				res += (int)Math.Pow(value, length);
            }

			return res == n;
		}
	}
}

