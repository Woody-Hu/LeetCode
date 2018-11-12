using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class ReorderLogFiles
    {
        public string[] ReorderLogFilesMethod(string[] logs)
        {
            string[] orderedStrings = new string[logs.Length];
            List<KeyValuePair<string, string>> lstLetterValue = new List<KeyValuePair<string, string>>();
            List<string> lstDigitValue = new List<string>();
            foreach (var oneLog in logs)
            {
                int i = oneLog.IndexOf(' ');
                var content = oneLog.Substring(i + 1);
                if (char.IsDigit(content[0]))
                {
                    lstDigitValue.Add(oneLog);
                }
                else
                {
                    lstLetterValue.Add(new KeyValuePair<string, string>(content,oneLog));
                }
            }

            var orderValue = lstLetterValue.OrderBy(k => k.Key);

            int j = 0;

            foreach (var oneValue in orderValue)
            {
                orderedStrings[j++] = oneValue.Value;
            }

            foreach (var oneValue in lstDigitValue)
            {
                orderedStrings[j++] = oneValue;
            }

            return orderedStrings;
        }
    }
}
