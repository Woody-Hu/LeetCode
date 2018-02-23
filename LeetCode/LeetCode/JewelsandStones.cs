using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class JewelsandStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int[] allCharInJ = new int[J.Length];

            for (int i = 0; i < J.Length; i++)
            {
                allCharInJ[i] = J[i];
            }

            var groupChar = S.GroupBy(k => k).ToDictionary(k => (int)k.Key, k => k.Count());

            int returnValue = 0;

            foreach (var oneChar in allCharInJ)
            {
                if (groupChar.ContainsKey(oneChar))
                {
                    returnValue = returnValue + groupChar[oneChar];
                }
            }

            return returnValue;


        }
    }
}
