using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LeetCode
{
    class Fraction_to_Recurring_Decimal
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            var stringBuilder = new StringBuilder();

            if (0 == denominator)
            {
                return stringBuilder.ToString();
            }

            if (numerator < 0 && denominator > 0 || numerator > 0 && denominator < 0)
            {
                stringBuilder.Append("-");
            }

            var useNumerator =  Math.Abs((long)numerator);
            var useDenominator =  Math.Abs((long)denominator);

            var useRemainder = useNumerator % useDenominator;
            var useValue = useNumerator / useDenominator;

            stringBuilder.Append(useValue);

            if (0 == useRemainder)
            {
                return stringBuilder.ToString();
            }

            stringBuilder.Append(".");
            var remainderDic = new Dictionary<long,int>();
            while (!remainderDic.ContainsKey(useRemainder))
            {
                remainderDic.Add(useRemainder, stringBuilder.Length);
                useValue = useRemainder * 10 / useDenominator;
                useRemainder = useRemainder * 10 % useDenominator;
                if (useRemainder != 0 || useRemainder == 0 && !remainderDic.ContainsKey(useRemainder))
                {
                    stringBuilder.Append(useValue);
                }
            }
            if (useRemainder != 0)
            {
                stringBuilder.Insert(remainderDic[useRemainder], "(");
                stringBuilder.Append(')');
            }

            return stringBuilder.ToString();

        }
    }
}
