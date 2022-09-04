using System;
namespace LeetCode
{
    public class find_first_palindromic_string_in_the_array
    {
        public string FirstPalindrome(string[] words)
        {
            foreach (var item in words)
            {
                if (Check(item))
                {
                    return item;
                }
            }

            return String.Empty;
        }

        private bool Check(string input)
        {
            var l = 0;
            var r = input.Length - 1;
            while (l < r)
            {
                if (input[l] != input[r])
                {
                    return false;
                }

                l++;
                r--;
            }

            return true;

        }
    }
}

