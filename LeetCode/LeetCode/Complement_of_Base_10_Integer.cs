using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Complement_of_Base_10_Integer
    {
        public int BitwiseComplement(int N) 
        {
            if(N == 0) return 1;
            int num = N;
            while((num & (num - 1)) != 0) {
            num = (num & (num - 1));
            }

            int xor = (num << 1) - 1;
            return N ^ xor;
        }
    }
}