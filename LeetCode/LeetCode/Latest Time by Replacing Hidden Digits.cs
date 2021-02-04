using System;
namespace LeetCode
{
    public class Latest_Time_by_Replacing_Hidden_Digits
    {
        public string MaximumTime(string time)
        {
            var prev = '-';
            char[] a = time.ToCharArray();
            for (int i = 0; i < time.Length; i++)
            {
                if (a[i] == '?')
                {
                    if (prev == '-')
                        a[i] = char.GetNumericValue(a[i + 1]) < 4 ? '2' : '1';
                    else if (prev == ':')
                        a[i] = '5';
                    else if (prev == '2' && i != time.Length - 1)
                        a[i] = '3';
                    else
                        a[i] = '9';
                }

                prev = a[i];

            }

            return new string(a);
        }
    }
}
