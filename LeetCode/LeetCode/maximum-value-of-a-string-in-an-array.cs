using System;
namespace LeetCode
{
	public class maximum_value_of_a_string_in_an_array
	{
        public int MaximumValue(string[] strs)
        {
            var res = 0;
            foreach (var item in strs)
            {
                var isDigits = true;
                var n = item.Length;
                for (int i = 0; i < n; i++)
                {
                    isDigits = isDigits && Char.IsDigit(item[i]);
                }

                res = Math.Max(res, isDigits ? int.Parse(item) : n);
            }

            return res;
        }
    }
}

