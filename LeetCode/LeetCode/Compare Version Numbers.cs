using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Compare_Version_Numbers
    {
        public int CompareVersion(string version1, string version2)
        {
            var splitValue1 = version1.Split(".");
            var splitValue2 = version2.Split(".");

            var length = Math.Min(splitValue1.Length, splitValue2.Length);

            for (var i = 0; i < length; i++)
            {
                var intValue1 = int.Parse(splitValue1[i]);
                var intValue2 = int.Parse(splitValue2[i]);

                if (intValue1 > intValue2)
                {
                    return 1;
                }
                else if (intValue1 < intValue2)
                {
                    return -1;
                }
            }

            if (splitValue1.Length > splitValue2.Length)
            {
                for (var i = length; i < splitValue1.Length; i++)
                {
                    var intValue1 = int.Parse(splitValue1[i]);
                    if (0 != intValue1)
                    {
                        return 1;
                    }
                }
                return 0;
            }
            else if (splitValue1.Length < splitValue2.Length)
            {
                for (var i = length; i < splitValue2.Length; i++)
                {
                    var intValue2 = int.Parse(splitValue2[i]);
                    if (0 != intValue2)
                    {
                        return -1;
                    }
                }
                return 0;
            }

            return 0;
        }
    }
}
