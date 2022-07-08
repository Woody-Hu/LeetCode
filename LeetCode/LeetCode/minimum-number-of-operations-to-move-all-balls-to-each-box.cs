using System;
namespace LeetCode
{
    public class minimum_number_of_operations_to_move_all_balls_to_each_box
    {
        public int[] MinOperations(string boxes)
        {
            var res = new int[boxes.Length];
            var left = 0;
            var right = 0;
            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i] == '1')
                {
                    res[0] += i;
                    right++;
                }
            }


            for (int i = 1; i < boxes.Length; i++)
            {
                if (boxes[i - 1] == '1')
                {
                    left += 1;
                    right -= 1;
                }

                res[i] = res[i - 1] - right + left;
            }

            return res;
        }
    }
}
