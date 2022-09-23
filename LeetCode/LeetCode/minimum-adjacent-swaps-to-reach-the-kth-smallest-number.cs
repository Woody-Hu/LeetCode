using System;
namespace LeetCode
{
    public class minimum_adjacent_swaps_to_reach_the_kth_smallest_number
    {
        public int GetMinSwaps(string num, int k)
        {
            var n = num.Length;
            var ch = num.ToCharArray();
            while (k-- > 0)
            {
                int i = n - 2;
                while (i >= 0 && ch[i] >= ch[i + 1])
                {
                    i--;
                }
                int j = n - 1;

                if (i >= 0)
                {
                    while (j > 0 && ch[i] >= ch[j])
                    {
                        j--;
                    }
                    Swap(ch, i, j);
                }

                Reverse(ch, i + 1);
            }

            var res = 0;
            var ch1 = num.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                if (ch[i] == ch1[i]) continue;
                for (int j = i; j < n; j++)
                {
                    if (ch[i] == ch1[j])
                    {
                        res += j - i;
                        while (j > i)
                        {
                            Swap(ch1, j, j - 1);
                            j--;
                        }

                        break;
                    }
                }
            }

            return res;
        }

        private void Swap(char[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private void Reverse(char[] array, int i)
        {
            int j = array.Length - 1;
            while (i < j)
            {
                Swap(array, i, j);
                i++;
                j--;
            }
        }
    }
}
