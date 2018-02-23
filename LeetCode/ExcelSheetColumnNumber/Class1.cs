


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetColumnNumber
{
    public class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            string sUP = s.ToUpper();
            int returnValue = 0;
            int stringLength = s.Length;
            char a = 'A';

            for (int i = 0; i < stringLength; i++)
            {
                int tempValue = (sUP[i] - a) + 1;
                tempValue = tempValue * ((int)Math.Pow((double)26, (double)(stringLength - i - 1)));
                returnValue = returnValue + tempValue;
            }

            return returnValue;
        }
    }
}
