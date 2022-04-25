using System;
namespace LeetCode
{
    public class read_n_characters_given_read4
    {
        public int Read(char[] buf, int n)
        {
            int idx = 0;
            char[] buf4 = new char[4];
            int size = Read4(buf4);
            while (size > 0 && idx < n)
            {
                for (int i = 0; i < size && idx < n; ++i) buf[idx++] = buf4[i];
                size = Read4(buf4);
            }

            return idx;
        }

        private int Read4(char[] buf4)
        {
            return 0;
        }
    }
}
