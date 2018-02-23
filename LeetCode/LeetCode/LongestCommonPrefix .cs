using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestCommonPrefix 
    {
        public string LongestCommonPrefixMethod(string[] strs)
        {
            string returnValue = string.Empty;

            int sumSize = strs.Length;

            if (0 == sumSize)
            {
                return returnValue;
            }

            returnValue = strs[0];

            for (int tempIndex = 1; tempIndex < sumSize; tempIndex++)
            {
                if (returnValue.Length == 0 || strs[tempIndex].Length == 0)
                {
                    return string.Empty;
                }

                int tempLength = returnValue.Length < strs[tempIndex].Length ? 
                    returnValue.Length:strs[tempIndex].Length;

                int subIndex;

                for (subIndex = 0; subIndex < tempLength; subIndex++)
                {
                    if (returnValue[subIndex] != strs[tempIndex][subIndex])
                    {
                        break;
                    }
                }
                returnValue = returnValue.Substring(0, subIndex);
            }

            return returnValue;

            
        }
    }
}
