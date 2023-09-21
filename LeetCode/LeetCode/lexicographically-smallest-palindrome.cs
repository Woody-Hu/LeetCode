using System;
namespace LeetCode
{
	public class lexicographically_smallest_palindrome
	{
        public string MakeSmallestPalindrome(string s)
        {
            var arr = s.ToCharArray();
            var n = s.Length;
            for (int i = 0; i < n/2; i++)
            {
                var j = n - i - 1;
                if (arr[i] != arr[j])
                {
                    var c = arr[i] < arr[j] ? arr[i] : arr[j];
                    arr[i] = c;
                    arr[j] = c;
                }
            }

            return new string(arr);
        }
    }
}

