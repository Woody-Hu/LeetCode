using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LicenseKeyFormatting
    {
        public string LicenseKeyFormattingMethod(string S, int K)
        {
            StringBuilder returnValue = new StringBuilder();

            var useString = S.Replace("-",string.Empty);

            Stack<string> tempStack = new Stack<string>();

            int tempIndex = useString.Length - 1;

            while ((tempIndex - K +1) >= 0)
            {
                tempStack.Push(useString.Substring(tempIndex - K + 1, K));
                tempIndex = tempIndex - K;
            }

            if (tempIndex >= 0)
            {
                tempStack.Push(useString.Substring(0, tempIndex + 1));
            }

            while (tempStack.Count != 0)
            {
                var tempString = tempStack.Pop().ToUpper();

                returnValue.Append(tempString);

                if (tempStack.Count != 0)
                {
                    returnValue.Append("-");
                }
            }

            return returnValue.ToString();


        }
    }
}
