using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            if (word[0] >= 'A' && word[0] <= 'Z')
            {
                if (word.Equals(word.ToUpper()))
                {
                    return true;
                }
                else
                {
                    var tempValue = word.Substring(1);

                    return tempValue.Equals(tempValue.ToLower());
                }
            }
            else if (word[0] >= 'a' && word[0] <= 'z')
            {
                return word.Equals(word.ToLower());
            }
            else
            {
                return false;
            }
   
        }
    }
}
