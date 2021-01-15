using System;
using System.Text;

namespace LeetCode
{
    public class Reformat_Phone_Number
    {
        public string ReformatNumber(string number)
        {
            StringBuilder st = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    st.Append(number[i]);
                }
            }

            int len = st.Length;
            int end = len - 1;

            if (len % 3 != 0 && len > 2)
            {
                st.Insert(end - 1, '-');
                end -= 2;

                if (len % 3 == 1 && len > 4)
                {
                    st.Insert(end - 1, '-');
                    end -= 2;
                }
            }

            for (int i = end - 2; i > 0; i -= 3)
            {
                st.Insert(i, '-');
            }

            return st.ToString();
        }
    }
}
