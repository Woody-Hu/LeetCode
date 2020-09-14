using System;
namespace LeetCode
{
    public class Make_The_String_Great
    {
        public Make_The_String_Great()
        {
        }

        public string MakeGood(string s)
        {
            var checkRange = Math.Abs('A' - 'a');
            var arr = s.ToCharArray();
            int i = 0;
            for (int j = 0; j < arr.Length; j++, i++)
            {
                arr[i] = arr[j];
                if (i > 0 && Math.Abs(arr[i] - arr[i - 1]) == checkRange)
                {
                    i -= 2;
                }
            }

            return new string(arr, 0, i);
        }
    }
}
