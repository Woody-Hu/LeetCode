using System;
using System.Text;

namespace LeetCode
{
    public class find_unique_binary_string
    {
        public string FindDifferentBinaryString(string[] nums)
        {
            var stringBuilder = new StringBuilder();
            var n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i][i] == '0')
                {
                    stringBuilder.Append('1');
                }
                else
                {
                    stringBuilder.Append('0');
                }
            }

            return stringBuilder.ToString();
        }
    }
}
