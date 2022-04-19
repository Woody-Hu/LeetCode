using System;
namespace LeetCode
{
    public class Next_Greater_Element_III
    {
        public int NextGreaterElement(int n)
        {
            char[] number = (n + "").ToCharArray();

            int i, j;
            for (i = number.Length - 1; i > 0; i--)
                if (number[i - 1] < number[i])
                    break;

            if (i == 0)
                return -1;

            int x = number[i - 1], smallest = i;
            for (j = i + 1; j < number.Length; j++)
                if (number[j] > x && number[j] <= number[smallest])
                    smallest = j;

            char temp = number[i - 1];
            number[i - 1] = number[smallest];
            number[smallest] = temp;

            Array.Sort(number, i, number.Length - i);

            long val = long.Parse(new String(number));
            return (val <= Int32.MaxValue) ? (int)val : -1;
        }
    }
}
