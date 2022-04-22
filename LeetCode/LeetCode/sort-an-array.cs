using System;
namespace LeetCode
{
    public class sort_an_array
    {
        public int[] SortArray(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void QuickSort(int[] nums, int l, int r)
        {
            if (l < r)
            {
                var i = QuickPartitionSort(nums, l, r);
                QuickSort(nums, l, i - 1);
                QuickSort(nums, i + 1, r);
            }
        }


        private int QuickPartitionSort(int[] nums, int l, int r)
        {
            var i = Random.Shared.Next(r - l + 1) + l;
            Swap(nums, r, i);
            return SortInPartition(nums, l, r);
        }

        private int SortInPartition(int[] nums, int l, int r)
        {
            var tag = nums[r];
            var i = l - 1;
            for (int j = l; j <= r - 1; j++)
            {
                if (nums[j] <= nums[r])
                {
                    i = i + 1;
                    Swap(nums, i, j);
                }
            }

            Swap(nums, i + 1, r);
            return i + 1;
        }

        private void Swap(int[] nums, int l, int r)
        {
            var temp = nums[r];
            nums[r] = nums[l];
            nums[l] = temp;
        }
    }
}

