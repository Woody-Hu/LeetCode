using System;
namespace LeetCode
{
    public class Check_if_Numbers_Are_Ascending_in_a_Sentence
    {
        public bool AreNumbersAscending(string s)
        {
            var splited = s.Split(' ');
            var tag = 0;
            foreach (var item in splited)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    continue;
                }

                if (!char.IsDigit(item[0]))
                {
                    continue;
                }

                var currentValue = int.Parse(item);
                if (currentValue <= tag)
                {
                    return false;
                }

                tag = currentValue;
            }

            return true;
        }
    }
}
