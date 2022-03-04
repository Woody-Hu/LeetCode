using System;
namespace LeetCode
{
    public class Count_Operations_to_Obtain_Zero
    {
        public int CountOperations(int num1, int num2)
        {
            int res = 0;
            while (num1 > 0 && num2 >0)
            {
                if(num1 < num2)
                {
                    var tmp = num1;
                    num1 = num2;
                    num2 = tmp;
                }

                res += num1 / num2;
                num1 %= num2;
            }

            return res;
        }
    }
}
