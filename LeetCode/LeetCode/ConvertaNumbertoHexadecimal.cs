using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ConvertaNumbertoHexadecimal
    {
        public string ToHex(int num)
        {
            if (0 == num)
            {
                return "0";
            }
            char[] useHexValue = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };

            var useTagValue = num & 0xFFFFFFFF;

            List<char> lstReturnValue = new List<char>();

            while (useTagValue!=0)
            {
                var tempValue = useTagValue & 0XF;

                lstReturnValue.Add(useHexValue[tempValue]);

                useTagValue >>= 4;
            }

            lstReturnValue.Reverse();

            return new string(lstReturnValue.ToArray());

        }
    }
}
