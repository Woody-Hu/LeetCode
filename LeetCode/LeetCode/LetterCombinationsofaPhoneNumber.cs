using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LetterCombinationsofaPhoneNumber
    {

        public IList<string> LetterCombinations(string digits)
        {
            List<string> returnValue = new List<string>();
            Dictionary<char, string> useDic = new Dictionary<char, string>();
            String[] lstBase = new String[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            for (int tempIndex = 0; tempIndex < lstBase.Length; tempIndex++)
            {
                useDic.Add( ((tempIndex + 2).ToString()[0]), lstBase[tempIndex]);
            }

            foreach (var oneChar in digits)
            {
                returnValue = Calculate(returnValue, useDic[oneChar]);
            }




            return returnValue;
        }

        private List<string> Calculate(List<string> firstRound,string inputUseString)
        {
            List<string> returnValue = new List<string>();

            foreach (var oneChar in inputUseString)
            {
                if (0 == firstRound.Count)
                {
                    returnValue.Add(oneChar.ToString());
                    continue;
                }

                foreach (var oneString in firstRound)
                {
                    var tempString = oneString + oneChar;
                    returnValue.Add(tempString);
                }
            }

            return returnValue;
        }


    }
}
