using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class StringtoIntegerAtoi
    {
        public int MyAtoi(string str)
        {
            long useValue = 0;

            bool tag = true;

            int startIndex = 0;

            str = str.TrimStart();

            if (str.Length == 0)
            {
                return 0;
            }

            if (str[0] == '+')
            {
                startIndex++;
            }
            else if (str[0] == '-')
            {
                tag = false;
                startIndex++;

            }

            for (int i = startIndex; i < str.Length; i++)
            {
                if (!char.IsDigit( str[i]))
                {
                    break;
                }

                useValue = useValue * 10 + str[i] - '0';

                if (useValue > int.MaxValue && tag)
                {
                    return int.MaxValue;
                }
                else if (useValue > int.MaxValue && !tag)
                {
                    return int.MinValue;
                }
            }

            return tag ? (int)useValue : -1 * (int)useValue;
        }
    }
}
