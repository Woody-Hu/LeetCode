using System;
namespace LeetCode
{
    public class Remove_One_Element_to_Make_the_Array_Strictly_Increasing
    {

        public bool CanBeIncreasing(int[] nums)
        {
            int previous = nums[0];
            bool find = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= previous)
                {
                    if (find)
                    {
                        return false;
                    }

                    find = true;
                    if (i == 1 || nums[i] > nums[i - 2])
                    {
                        previous = nums[i];
                    }
                }
                else
                {
                    previous = nums[i];
                }
            }
            return true;
        }
    }
}
