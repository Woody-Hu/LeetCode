using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class StringCompression
    {
        public int Compress(char[] chars)
        {
            int nowCharIndex = 0;

            int nowIndex =0;

            int nowCount = 0;

            int useLength = chars.Length;

            while (nowIndex < useLength)
            {
                nowCount = 1;

                var tempChar = chars[nowIndex++];

                while (nowIndex < useLength && tempChar == chars[nowIndex])
                {
                    nowCount++;
                    nowIndex++;
                }

                if (nowCount > 1)
                {
                    chars[nowCharIndex++] = tempChar;
                    foreach (var oneChar in nowCount.ToString())
                    {
                        chars[nowCharIndex++] = oneChar;
                    }
                }
                else
                {
                    chars[nowCharIndex++] = tempChar;
                }
            }

            return nowCharIndex;
        }
    }
}
