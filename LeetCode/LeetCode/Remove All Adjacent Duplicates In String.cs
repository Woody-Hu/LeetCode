using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Remove_All_Adjacent_Duplicates_In_String
    {
        public string RemoveDuplicates(string S)
        {
            var array = new Char[S.Length];
            int current = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (current > 0 && S[i] == array[current-1])
                {
                    current--;
                }
                else
                {
                    array[current++] = S[i];
                }
            }

            return new string(array, 0, current);
        }
    }
}
