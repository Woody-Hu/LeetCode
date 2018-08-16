using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class GoatLatin
    {
        public string ToGoatLatin(string S)
        {
            var spliteValue = S.Split(' ');

            HashSet<char> useSet = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };

            StringBuilder returnValue = new StringBuilder();

            int tempIndex = 0;

            string nowUseAppendstr = "a";

            foreach (var oneValue in spliteValue)
            {
                var useString = oneValue;
                if (useSet.Contains(Char.ToLower(oneValue[0])))
                {
                    useString = useString + "ma";
                }
                else
                {
                    useString = useString.Substring(1) + useString[0] + "ma";
                }

                useString = useString + nowUseAppendstr;

                returnValue.Append(useString);

                if (tempIndex != spliteValue.Length - 1)
                {
                    returnValue.Append(" ");
                }
                tempIndex++;

                nowUseAppendstr += "a";
            }

            return returnValue.ToString();

        }
    }
}
