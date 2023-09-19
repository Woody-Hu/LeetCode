using System;
using System.Text;

namespace LeetCode
{
	public class faulty_keyboard
	{
        public string FinalString(string s)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in s)
            {
                if (item == 'i')
                {
                    var array = stringBuilder.ToString().ToCharArray();
                    Array.Reverse(array);
                    stringBuilder = new StringBuilder(new string(array));
                }
                else
                {
                    stringBuilder.Append(item);
                }
            }

            return stringBuilder.ToString();
        }
    }
}

