using System;
namespace LeetCode
{
    public class Replace_All_Digits_with_Characters
    {
        public string ReplaceDigits(string s)
        {
            var array = s.ToCharArray();
            for (int i = 0; i < array.Length -1; i = i + 2)
            {
                var letter = array[i];
                var value = array[i + 1] - '0' + letter;
                array[i + 1] = (char)value;
            }

            return new string(array);
        }
    }
}
