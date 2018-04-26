using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class IntegertoEnglishWords
    {
        private readonly string[] LESS_THAN_20 = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        private readonly string[] TENS = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private readonly string[] THOUSANDS = { "", "Thousand", "Million", "Billion" };

        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";

            int i = 0;
            StringBuilder words = new StringBuilder("");

            while (num > 0)
            {
                if (num % 1000 != 0)
                    words.Insert(0, innerMethod(num % 1000) + THOUSANDS[i] + " ") ;
                num /= 1000;
                i++;
            }

            return words.ToString().Trim();
        }

        private String innerMethod(int num)
        {
            if (num == 0)
                return "";
            else if (num < 20)
                return LESS_THAN_20[num] + " ";
            else if (num < 100)
                return TENS[num / 10] + " " + innerMethod(num % 10);
            else
                return LESS_THAN_20[num / 100] + " Hundred " + innerMethod(num % 100);
        }
    }
}
