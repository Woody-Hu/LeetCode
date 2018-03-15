using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReplaceWords
    {
        public string ReplaceWordsMethod(IList<string> dict, string sentence)
        {
            string[] allsubString = sentence.Split(' ');

            var usedict = dict.OrderBy(k => k.Length);

            for (int i = 0; i < allsubString.Length; i++)
            {
                foreach (var oneStr in usedict)
                {
                    if (IfIsSuccessor(oneStr,allsubString[i]))
                    {
                        allsubString[i] = oneStr;
                        break;
                    }
                }
            }

            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < allsubString.Length; i++)
            {
                returnValue.Append(allsubString[i] + " ");
            }

            return returnValue.ToString().TrimEnd();




        }


        private bool IfIsSuccessor(string inputKey,string inputValue)
        {
            if (inputKey.Length > inputValue.Length)
            {
                return false;
            }

            return inputKey.Equals(inputValue.Substring(0, inputKey.Length));
        }
    }
}
